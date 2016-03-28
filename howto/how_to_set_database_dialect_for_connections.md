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


### Warning About CONCAT and Other Similar Expressions In Rows

Serene has to support a variety of database engines, including MySQL, Postgress etc. These databases don't have a string plus (+) operator like MsSqlServer. Thus, in Northwind, CONCAT function is used in place of '+' operator:

```cs
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

CONCAT is available after Sql Server 2012. So if you are going to use an older version of SQL server, e.g. 2005 or 2008, replace these expressions with such:

```cs
[Expression("T0.[FirstName] + ' ' + T0.[LastName]")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```




