# How To: Set Database Dialect for Connections

Sometimes, automatic dialect detection using providerName may not work you, or you might want to use SqlServer2000 or SqlServer2005 dialect for some connections.

It is possible to set a default global dialect, but this doesn't override automatic detection:

```
SqlSettings.DefaultDialect = SqlServer2005Dialect.Instance;
```

As provider name for "Northwind" and "Default" connections is "System.Data.SqlClient", Serenity will automatically set their dialects to SqlServer2012, even if you override global dialect.

But it is possible to change dialect on connection key basis:

```cs
    public static partial class SiteInitialization
    {
        public static void ApplicationStart()
        {
            try
            {
                SqlConnections.GetConnectionString("Default").Dialect =
                    SqlServer2005Dialect.Instance;
                
                SqlConnections.GetConnectionString("Northwind").Dialect =
                    SqlServer2005Dialect.Instance;
```

Serenity 1.8.8+ also supports setting this through an application configuration entry:

```xml
<configuration>
  <appSettings>
    <add key="ConnectionSettings" value="{ 
        Default: { 
            Dialect: 'SqlServer2005' 
        }, 
        Northwind: { 
            Dialect: 'Postgres' 
        }
    "/>
```

