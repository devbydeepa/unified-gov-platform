\# Identity Service - Unified Government Digital Service Platform



\## Overview

Identity Service is a backend microservice for handling user authentication and identity management.  

Phase 5 includes controllers, Swagger UI, and skeleton folders. Business logic and database integration will be added in later phases.



\## Tech Stack

\- Backend: ASP.NET Core (.NET 8 LTS)  

\- Database: PostgreSQL (planned)  

\- Auth: JWT + RBAC (planned)  

\- API Gateway: YARP / Azure API Management  

\- Frontend: Swagger UI for testing  

\- Containers: Docker (planned)  



\## How to Run

1\. Clone the repo:

git clone https://github.com/devbydeepa/unified-gov-platform.git

cd unified-gov-platform/identity-service



Restore packages:

dotnet restore



Build the project:

dotnet build



Run the project:

dotnet run



Open Swagger UI:

https://localhost:PORT/swagger



Test Health endpoint:

GET /api/health

Response: "Identity Service is running"



Folder Structure



identity-service/

├── Controllers/

│   ├── AuthController.cs

│   └── HealthController.cs

├── Domain/Entities/User.cs

├── Application/Interfaces/IAuthService.cs

├── Application/Services/AuthService.cs

├── Infrastructure/Repositories/UserRepository.cs

├── Program.cs

├── appsettings.json

├── appsettings.Development.json

├── identity-service.csproj

└── README.md

Notes

.gitignore excludes bin/ and obj/ folders.



.http files are included for API testing.



Phase 6 will add JWT, database integration, and real Auth logic.



Author

Deepa Rajavel

GitHub: https://github.com/devbydeepa/unified-gov-platform

