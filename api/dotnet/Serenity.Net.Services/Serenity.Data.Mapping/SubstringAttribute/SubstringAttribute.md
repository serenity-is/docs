# SubstringAttribute constructor

Substring expression attribute, which returns a part of a string like SUBSTRING of SQL Server.

```csharp
public SubstringAttribute(object expression, object start, object length)
```

| parameter | description |
| --- | --- |
| expression | An expression that returns a string. |
| start | An expression that returns the position of the first character, starting from 1. |
| length | An expression that returns the number of characters. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* class [SubstringAttribute](../SubstringAttribute.md)