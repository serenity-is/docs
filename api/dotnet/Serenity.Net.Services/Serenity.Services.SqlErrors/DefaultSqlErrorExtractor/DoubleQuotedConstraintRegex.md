# DefaultSqlErrorExtractor.DoubleQuotedConstraintRegex method

```csharp
protected static Regex DoubleQuotedConstraintRegex()
```

## Remarks

Pattern:

```csharp
constraint "(?<name>[^"]+)"
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
○ Match the string " \"".
○ "name" capture group.
    ○ Match a character other than '"' atomically at least once.
○ Match '"'.
```

## See Also

* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)