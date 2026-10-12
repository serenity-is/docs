# DefaultSqlErrorExtractor.SqlServerForeignKeyRegex method

```csharp
protected static Regex SqlServerForeignKeyRegex()
```

## Remarks

Pattern:

```csharp
, table "(?<table>[^"]+)", column '(?<column>[^']+)'
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match the string ", ".
○ Match a character in the set [Tt].
○ Match a character in the set [Aa].
○ Match a character in the set [Bb].
○ Match a character in the set [Ll].
○ Match a character in the set [Ee].
○ Match the string " \"".
○ "table" capture group.
    ○ Match a character other than '"' atomically at least once.
○ Match the string "\", ".
○ Match a character in the set [Cc].
○ Match a character in the set [Oo].
○ Match a character in the set [Ll].
○ Match a character in the set [Uu].
○ Match a character in the set [Mm].
○ Match a character in the set [Nn].
○ Match the string " '".
○ "column" capture group.
    ○ Match a character other than '\'' atomically at least once.
○ Match '\''.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)