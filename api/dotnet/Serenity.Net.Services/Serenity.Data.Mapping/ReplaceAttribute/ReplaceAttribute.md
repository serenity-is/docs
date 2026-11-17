# ReplaceAttribute constructor

Replace expression attribute, which replaces all occurrences of a string in another one like REPLACE of SQL Server.

```csharp
public ReplaceAttribute(object expression, object search, object replacement)
```

| parameter | description |
| --- | --- |
| expression | An expression that returns the string to search in. |
| search | An expression that returns the string to search for. |
| replacement | An expression that returns the string to replace it with. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the expressions is null. |

## See Also

* class [ReplaceAttribute](../ReplaceAttribute.md)