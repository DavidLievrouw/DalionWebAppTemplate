# [Dalion](https://www.dalion.eu) WebApp template

## Introduction
This repository contains a solution template, for a boilerplate web application:
- .NET Core 2.2 MVC app
- Versioned Web API with Swagger UI
- React front-end TypeScript app, using Semantic UI
- Azure AD security

## Installation

### NuGet package

The package is published on [nuget.org](https://www.nuget.org/packages/Dalion.WebApp/).

```cmd
dotnet new -i Dalion.WebApp
```

### Local

Clone this repository:
```bash
git clone https://github.com/DavidLievrouw/DalionWebAppTemplate.git
```

Run the following script to create a NuGet package from the template solution:
```powershell
.\template\001_CreateNupkgs.ps1
```

Run the following script to register the NuGet package locally:
```powershell
.\template\002_RegisterTemplates.ps1
```

## Usage

Create a directory where you want to create the solution. Navigate to that directory and open a command prompt.
Enter the following command to create the new solution:
```cmd
dotnet new dalionwebapp --name [SolutionName] --company [CompanyName] --domain [Domain]
```

An example:
```cmd
dotnet new dalionwebapp --name DalionWebShop --company Dalion --domain dalion.eu
```

## Remove

```cmd
dotnet new -u Dalion.WebApp
```