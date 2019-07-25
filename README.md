# [Dalion](https://www.dalion.eu) WebApp template

## Status
[![NuGet Status](http://img.shields.io/nuget/v/Dalion.WebApp.svg?style=flat-square)](https://www.nuget.org/packages/Dalion.WebApp/)

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

## Change log

v1.0.7 - 2019-07-25
- Allow DisplayName and Description for Controllers in Swagger docs.
- Housekeeping in .csproj files.
- Update README.

v1.0.6 - 2019-07-14
- Got rid of wildcard template matching in DefaultController. Too obscure for some people. Hard-coding the routes feels less clean, but at least everyone understands.
- Fix an Azure AD login issue, after another of their unannounced breaking changes.
- Update all npm packages in front-end.
- Update README.

v1.0.5 - 2019-06-18
- The Api project now also targets netcoreapp2.2.
- When configuring services during webhost configuration, read configuration from the current webhost context, instead of the configuration that was built on startup.
- Update README.

v1.0.4 - 2019-06-11
- Less magic strings.
- Refactor and improve the custom authorization policy handlers.
- Update README.

v1.0.3 - 2019-05-29
- Rename PublishAzure publish profile to PublishFTP.
- Slight improvement to the user interaction detection in the MSAL library.
- Fixed invalid API url in the front-end.
- Fixed front-end app state refresh after login using redirect.
- Fixed authorization so that multiple scopes are allowed, and add logging.
- Update README.

v1.0.2 - 2019-05-08
- Add logging when validating the security token.
- Split up Publish build target in PublishFTP and PublishWebDeploy.
- Update README.

v1.0.1 - 2019-05-06
- Update [MSAL](https://www.npmjs.com/package/msal) dependency to v1.0.0.
- Show PII in logs when debugging.
- Update README.

v1.0.0 - 2019-05-04
- Initial release.
