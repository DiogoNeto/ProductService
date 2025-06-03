# XPTO Product Service

## Requisitos

- Docker
- .NET 8 SDK

## Como executar

```bash
docker-compose up

# CTT Product Service

Este é um serviço web RESTful desenvolvido em **.NET 8** que expõe uma API para registo e consulta de produtos. Os dados são armazenados numa base de dados **MongoDB**. O projeto faz parte de um exercício técnico para os CTT.

## Tecnologias Utilizadas

- .NET 8
- MongoDB
- ASP.NET Core Web API
- Docker (opcional)
- Swagger (para documentação da API)

## Funcionalidades

- Criar novo produto (`POST /api/products`)
- Obter produto por ID (`GET /api/products/{id}`)

## Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [MongoDB](https://www.mongodb.com/try/download/community) (local ou Docker)
- (Opcional) [Docker](https://www.docker.com/) e [Docker Compose](https://docs.docker.com/compose/)

## Configuração

1. Clone o repositório:

```bash
git clone https://github.com/DiogoNeto/ProductService.git
cd ProcuctService
