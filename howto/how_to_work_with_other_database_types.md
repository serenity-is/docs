# 

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
>
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

This setting automatically quotes column names in entities, but not manually written expressions \(with Expression attribute for example\).

Use brackets `[]` for identifiers in expressions if you want to support multiple database types. Serenity will automatically convert brackets to database specific quote type before running queries.

You might also prefer to use double quotes in expressions, but it might not be compatible with other databases like MySQL.

### Setting Default Dialect

This step is optional.

Serenity automatically determines which dialect to use, by looking at _providerName_ of connection strings.

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

Locate Sergen.exe, which is under a folder like _packages/Serenity.CodeGenerator.1.8.6/tools_ and create a file named `Sergen.exe.config` next to it with contents below:

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

If you didn't install this provider in GAC/machine.config before, or don't want to install it there, you need to register it in web.config file \(MySql.Data NuGet package already does this on install\):

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
>
> MySql uses lowercase database \(schema\) and table names, but doesn't have the case sensitivity problem we talked about Postgres.

### Configuring Code Generator

Sergen doesn't have reference to MySql provider, so if you want to use it to generate code, you must also register this provider with it.

Sergen.exe is an exe file, so you can't add a NuGet reference to it. We need to register this provider in application config file.

> It is also possible to register the provider in GAC/machine.config and skip this step completely.

Locate Sergen.exe, which is under a folder like _packages/Serenity.CodeGenerator.1.8.6/tools_ and create a file named `Sergen.exe.config` next to it with contents below:

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

## Oracle

> Oracle support is available for Serene 2.2.2+

### Registering Oracle Provider

Oracle has a managed .NET provider named Oracle.ManagedDataAccess. You need to first install it in MyProject.Web:

> Install-Package Oracle.ManagedDataAccess -Project MyProject.Web

If you didn't install this provider in GAC/machine.config before, or don't want to install it there, you need to register it in web.config file \(Oracle.ManagedDataAccess NuGet package already does this on install\):

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
      <remove invariant="Oracle.ManagedDataAccess.Client"/>
      <add name="ODP.NET, Managed Driver" 
           invariant="Oracle.ManagedDataAccess.Client" 
           description="Oracle Data Provider for .NET, Managed Driver"
           type="Oracle.ManagedDataAccess.Client.OracleClientFactory, 
                 Oracle.ManagedDataAccess, Version=4.121.2.0, Culture=neutral, 
                 PublicKeyToken=89b483f429c47342"/>
     </DbProviderFactories>
  </system.data>
  // ...
```

### Creating Databases

Serene can't autocreate database \(tablespace\) for Oracle. You might create them yourself, or use a script like below \(i used this for XE\):

```sql
CREATE TABLESPACE Serene_Default_v1_TABS 
    DATAFILE 'Serene_Default_v1_TABS.dat' SIZE 10M AUTOEXTEND ON;
CREATE TEMPORARY TABLESPACE Serene_Default_v1_TEMP 
    TEMPFILE 'Serene_Default_v1_TEMP.dat' SIZE 5M AUTOEXTEND ON;
CREATE USER Serene_Default_v1 
    IDENTIFIED BY somepassword 
    DEFAULT TABLESPACE Serene_Default_v1_TABS 
    TEMPORARY TABLESPACE Serene_Default_v1_TEMP;
GRANT CREATE SESSION TO Serene_Default_v1;
GRANT CREATE TABLE TO Serene_Default_v1;
GRANT CREATE SEQUENCE TO Serene_Default_v1;
GRANT CREATE TRIGGER TO Serene_Default_v1;
GRANT UNLIMITED TABLESPACE TO Serene_Default_v1;

CREATE TABLESPACE Serene_Northwind_v1_TABS 
    DATAFILE 'Serene_Northwind_v1_TABS.dat' SIZE 10M AUTOEXTEND ON;
CREATE TEMPORARY TABLESPACE Serene_Northwind_v1_TEMP 
    TEMPFILE 'Serene_Northwind_v1_TEMP.dat' SIZE 5M AUTOEXTEND ON;
CREATE USER Serene_Northwind_v1 
    IDENTIFIED BY somepassword 
    DEFAULT TABLESPACE Serene_Northwind_v1_TABS 
    TEMPORARY TABLESPACE Serene_Northwind_v1_TEMP;

GRANT CREATE SESSION TO Serene_Northwind_v1;
GRANT CREATE TABLE TO Serene_Northwind_v1;
GRANT CREATE SEQUENCE TO Serene_Northwind_v1;
GRANT CREATE TRIGGER TO Serene_Northwind_v1;
GRANT UNLIMITED TABLESPACE TO Serene_Northwind_v1;
```

### Setting Connection Strings

You might want to configure your data sources for ORACLE. I used Express Edition \(XE\) here:

```xml
<configuration>
  <oracle.manageddataaccess.client>
    <version number="*">
      <dataSources>
        <dataSource alias="XE"
          descriptor="
              (DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)
              (HOST=localhost)(PORT=1521))
              (CONNECT_DATA=(SERVICE_NAME=XE))) "/>
      </dataSources>
    </version>
  </oracle.manageddataaccess.client>
</configuration>
```

Next step is to replace connection strings for databases you want to use with Oracle:

> Make sure you replace connection string parameters with values for your server

```xml
<connectionStrings>
    <add name="Default" connectionString="
        Data Source=XE;User Id=Serene_Default_v1;Password=somepassword;" 
        providerName="Oracle.ManagedDataAccess.Client"/>
    <add name="Northwind" connectionString="
        Data Source=XE;User Id=Serene_Northwind_v1;Password=somepassword;" 
        providerName="Oracle.ManagedDataAccess.Client"/>
</connectionStrings>
```

> Provider name must be `Oracle.ManagedDataAccess.Client` for Serenity to auto-detect dialect. Read notes above to override default dialect.

### Configuring Code Generator

Sergen doesn't have support for Oracle yet, hopefully coming soon...

