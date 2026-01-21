# Catalog Service - Unified Government Digital Service Platform

## Overview
Catalog Service manages the list of government services available for citizens and residents.

## Tech Stack
- Backend: ASP.NET Core (.NET 8 LTS)
- Database: PostgreSQL (planned)
- Auth: JWT + RBAC (via Identity Service)
- API Testing: Swagger UI
- Containers: Docker (planned)

## How to Run
```bash
dotnet restore
dotnet run
Swagger UI:
https://localhost:PORT/swagger

Endpoints
GET /api/health

GET /api/catalog

Notes
This service is in scaffolding phase

Business logic will be added in later phases