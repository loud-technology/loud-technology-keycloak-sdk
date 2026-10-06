#!/usr/bin/env bash
set -euo pipefail

readonly SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
readonly REPOSITORY_ROOT="$(cd -- "${SCRIPT_DIR}/../../.." && pwd)"
readonly AUTOSDK_VERSION="0.34.6"
readonly DEFAULT_BASE_URL="http://localhost:8080"

cd "${SCRIPT_DIR}"

cp "${REPOSITORY_ROOT}/keycloak-swagger.json" openapi.json
python3 apply-openapi-overrides.py openapi.json

dotnet tool restore
actual_version="$(dotnet tool run autosdk --version | sed 's/+.*//')"
if [[ "${actual_version}" != "${AUTOSDK_VERSION}" ]]; then
  echo "Expected AutoSDK ${AUTOSDK_VERSION}, but restored ${actual_version}." >&2
  exit 1
fi

rm -rf Generated

dotnet tool run autosdk generate openapi.json \
  --namespace Loud.Technology.Keycloak.Sdk \
  --clientClassName KeycloakClient \
  --methodNamingConvention MethodAndPath \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env KEYCLOAK_BASE_URL \
  --api-key-env KEYCLOAK_ACCESS_TOKEN \
  --validation \
  --generate-http-exception-hierarchy \
  --clean-stale-files
