### Dialect Based Expressions

Sometimes it might not be possible to use a common expression. For example, Sqlite has no CONCAT operator.

Serenity 2.8.1+ supports dialect based expressions, e.g.

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

### How Dialect for Row is Determined

To determine dialect type for a row, the *ConnectionKey* attribute on row is used (if any), otherwise the default dialect (*SqlSettings.DefaultDialect*) is used.

Expression for a field is determined (fixed) at *application start*, so it is not possible to switch expressions by switching connections or dialects. 

It is also possible to specify multiple dialects:

```cs
[DisplayName("FullName"), QuickSearch]
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
[Expression("T0.[FirstName] + ' ' + T0.[LastName]", 
     Dialect = "SqlServer2000,SqlServer2005")]
[Expression("(T0.FirstName || ' ' || T0.LastName)", 
     Dialect = "Sqlite,MySql,Postgres")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

### Dialect Matching

ISqlDialect interface has a *ServerType* property. It is *Postgres* for PostgresDialect, *SqlServer* for *SqlServer2012Dialect*, *SqlServer2008Dialect* and *SqlServer2005Dialect*.

For an expression dialect to match a connection dialect, it should start with the *ServerType* and/or the class name of the connection dialect (e.g. SqlServer2012Dialect).

If multiple dialect types match a targeted expression, the one with the longest name matches.

Let's say we wrote these two expressions:

```cs
[Expression("CONCAT(T0.[FirstName], T0.[LastName])", Dialect = "SqlServer")]
[Expression("T0.[FirstName] + T0.[LastName]", Dialect = "SqlServer200")]
```

If connection dialect is SqlServer2008, both expressions would match, but as *SqlServer200* is a longer match than *SqlServer*, second expression will be used.

If connection dialect is SqlServer2012, only the first expression would match.

