# GameJordan

An ASP.NET Core MVC web application (.NET 10) for a gaming storefront aimed at gamers in Jordan: games, consoles, and accessories.

> **Status: early stage.** The solution skeleton is in place. The catalog, accounts, and checkout described in the roadmap are not implemented yet.

## What exists today

- ASP.NET Core MVC project on **.NET 10** with Bootstrap and an Arabic (RTL-friendly) home page and navigation.
- `HomeController` with `Index` and `Privacy` views and a shared layout.
- `Category` model (`Id`, `Name`).
- Entity Framework Core (SQL Server provider) added to the project, with a LocalDB connection string (`SqlConnection`) ready in `appsettings.json`. The `DbContext` and migrations are not created yet.

## Tech stack

| Area | Technology |
|---|---|
| Framework | ASP.NET Core MVC, .NET 10 |
| Data (planned) | Entity Framework Core + SQL Server (LocalDB for development) |
| UI | Razor views, Bootstrap, jQuery |

## Getting started

**Prerequisites:** .NET 10 SDK.

```bash
git clone https://github.com/<your-username>/GameJordan.git
cd GameJordan
dotnet run --project GameJordan --launch-profile http
```

The site opens at `http://localhost:5238`.

## Roadmap

- [ ] `AppDbContext` and the first EF Core migration
- [ ] Product catalog: games, consoles, accessories, with categories
- [ ] Product listing, search, and filtering pages
- [ ] User registration and login (ASP.NET Core Identity)
- [ ] Shopping cart and checkout
- [ ] Admin area for managing products and orders
- [ ] Unit tests and a CI workflow

## Author

**Musab Al-Mohareb**, .NET Developer · musab.almharb@gmail.com
