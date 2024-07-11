# Entity Framework

## Running SQL Server using Docker

```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=PASSWORD@1" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```

## Need to install sqlcmd to connect to SQL server

```
brew tap microsoft/mssql-release https://github.com/Microsoft/homebrew-mssql-release
brew update
HOMEBREW_NO_AUTO_UPDATE=1 brew install msodbcsql17
HOMEBREW_NO_AUTO_UPDATE=1 brew install mssql-tools
```

## Add sqlcmd to environment variable

```
export PATH="/usr/local/opt/mssql-tools/bin:$PATH"
```

## Run SQL server from terminal

```
sqlcmd -S localhost,1433 -U SA -P <PASSWORD>
```
