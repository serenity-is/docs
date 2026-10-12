# Field.NotLikeEscaped method

Creates a new "the Field NOT LIKE mask ESCAPE 'x'" criteria. The mask must already be escaped (see [`EscapeLikeWildcards`](../Criteria/EscapeLikeWildcards.md)).

```csharp
public BaseCriteria NotLikeEscaped(string mask, bool upper = false, char escape = '!')
```

| parameter | description |
| --- | --- |
| mask | The LIKE mask, already escaped for the given escape character. |
| upper | True to use the UPPER function on both sides. |
| escape | The LIKE escape character. Default is '!'. |

## Return Value

The NOT LIKE criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [Field](../Field.md)