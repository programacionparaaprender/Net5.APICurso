

## para que funcione entity framework debe usarse dotnet cli
https://docs.microsoft.com/en-us/ef/core/cli/dotnet
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli


dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef
dotnet ef migrations add InitialCreate
dotnet ef database update

FBTarjetas
dotnet new angular -o FBTarjeta -f netcoreapp3.1

dotnet new sln
dotnet sln add .\FBTarjeta\FBTarjeta.csproj
dotnet sln add .\Common\Common.csproj
dotnet sln add .\Models\Models.csproj



### documentaci�n de swagger
https://docs.microsoft.com/es-es/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio

### visualizar swagger
https://localhost:44372/swagger/index.html
https://localhost:44372/swagger/v1/swagger.json


## trabajar tokens
https://www.c-sharpcorner.com/article/implement-jwt-in-asp-net-core-3-1/


