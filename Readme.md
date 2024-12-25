```
dotnet tool install --global dotnet-ef
```
```
dotnet ef
```
```
dotnet ef migrations add Initial --project .\crud.DataAccess
```
```
dotnet ef database update --project .\crud.DataAccess
```

SQLServer
```
docker pull mcr.microsoft.com/mssql/server:2022-latest
```
```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Password123@" -p 1433:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/mssql/server:2022-latest
```