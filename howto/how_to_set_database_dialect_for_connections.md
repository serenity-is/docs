# 如何设置连接的数据库方言（Database Dialect）？

有时，使用 providerName 的自动方言检测可能不会正常工作，或对于某些连接，你想要使用 SqlServer2000 或 SqlServer2005 方言。

可以设置默认的全局方言，但这不会覆盖自动检测：

```
SqlSettings.DefaultDialect = SqlServer2005Dialect.Instance;
```

由于 "Northwind" 和 "Default" 连接的提供者名称是 "System.Data.SqlClient"，即使你重写了全局方言，Serenity 也将自动把它们的方言设置为 SqlServer2012。

但是也可能在基本的连接键（connection key）中修改方言：

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

Serenity 1.8.8+ 也支持通过应用程序配置条目设置：

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


### 在行（Rows）中提示关于 CONCAT 及其他类似信息的警告

Serene 已经支持多种数据库引擎，包括 MySQL、Postgress 等。这些数据库没有像 MsSqlServer 的字符串加号（+）运算符。因此，在 Northwind 中，用 CONCAT 函数来替代 + 运算符：

```cs
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

CONCAT 在 Sql Server 2012 之后的版本是可用的。所以如果你要使用旧版本的 SQL server，例如 SQL server 2005 或 SQL server 2008 ，这些表达式将被替换成：

```cs
[Expression("T0.[FirstName] + ' ' + T0.[LastName]")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```




