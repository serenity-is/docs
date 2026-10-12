# DefaultSqlErrorExtractor.OracleConstraintRegex method

```csharp
protected static Regex OracleConstraintRegex()
```

## Remarks

Pattern:

```csharp
constraint \\((?<name>[^)]+)\\) violated
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
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
○ Match the string " (".
○ "name" capture group.
    ○ Match a character other than ')' atomically at least once.
○ Match the string ") ".
○ Match a character in the set [Vv].
○ Match a character in the set [Ii].
○ Match a character in the set [Oo].
○ Match a character in the set [Ll].
○ Match a character in the set [Aa].
○ Match a character in the set [Tt].
○ Match a character in the set [Ee].
○ Match a character in the set [Dd].
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)