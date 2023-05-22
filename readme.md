# Create SQLite Database
dotnet ef database update --context LoggingContext

# Import the Vorlagen in JTL Ameise and change the ID's in the Env.cs file

For updating the code:
# If the JTL Database is changed then create new Models with
dotnet ef dbcontext scaffold "Data Source=LAPTOP-Q593BSP3\JTLWAWI;Initial Catalog=EazyBusiness;User ID=sa;Password=sa04jT14;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer

# If the Bihr API is changed then create a new API Client with:
The Bihr API Client is created from https://api.bihr.net/swagger/v2.1/swagger.json with https://github.com/RicoSuter/NSwag/wiki/NSwagStudio 
