# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and solution files
COPY *.sln ./
COPY *.csproj ./

# Restore dependencies
RUN dotnet restore

# Copy all source code
COPY . ./

# Publish the app
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/publish .

# Expose container port
EXPOSE 8080

# Run the app
ENTRYPOINT ["dotnet", "CustomerRegistrationApp.dll"]