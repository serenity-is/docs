# DefaultSqlErrorExtractor.SqlServerKeyValueRegex method

```csharp
protected static Regex SqlServerKeyValueRegex()
```

## Remarks

Pattern:

```csharp
duplicate key value is \\((?<value>[^)]+)\\)
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match a character in the set [Dd].
○ Match a character in the set [Uu].
○ Match a character in the set [Pp].
○ Match a character in the set [Ll].
○ Match a character in the set [Ii].
○ Match a character in the set [Cc].
○ Match a character in the set [Aa].
○ Match a character in the set [Tt].
○ Match a character in the set [Ee].
○ Match ' '.
○ Match a character in the set [Kk\u212A].
○ Match a character in the set [Ee].
○ Match a character in the set [Yy].
○ Match ' '.
○ Match a character in the set [Vv].
○ Match a character in the set [Aa].
○ Match a character in the set [Ll].
○ Match a character in the set [Uu].
○ Match a character in the set [Ee].
○ Match ' '.
○ Match a character in the set [Ii].
○ Match a character in the set [Ss].
○ Match the string " (".
○ "value" capture group.
    ○ Match a character other than ')' atomically at least once.
○ Match ')'.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)