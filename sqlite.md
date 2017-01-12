## Sqlite

### Registering Sqlite Provider

MySQL has a .NET provider named System.Data.Sqlite. You need to first install it in MyProject.Web:

> Install-Package System.Data.SQLite.Core -Project MyProject.Web

If you didn't install this provider in GAC/machine.config before, or don't want to install it there, you need to register it in web.config file:

```xml
<configuration>
  // ...
  <system.data>
    <DbProviderFactories>
        <remove invariant="System.Data.SQLite"/>
        <add name="SQLite Data Provider"
          invariant="System.Data.SQLite"
          description=".Net Framework Data Provider for SQLite"
          type="System.Data.SQLite.SQLiteFactory, System.Data.SQLite"/>
    </DbProviderFactories>
  </system.data>
  // ...
```

### Setting Connection Strings

Next step is to replace connection strings for databases you want to use with MySql:

```xml
  <connectionStrings>
    <add name="Default" connectionString=
         "Data Source=|DataDirectory|Serene_Default_v1.sqlite;" 
      providerName="System.Data.Sqlite" />
    <add name="Northwind" connectionString=
        "Data Source=|DataDirectory|Serene_Northwind_v1.sqlite;" 
      providerName="System.Data.Sqlite" />
  </connectionStrings> 

```

> Provider name must be `System.Data.Sqlite` for Serenity to auto-detect dialect. Read notes above to override default dialect.


> I'm not sure why, but while FluentMigrator creates Northwind database for Sqlite first time, it takes some time.

### Configuring Code Generator

Sergen doesn't have reference to Sqlite provider, so if you want to use it to generate code, you must also register this provider with it.

Sergen.exe is an exe file, so you can't add a NuGet reference to it. We need to register this provider in application config file.

> It is also possible to register the provider in GAC/machine.config and skip this step completely.

Locate Sergen.exe, which is under a folder like *packages/Serenity.CodeGenerator.1.8.6/tools* and create a file named `Sergen.exe.config` next to it with contents below:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <system.data>
    <DbProviderFactories>
        <remove invariant="System.Data.SQLite"/>
        <add name="SQLite Data Provider"
             invariant="System.Data.SQLite"
             description=".Net Framework Data Provider for SQLite"
             type="System.Data.SQLite.SQLiteFactory, System.Data.SQLite"/>
    </DbProviderFactories>
  </system.data>
  <appSettings>
    <add key="LoadProviderDLLs" value="MySql.Data.dll"/>
  </appSettings>
</configuration>
```

Also copy System.Data.Sqlite.dll and its x86 and x64 folders under bin directory to same folder where Sergen.exe resides. Now Sergen will be able to generate code for your MySql tables.