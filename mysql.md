## MySql

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