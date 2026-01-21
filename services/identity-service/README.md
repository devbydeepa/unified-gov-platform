# Identity Service - Unified Government Digital Service Platform

## Overview
Identity Service handles user authentication and identity management.

## Tech Stack
- Backend: ASP.NET Core (.NET 8 LTS)
- Database: PostgreSQL (planned)
- Auth: JWT + RBAC (planned)
- API Gateway: YARP / Azure API Management
- API Testing: Swagger UI
- Containers: Docker (planned)

## How to Run
```bash
dotnet restore
dotnet build
dotnet run
Swagger UI:
https://localhost:PORT/swagger

Endpoints
GET /api/health

GET /api/auth/placeholder

Notes
This is scaffolding only

JWT, database, and real Auth logic will be added later

.http files included for testing