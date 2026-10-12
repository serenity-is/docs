# DefaultSqlErrorExtractor.PostgresReferencedTableRegex method

```csharp
protected static Regex PostgresReferencedTableRegex()
```

## Remarks

Pattern:

```csharp
is not present in table "(?<table>[^"]+)"
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Ii].
○ Match a character in the set [Ss].
○ Match ' '.
○ Match a character in the set [Nn].
○ Match a character in the set [Oo].
○ Match a character in the set [Tt].
○ Match ' '.
○ Match a character in the set [Pp].
○ Match a character in the set [Rr].
○ Match a character in the set [Ee].
○ Match a character in the set [Ss].
○ Match a character in the set [Ee].
○ Match a character in the set [Nn].
○ Match a character in the set [Tt].
○ Match ' '.
○ Match a character in the set [Ii].
○ Match a character in the set [Nn].
○ Match ' '.
○ Match a character in the set [Tt].
○ Match a character in the set [Aa].
○ Match a character in the set [Bb].
○ Match a character in the set [Ll].
○ Match a character in the set [Ee].
○ Match the string " \"".
○ "table" capture group.
    ○ Match a character other than '"' atomically at least once.
○ Match '"'.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)