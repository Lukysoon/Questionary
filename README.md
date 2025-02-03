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

## Project Structure

```
RecordManagemant/
├── Controllers/             # MVC Controllers
├── Data/                   # DbContext and configurations
│   ├── Configurations/    # Entity configurations
│   └── Seeds/            # Database seed data
├── Entities/              # Domain entities
├── Mapping/               # AutoMapper profiles
├── Models/                # DTOs and view models
│   ├── Dto/             # Data transfer objects
│   └── Enums/           # Enumeration types
├── Resources/             # Localization resources
├── Services/              # Business logic services
├── Validation/            # Custom validation attributes
└── Views/                 # MVC views
    ├── Record/          # Record-related views
    └── Shared/          # Shared layouts and partials
```

## Features Details

### Record Creation
- First name and last name
- Personal Identification Number (PIN) with optional handling
- Date of birth with date picker
- Gender selection
- Email with validation
- Nationality selection from predefined list
- GDPR consent requirement

### Validation
- Client-side validation using jQuery Validation
- Server-side validation using Data Annotations
- Custom validation for conditional PIN requirement
- Email format validation
- Required field validation

### UI Features
- Responsive Bootstrap layout
- Dynamic form behavior
- Validation feedback
- Dropdown selections
- Date picker integration

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is licensed under the MIT License.
