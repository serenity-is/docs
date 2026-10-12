# BaseCriteria.EndsWith method

Creates a new binary Ends With (LIKE '%...') criteria containing this criteria as the left operand. The text is treated as a literal value: LIKE special characters (%, _, [) in it are escaped and an ESCAPE '!' clause is appended. For intentional wildcards use [`Like`](./Like.md) instead.

```csharp
public BaseCriteria EndsWith(string text, bool upper = false)
```

| parameter | description |
| --- | --- |
| text | The literal text to search for. |
| upper | `true` to use the UPPER function on both sides. |

## Return Value

A new binary Ends With criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | text is null |

## See Also

* class [BaseCriteria](../BaseCriteria.md)