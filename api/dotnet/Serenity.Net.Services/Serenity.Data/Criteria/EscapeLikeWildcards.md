# Criteria.EscapeLikeWildcards method

Escapes a literal value for use in a LIKE pattern with the given escape character. The escape character itself is escaped first, then %, _ and [. A ] outside a [...] class is literal on all supported dialects, so it is left as is. The result must be used with ESCAPE 'x' declared (see [`LikeEscapeChar`](../BinaryCriteria/LikeEscapeChar.md)), otherwise the escape character matches itself instead of escaping.

```csharp
public static string EscapeLikeWildcards(string value, char escape = '!')
```

| parameter | description |
| --- | --- |
| value | The literal value to escape. |
| escape | The escape character. Must not be %, _ or a quote. Default is '!'. |

## Return Value

The escaped value, with no % affixes added.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | value is null. |
| ArgumentException | The escape character is a LIKE wildcard (%, _) or a quote. |

## See Also

* class [Criteria](../Criteria.md)