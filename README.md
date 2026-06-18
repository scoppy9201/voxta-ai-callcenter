# Voxta AI Call Center

AI-powered Call Center Platform built with ASP.NET Core 9 and Clean Architecture.

## Architecture

* Voxta.Api
* Voxta.Application
* Voxta.Domain
* Voxta.Infrastructure

## Features

* Customer Management
* Agent Management
* Call Management
* Recording Management
* Transcript Management
* AI Summary
* Lead Scoring

## Technology Stack

* ASP.NET Core 9
* Entity Framework Core 9
* SQL Server
* Swagger / OpenAPI

## Database

```bash
dotnet ef database update
```

## Migration

```bash
dotnet ef migrations add MigrationName
dotnet ef database update
```
