# DefaultSqlErrorExtractor.MySqlColumnsRegex method

```csharp
protected static Regex MySqlColumnsRegex()
```

## Remarks

Pattern:

```csharp
foreign key \\((?<cols>[^)]+)\\)
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Ff].
○ Match a character in the set [Oo].
○ Match a character in the set [Rr].
○ Match a character in the set [Ee].
○ Match a character in the set [Ii].
○ Match a character in the set [Gg].
○ Match a character in the set [Nn].
○ Match ' '.
○ Match a character in the set [Kk\u212A].
○ Match a character in the set [Ee].
○ Match a character in the set [Yy].
○ Match the string " (".
○ "cols" capture group.
    ○ Match a character other than ')' atomically at least once.
○ Match ')'.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)