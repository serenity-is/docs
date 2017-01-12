




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

