# How To: Work With Other Database Types

Serenity has a dialect system for working with database types other than Sql Server.

> Dialect system is currently an experimental feature that is constantly improved. Although it will probably work, you might have some minor problems that you should report at Serenity GitHub repository.

If you need to support multiple database types, just by changing connection strings in web.config, you should be careful about not using database specific functions in expressions and avoid using reserved words.

## PostgreSQL

PostgreSQL has a .NET provider named Npgsql. You need to first install it in MyProject.Web:

> Install-Package Npgsql -Project MyProject.Web

If you didn't install this provider in GAC/machine.config before, or don't want to install it there, you need to register it in web.config file:

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql"/>
      <add name="Npgsql Data Provider" 
           invariant="Npgsql" 
           description=".Net Data Provider for PostgreSQL"
           type="Npgsql.NpgsqlFactory, Npgsql, Culture=neutral,
                 PublicKeyToken=5d8b90d52f46fda7" 
           support="FF" />
    </DbProviderFactories>
  </system.data>
  // ...
```

Next step is to replace connection strings for databases you want to use with Postgres:

> Make sure you replace connection string parameters with values for your server

```xml
<connectionStrings>
    <add name="Default" connectionString="
            Server=127.0.0.1;Database=serene_default_v1;
            User Id=postgres;Password=yourpassword;"  
        providerName="Npgsql" />

    <add name="Northwind" connectionString="
            Server=127.0.0.1;Database=serene_northwind_v1;
            User Id=postgres;Password=yourpassword;" 
        providerName="Npgsql" />
</connectionStrings>    

```

> Please use lowercase database names like `serene_default_v1` as Postgres will always convert it to lowercase.

> Provider name must be `Npgsql` for Serenity to auto-detect dialect.

PostgreSQL is case sensitive for identifiers. FluentMigrator automatically quotes all identifiers, so tables and column names in database will be quoted and case sensitive. This might cause problems when tables/columns are tried to select without quoted identifiers. 

One option is to always use lowercase identifiers in migrations, but such naming scheme won't look so nice for other database types, thus we didn't prefer this way.

To prevent such problems with Postgres, Serenity has an automatic quoting feature, to resolve compability with Postgres/FluentMigrator, which should be enabled in application start method of SiteInitialization.cs:

```cs
public static void ApplicationStart()
{
    try
    {
        SqlSettings.AutoQuotedIdentifiers = true;
        Serenity.Web.CommonInitialization.Run();
```

> Make sure it is before CommonInitialization.Run line

This setting automatically quotes column names in entities, but not manually written expressions (with Expression attribute for example).

Use brackets `[]` for identifiers in expressions if you want to support multiple database types. Serenity will automatically convert brackets to database specific quote type before running queries. You can also use double quotes in expressions, but it might not be compatible with other databases like MySQL.

Now launch your application, it should automatically create databases, if they are not created manually before.


