# DefaultSqlErrorExtractor.PostgresColumnsRegex method

```csharp
protected static Regex PostgresColumnsRegex()
```

## Remarks

Pattern:

```csharp
key \\((?<cols>[^)]+)\\)=
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Kk\u212A].
○ Match a character in the set [Ee].
○ Match a character in the set [Yy].
○ Match the string " (".
○ "cols" capture group.
    ○ Match a character other than ')' atomically at least once.
○ Match the string ")=".
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)