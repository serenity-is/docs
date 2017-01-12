


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

