#!/usr/bin/env python3
"""Apply deterministic generation fixes to the Keycloak Admin OpenAPI document."""

from __future__ import annotations

import json
import re
import sys
from pathlib import Path
from typing import Any

HTTP_METHODS = ("get", "put", "post", "delete", "patch", "head", "options", "trace")
METHOD_PREFIXES = {
    "get": "Get",
    "put": "Put",
    "post": "Create",
    "delete": "Delete",
    "patch": "Patch",
    "head": "Head",
    "options": "Options",
    "trace": "Trace",
}
PATH_PARAMETER_PATTERN = re.compile(r"\{([^{}]+)\}")
WORD_PATTERN = re.compile(r"[A-Za-z0-9]+")


def to_pascal_case(value: str) -> str:
    return "".join(word[:1].upper() + word[1:] for word in WORD_PATTERN.findall(value))


def operation_id(method: str, path: str) -> str:
    parts: list[str] = [METHOD_PREFIXES[method]]
    for segment in path.strip("/").split("/"):
        match = PATH_PARAMETER_PATTERN.fullmatch(segment)
        if match:
            parts.extend(("By", to_pascal_case(match.group(1))))
        else:
            parts.append(to_pascal_case(segment))
    return "".join(parts)


def apply_overrides(spec: dict[str, Any]) -> None:
    if spec.get("openapi") != "3.0.3":
        raise RuntimeError("Expected a Keycloak OpenAPI 3.0.3 document")
    if spec.get("info", {}).get("title") != "Keycloak Admin REST API":
        raise RuntimeError("Expected the Keycloak Admin REST API document")

    schemes = spec.setdefault("components", {}).setdefault("securitySchemes", {})
    schemes["HttpBearer"] = {
        "type": "http",
        "scheme": "bearer",
        "bearerFormat": "JWT",
    }
    spec["servers"] = [{"url": "http://localhost:8080"}]
    spec["security"] = [{"HttpBearer": []}]

    seen_operation_ids: set[str] = set()
    for path, path_item in spec.get("paths", {}).items():
        path_parameters = path_item.get("parameters", [])
        for method in HTTP_METHODS:
            operation = path_item.get(method)
            if not isinstance(operation, dict):
                continue

            generated_operation_id = operation_id(method, path)
            if generated_operation_id in seen_operation_ids:
                raise RuntimeError(f"Generated duplicate operationId: {generated_operation_id}")
            seen_operation_ids.add(generated_operation_id)
            operation["operationId"] = generated_operation_id
            operation["security"] = [{"HttpBearer": []}]

            parameters = operation.setdefault("parameters", [])
            declared = {
                parameter.get("name")
                for parameter in parameters
                if isinstance(parameter, dict) and parameter.get("in") == "path"
            }
            inherited_path_parameters = {
                parameter.get("name"): parameter
                for parameter in path_parameters
                if isinstance(parameter, dict) and parameter.get("in") == "path"
            }
            for parameter_name in PATH_PARAMETER_PATTERN.findall(path):
                if parameter_name in declared:
                    continue

                inherited_parameter = inherited_path_parameters.get(parameter_name)
                if inherited_parameter is not None:
                    parameters.append(dict(inherited_parameter))
                else:
                    parameters.append(
                        {
                            "name": parameter_name,
                            "in": "path",
                            "required": True,
                            "schema": {"type": "string"},
                        }
                    )


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_FILE")

    path = Path(sys.argv[1])
    with path.open(encoding="utf-8") as stream:
        spec = json.load(stream)

    apply_overrides(spec)

    with path.open("w", encoding="utf-8") as stream:
        json.dump(spec, stream, ensure_ascii=False, indent=2)
        stream.write("\n")


if __name__ == "__main__":
    main()
