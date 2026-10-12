# DefaultSqlErrorExtractor.SqliteColumnsRegex method

```csharp
protected static Regex SqliteColumnsRegex()
```

## Remarks

Pattern:

```csharp
unique constraint failed: (?<cols>[^'\\r\\n]+)
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Uu].
○ Match a character in the set [Nn].
○ Match a character in the set [Ii].
○ Match a character in the set [Qq].
○ Match a character in the set [Uu].
○ Match a character in the set [Ee].
○ Match ' '.
○ Match a character in the set [Cc].
○ Match a character in the set [Oo].
○ Match a character in the set [Nn].
○ Match a character in the set [Ss].
○ Match a character in the set [Tt].
○ Match a character in the set [Rr].
○ Match a character in the set [Aa].
○ Match a character in the set [Ii].
○ Match a character in the set [Nn].
○ Match a character in the set [Tt].
○ Match ' '.
○ Match a character in the set [Ff].
○ Match a character in the set [Aa].
○ Match a character in the set [Ii].
○ Match a character in the set [Ll].
○ Match a character in the set [Ee].
○ Match a character in the set [Dd].
○ Match the string ": ".
○ "cols" capture group.
    ○ Match a character in the set [^\n\r'] atomically at least once.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)