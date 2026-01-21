# Notification Service - Unified Government Digital Service Platform

## Overview
Notification Service handles sending notifications (email/SMS) for application updates.

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

GET /api/notifications

Notes
This service is in scaffolding phase

Business logic (sending notifications) will be added later