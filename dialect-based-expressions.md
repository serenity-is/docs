### Dialect Based Expressions

Sometimes it might not be possible to use a common expression. For example, Sqlite has no CONCAT operator.

Serenity 2.8.1+ supports dialect targeted expressions, e.g.

```cs
[DisplayName("FullName"), QuickSearch]
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
[Expression("(T0.FirstName || ' ' || T0.LastName)", Dialect = "Sqlite")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

Here, as the first Expression has no dialect, it will be used for any database type, unless the connection corresponding to this row has dialect of *Sqlite*, e.g. it is a *System.Data.Sqlite* connection.

To determine dialect type for a row, the connection key attribute on row is used (if any), otherwise the default dialect is checked.

Expression for a field is determined (fixed) at *application start*, so it is not possible to switch expressions by switching connections or dialects. 

It is also possible to specify multiple dialects:

```cs
[DisplayName("FullName"), QuickSearch]
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
[Expression("T0.[FirstName] + ' ' + T0.[LastName]", Dialect = "SqlServer2000,SqlServer2005")]
[Expression("(T0.FirstName || ' ' || T0.LastName)", Dialect = "Sqlite,MySql,Postgres")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

