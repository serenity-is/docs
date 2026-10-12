# BaseCriteria.StartsWith method

Creates a new binary Starts With (LIKE '...%') criteria containing this criteria as the left operand. The text is treated as a literal value: LIKE special characters (%, _, [) in it are escaped and an ESCAPE '!' clause is appended. For intentional wildcards use [`Like`](./Like.md) instead.

```csharp
public BaseCriteria StartsWith(string text, bool upper = false)
```

| parameter | description |
| --- | --- |
| text | The literal text to search for. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Starts With criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | text is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)