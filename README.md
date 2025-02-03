# Questionary

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server
- AutoMapper
- Bootstrap 5
- jQuery
- ASP.NET Core MVC
- Entity Framework Migrations

## Prerequisites

- .NET 8.0 SDK
- SQL Server
- Visual Studio 2022 or VS Code

## Setup Instructions

1. Clone the repository
2. Update the connection string in `appsettings.json`

    ```json
    {
        "ConnectionStrings": {
            "QuestionaryContext": ""
        }
    }
    ```
3. Open terminal in the project directory
4. Run database migrations:
   ```bash
   dotnet ef database update
   ```
5. Run the application:
   ```bash
   dotnet run
   ```
   App will be accessible on  http://localhost:5179/
