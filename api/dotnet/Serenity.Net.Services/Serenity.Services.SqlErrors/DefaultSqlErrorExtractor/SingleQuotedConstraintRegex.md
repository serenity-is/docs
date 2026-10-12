# DefaultSqlErrorExtractor.SingleQuotedConstraintRegex method

```csharp
protected static Regex SingleQuotedConstraintRegex()
```

## Remarks

Pattern:

```csharp
(?:constraint|index) '(?<name>[^']+)'
```

Options:

```csharp
RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
```

Explanation:

```csharp
○ Match with 2 alternative expressions.
    ○ Match a sequence of expressions.
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
    ○ Match a sequence of expressions.
        ○ Match a character in the set [Ii].
        ○ Match a character in the set [Nn].
        ○ Match a character in the set [Dd].
        ○ Match a character in the set [Ee].
        ○ Match a character in the set [Xx].
○ Match the string " '".
○ "name" capture group.
    ○ Match a character other than '\'' atomically at least once.
○ Match '\''.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)