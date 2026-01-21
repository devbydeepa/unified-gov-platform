# Audit Service - Unified Government Digital Service Platform

## Overview
Audit Service tracks all actions in the platform for transparency and compliance.

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

GET /api/audits

Notes
Scaffolding phase only

Audit logging logic will be added in later phases