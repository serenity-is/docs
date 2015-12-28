# How To: Work With Other Database Types

Serenity has a dialect system for working with database types other than Sql Server.

> Dialect system is currently an experimental feature that is constantly improved. Although it will probably work, you might have some minor problems that you should report at Serenity GitHub repository.

If you need to support multiple database types, just by changing connection strings in web.config, you should be careful about not using database specific functions in expressions and avoid using reserved words.


## PostgreSQL

### Registering Npgsql Provider

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

### Setting Connection Strings

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

### Notes About Identifier Case Sensitivy

PostgreSQL is case sensitive for identifiers. 

FluentMigrator automatically quotes all identifiers, so tables and column names in database will be quoted and case sensitive. This might cause problems when tables/columns are tried to be selected without quoted identifiers. 

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

Use brackets `[]` for identifiers in expressions if you want to support multiple database types. Serenity will automatically convert brackets to database specific quote type before running queries. 

You might also prefer to use double quotes in expressions, but it might not be compatible with other databases like MySQL.

### Setting Default Dialect

This step is optional. 

Serenity automatically determines which dialect to use, by looking at *providerName* of connection strings. 

It can even work with multiple database types at the same time. 

For example, Northwind might stay in Sql Server, while Default database uses PostgreSQL.

But, if you are going to use only one database type per site, you can register which you are going to use by default in SiteInitialization:

```cs
public static void ApplicationStart()
{
    try
    {
        SqlSettings.DefaultDialect = PostgresDialect.Instance;
        SqlSettings.AutoQuotedIdentifiers = true;
        Serenity.Web.CommonInitialization.Run();
```

Default dialect is used when the dialect for a connection / entity etc. couldn't be auto determined. 

> This setting doesn't override automatic detection, it is just used as fallback.

## Launching Application

Now launch your application, it should automatically create databases, if they are not created manually before.

## Configuring Code Generator

Sergen doesn't have reference to PostgreSQL provider, so if you want to use it to generate code, you must also register this provider with it.

Sergen.exe is an exe file, so you can't add a NuGet reference to it. We need to register this provider in application config file.

> It is also possible to register the provider in GAC/machine.config and skip this step completely.

Locate Sergen.exe, which is under a folder like *packages/Serenity.CodeGenerator.1.8.6/tools* and create a file named `Sergen.exe.config` next to it with contents below:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
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
  <appSettings>
    <add key="LoadProviderDLLs" value="Npgsql.dll"/>
  </appSettings>
</configuration>
```

Also copy Npgsql.dll to same folder where Sergen.exe resides. Now Sergen will be able to generate code for your Postgres tables.

> You might want to remove `[public].` prefix for default schema from tablename/column expressions in generated rows if you want to be able to work with multiple databases.

## MySql

> MySql support is available for Serene 1.8.13+

### Registering MySql Provider

MySQL has a .NET provider named MySql.Data. You need to first install it in MyProject.Web:

> Install-Package MySql.Data -Project MyProject.Web

If you didn't install this provider in GAC/machine.config before, or don't want to install it there, you need to register it in web.config file (MySql.Data NuGet package already does this on install):

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="MySql.Data.MySqlClient"/>
      <add name="MySQL Data Provider" 
           invariant="MySql.Data.MySqlClient" 
           description=".Net Framework Data Provider for MySQL"
           type="MySql.Data.MySqlClient.MySqlClientFactory, 
                 MySql.Data, Culture=neutral,
                 PublicKeyToken=c5687fc88969c44d" />
     </DbProviderFactories>
  </system.data>
  // ...
```

### Setting Connection Strings

Next step is to replace connection strings for databases you want to use with MySql:

> Make sure you replace connection string parameters with values for your server

```xml
<connectionStrings>
    <add name="Default" connectionString="
            Server=localhost; Port=3306; Database=Serene_Default_v1; 
            Uid=root; Pwd=yourpass"
        providerName="MySql.Data.MySqlClient" />
        
    <add name="Northwind" connectionString="
            Server=localhost; Port=3306; Database=Serene_Northwind_v1; 
            Uid=root; Pwd=yourpass" 
        providerName="MySql.Data.MySqlClient" />
</connectionStrings>    

```

> Provider name must be `MySql.Data.MySqlClient` for Serenity to auto-detect dialect. Read notes above to override default dialect.

> MySql uses lowercase database (schema) and table names, but doesn't have the case sensitivity problem we talked about Postgres.

### Configuring Code Generator

Sergen doesn't have reference to MySql provider, so if you want to use it to generate code, you must also register this provider with it.

Sergen.exe is an exe file, so you can't add a NuGet reference to it. We need to register this provider in application config file.

> It is also possible to register the provider in GAC/machine.config and skip this step completely.

Locate Sergen.exe, which is under a folder like *packages/Serenity.CodeGenerator.1.8.6/tools* and create a file named `Sergen.exe.config` next to it with contents below:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.data>
    <DbProviderFactories>
      <remove invariant="MySql.Data.MySqlClient"/>
      <add name="MySQL Data Provider" 
           invariant="MySql.Data.MySqlClient" 
           description=".Net Framework Data Provider for MySQL"
           type="MySql.Data.MySqlClient.MySqlClientFactory, 
                 MySql.Data, Culture=neutral,
                 PublicKeyToken=c5687fc88969c44d" />
     </DbProviderFactories>
  </system.data>
  <appSettings>
    <add key="LoadProviderDLLs" value="MySql.Data.dll"/>
  </appSettings>
</configuration>
```

Also copy MySql.Data.dll to same folder where Sergen.exe resides. Now Sergen will be able to generate code for your MySql tables.
