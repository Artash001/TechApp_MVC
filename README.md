## Getting Started

### Prerequisites

- Visual Studio 2022 (or any compatible IDE)
- .NET 8 SDK
- Microsoft SQL Server
- SQL Server Management Studio (SSMS) or another SQL client

### Installation

1. Clone the repository: `git clone https://github.com/Artash001/TechApp_MVC`
2. Open the project in Visual Studio.
3. Configure the database connection in `appsettings.json`. Update the connection string with your MSSQL server details:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your-server;Database=your-database;User=your-username;Password=your-password;"
    }
    ```

4. Open SQL Server Management Studio (SSMS) or your preferred SQL client and create a database with the specified name in your connection string.
5. Run the migrations to create the database tables: `dotnet ef database update`.
6. Build and run the application.


## License

This project is licensed under the [MIT License](LICENSE).
