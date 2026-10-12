# DefaultSqlErrorExtractor.SqlServerObjectRegex method

```csharp
protected static Regex SqlServerObjectRegex()
```

## Remarks

Pattern:

```csharp
in object '(?<table>[^']+)'
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Ii].
○ Match a character in the set [Nn].
○ Match ' '.
○ Match a character in the set [Oo].
○ Match a character in the set [Bb].
○ Match a character in the set [Jj].
○ Match a character in the set [Ee].
○ Match a character in the set [Cc].
○ Match a character in the set [Tt].
○ Match the string " '".
○ "table" capture group.
    ○ Match a character other than '\'' atomically at least once.
○ Match '\''.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)