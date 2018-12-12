# Set Database Dialect for Connections

Serenity auto detects dialect for a connection by using the providerName in web.config.

Sometimes, automatic dialect detection using providerName may not work you, or you might want to use SqlServer2000 or SqlServer2005 dialect for some connections.

Even though it is possible to set a default global dialect, this doesn't override automatic detection):

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

It is also possible to set this through an application configuration entry (recommended):

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
    }"/>
```




