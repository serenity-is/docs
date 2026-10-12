# DefaultSqlErrorExtractor.MySqlReferencedTableRegex method

```csharp
protected static Regex MySqlReferencedTableRegex()
```

## Remarks

Pattern:

```csharp
references `(?<table>[^`]+)`
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Rr].
○ Match a character in the set [Ee].
○ Match a character in the set [Ff].
○ Match a character in the set [Ee].
○ Match a character in the set [Rr].
○ Match a character in the set [Ee].
○ Match a character in the set [Nn].
○ Match a character in the set [Cc].
○ Match a character in the set [Ee].
○ Match a character in the set [Ss].
○ Match the string " `".
○ "table" capture group.
    ○ Match a character other than '`' atomically at least once.
○ Match '`'.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)