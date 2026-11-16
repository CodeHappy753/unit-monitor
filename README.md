# Power Unit Monitor

A live monitoring dashboard for a fleet of natural-gas generator units, built with C# and ASP.NET Core. It tracks each unit's power output, health, connection and breaker status as data streams in, so problems at remote sites get spotted early.

**Status:** In progress

## Planned features

- KPI overview: total units, total power (MW), contracted vs. uncontracted, connected vs. disconnected
- Unit cards with connection, contract and breaker (CB) status, power output and load %
- Search and filters by name, customer, site and status
- Unit details with every data point, a 1-minute history table and trend charts
- Admin page to add, edit, hide and remove units
- Live 1-minute readings from a unit simulator, with auto-refresh
- REST API with Swagger docs
- Automated tests and CI/CD with GitHub Actions
- Light and dark themes; works on phone, tablet and desktop
- Live demo on Azure

## Tech stack

C# · .NET · ASP.NET Core MVC · Web API · Entity Framework Core · SQL Server · JavaScript · Highcharts · xUnit · GitHub Actions · Azure
