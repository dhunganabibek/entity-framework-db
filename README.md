# Entity Framework

# Running SQL Server using Docker

```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=PASSWORD@1" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```
