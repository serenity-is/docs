# DefaultSqlErrorExtractor.FirebirdTableRegex method

```csharp
protected static Regex FirebirdTableRegex()
```

## Remarks

Pattern:

```csharp
on table "(?<table>[^"]+)"
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Oo].
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