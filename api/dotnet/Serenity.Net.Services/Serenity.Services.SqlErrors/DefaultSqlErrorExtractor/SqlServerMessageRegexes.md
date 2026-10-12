# DefaultSqlErrorExtractor.SqlServerMessageRegexes field

Regexes generated from SQL Server sys.messages for the handled constraint violation message ids (515, 547, 2601, 2627), one per language. Named groups: `table`, `column`, `constraint`, `value`.

```csharp
protected static readonly Regex[] SqlServerMessageRegexes;
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)