# DefaultSqlErrorExtractor.MySqlKeyRegex method

```csharp
protected static Regex MySqlKeyRegex()
```

## Remarks

Pattern:

```csharp
for key '(?<name>[^']+)'
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
○ Match ' '.
○ Match a character in the set [Kk\u212A].
○ Match a character in the set [Ee].
○ Match a character in the set [Yy].
○ Match the string " '".
○ "name" capture group.
    ○ Match a character other than '\'' atomically at least once.
○ Match '\''.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)