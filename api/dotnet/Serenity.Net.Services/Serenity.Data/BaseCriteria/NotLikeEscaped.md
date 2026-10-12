# BaseCriteria.NotLikeEscaped method

Creates a new binary Not Like criteria containing this criteria as the left operand, with an ESCAPE clause. The mask must already be escaped for the given escape character (see [`EscapeLikeWildcards`](../Criteria/EscapeLikeWildcards.md)); it is used as is. For literal values prefer [`NotContains`](./NotContains.md); for raw patterns without ESCAPE see [`NotLike`](./NotLike.md).

```csharp
public BaseCriteria NotLikeEscaped(string mask, bool upper = false, char escape = '!')
```

| parameter | description |
| --- | --- |
| mask | The LIKE mask, already escaped for the given escape character. |
| upper | `true` to use the UPPER function on both sides. |
| escape | The LIKE escape character, appended as ESCAPE 'x'. Default is '!'. |

## Return Value

A new binary Not Like criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)