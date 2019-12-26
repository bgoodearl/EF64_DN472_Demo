# Entity Framework Resources

[Announcing Entity Framework Core 3.1 and Entity Framework 6.4](https://devblogs.microsoft.com/dotnet/announcing-entity-framework-core-3-1-and-entity-framework-6-4/)

[.NET Blog - EF](https://devblogs.microsoft.com/dotnet/tag/entity-framework/)

[EntityFramework6 - wiki](https://github.com/aspnet/EntityFramework6/wiki)

[Entity Framework Core tools reference - Package Manager Console in Visual Studio](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/powershell)
(c. Sep 2018)

[Entity Framework overview](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ef/overview)
(c. Sep 2018)

[Entity Framework Documentation - EF 6](https://docs.microsoft.com/en-us/ef/#pivot=ef6x&panel=ef6x1)

leads to
[Get started with Entity Framework 6](https://docs.microsoft.com/en-us/ef/ef6/get-started)
(c. Oct 2016)

[Command Line tool - ef6.exe instead of migrate.exe](https://github.com/NuGet/NuGetGallery/pull/7711)

## MSSQL LocalDB

[How to connect and use Microsoft SQL Server Express LocalDB](https://www.sqlshack.com/how-to-connect-and-use-microsoft-sql-server-express-localdb/)

[LocalDB: Where is My Database?](https://blogs.msdn.microsoft.com/sqlexpress/2011/10/28/localdb-where-is-my-database/)

To get LocalDB instance name:

```cmd
sqllocaldb info
```

In case of local test, got:
```txt
MSSQLLocalDB
ProjectsV13
```

And to get more information, add the instance Name:
```cmd
sqllocaldb info MSSQLLocalDB
```

In case of local test, got:
```txt
Name:               MSSQLLocalDB
Version:            13.2.5026.0
Shared name:
Owner:              COMPUTERNAME\username
Auto-create:        Yes
State:              Stopped
Last start time:    12/26/2019 11:52:47 AM
Instance pipe name:
```

To start the local DB:
```cmd
SqlLocalDB start MSSQLLocalDB
```
gets:
```txt
LocalDB instance "MSSQLLocalDB" started.
```

And now, 
```cmd
sqllocaldb info MSSQLLocalDB
```
gets
```txt
Name:               MSSQLLocalDB
Version:            13.2.5026.0
Shared name:
Owner:              COMPUTERNAME\username
Auto-create:        Yes
State:              Running
Last start time:    12/26/2019 12:14:40 PM
Instance pipe name: np:\\.\pipe\LOCALDB#899E2B95\tsql\query
```
Note: You can connect to the local database instance using either the pipe path:
```txt
\\.\pipe\LOCALDB#899E2B95\tsql\query
```
or the more generic path using the instance name
```txt
(LocalDB)\MSSQLLocalDB
```

To create the local database:
```sql
create database BGoodMusicLocal on (name='BGoodMusicLocal', filename='C:\Users\_dev\_LocalDB\BGoodMusic.SQL\_LocalDB\BGoodMusicLocal.mdf')
```
(and **be sure** to change the path for your local environment!)
