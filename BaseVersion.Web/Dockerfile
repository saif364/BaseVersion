# Use .NET SDK 8.0 as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /source

# Copy project files and restore dependencies
COPY HRM.Web/*.csproj HRM.Web/
COPY HRM.Models/*.csproj HRM.Models/
COPY HRM.Repository/*.csproj HRM.Repository/
COPY HRM.Service/*.csproj HRM.Service/

# Copy the entire solution and build the app
COPY . ./
RUN dotnet restore ./HRM.Web/HRM.Web.csproj --disable-parallel
RUN dotnet publish "./HRM.Web/HRM.Web.csproj" -c Release -o /app --no-restore
 

# Use .NET Runtime 8.0 to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0-focal
WORKDIR /app
COPY --from=build /app/out ./

# Expose the port the app will run on
EXPOSE 80

# Start the application
ENTRYPOINT ["dotnet", "HRM.Web.dll"]
