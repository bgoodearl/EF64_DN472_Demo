# Migration Notes

## **The FIRST TIME You Build**

**Before** you run migrations, make sure there's an app.config file.  Building the assembly should copy one
from _ConfigSource\BGoodMusic.EFDAL, but you can copy manually, and in any case, make sure the 
connection string is correct.

## Using LocalDB

See notes in `...\_docs\EF_Resources.md` under the section **MSSQL LocalDB**

Be sure to create the database and update your connection string in `App.config` as appropriate

## Initial Schema

Make sure the default project for the solution is set to `BGoodMusic.EFDAL` and that's the `Default project`
in the Package Manager Console.

```powershell
Enable-Migrations
```

## First Migration

```powershell
		Add-Migration Schema1
		Update-Database -Script -SourceMigration:$InitialDatabase -TargetMigration:Schema1
```
