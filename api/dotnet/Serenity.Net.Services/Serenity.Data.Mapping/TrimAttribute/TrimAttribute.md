# TrimAttribute constructor

Trim expression attribute, which removes the spaces at the start, at the end, or both, of a string, like TRIM, LTRIM and RTRIM of SQL Server.

```csharp
public TrimAttribute(object expression)
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a string. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The expression is null. |

## See Also

* class [TrimAttribute](../TrimAttribute.md)