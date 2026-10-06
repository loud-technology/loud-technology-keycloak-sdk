# Keycloak Admin REST API .NET SDK

SDK .NET moderno e fortemente tipado para a Keycloak Admin REST API, gerado a partir de `keycloak-swagger.json` com [AutoSDK](https://www.nuget.org/packages/AutoSDK.CLI).

> Este é um SDK comunitário mantido pela loud-technology e não é um SDK oficial do projeto Keycloak.

## Recursos

- Cobertura das 415 operações presentes na especificação do repositório.
- Cliente raiz e clientes por domínio, incluindo `Users`, `Clients`, `Groups`, `Roles`, `RealmsAdmin` e `Organizations`.
- Autenticação Bearer com access token do Keycloak.
- Modelos fortemente tipados, serialização `System.Text.Json` gerada em compilação e validação.
- Métodos assíncronos, opções por requisição e hierarquia tipada de exceções HTTP.
- Geração reproduzível com AutoSDK `0.34.6` fixado no tool manifest.

## Requisitos

- .NET SDK 10 ou posterior para compilar.
- Um access token com as permissões administrativas necessárias no Keycloak.

## Instalação

```bash
dotnet add package Loud.Technology.Keycloak
```

## Uso rápido

```csharp
using Loud.Technology.Keycloak.Sdk;

using var client = new KeycloakClient(
    apiKey: "your-keycloak-access-token",
    baseUri: new Uri("https://identity.example.com"));

var realms = await client.RealmsAdmin.GetAdminRealmsAsync();
var users = await client.Users.GetAdminRealmsByRealmUsersAsync(
    realm: "my-realm",
    max: 100);
```

Também é possível configurar o cliente por variáveis de ambiente:

```bash
export KEYCLOAK_BASE_URL="https://identity.example.com"
export KEYCLOAK_ACCESS_TOKEN="your-keycloak-access-token"
```

```csharp
using var client = KeycloakClient.CreateFromEnvironment();
```

| Variável | Finalidade | Padrão |
|---|---|---|
| `KEYCLOAK_ACCESS_TOKEN` | Token enviado no header `Authorization: Bearer` | Obrigatória em `CreateFromEnvironment()` |
| `KEYCLOAK_BASE_URL` | URL raiz da instalação Keycloak | `http://localhost:8080` |

Não salve tokens no código-fonte. Use variáveis de ambiente, .NET user secrets ou um gerenciador de segredos.

## Organização da API

O `KeycloakClient` expõe clientes por tag da especificação, por exemplo:

```csharp
client.RealmsAdmin
client.Users
client.Clients
client.Groups
client.Roles
client.IdentityProviders
client.Organizations
client.AuthenticationManagement
```

Os nomes dos métodos são derivados deterministicamente do verbo e da rota porque a especificação original não contém `operationId`. Métodos terminados em `AsResponseAsync` também expõem status e headers HTTP.

## Gerar novamente

```bash
cd src/libs/Keycloak
./generate.sh
```

O script:

1. copia `keycloak-swagger.json` para `openapi.json`;
2. aplica correções determinísticas para URL, Bearer, `operationId` e parâmetros de rota ausentes;
3. restaura a versão fixada do AutoSDK;
4. substitui completamente a pasta `Generated/`.

## Build e testes

```bash
dotnet restore Loud.Technology.Keycloak.Sdk.slnx
dotnet build Loud.Technology.Keycloak.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.Keycloak.Sdk.slnx --configuration Release --no-build
dotnet pack src/libs/Keycloak/Loud.Technology.Keycloak.Sdk.csproj --configuration Release --no-build --output artifacts
```

Os testes de contrato são executados sem rede e validam a URL, rota e autenticação Bearer geradas.

## Licença

Licenciado sob a [MIT License](LICENSE).
