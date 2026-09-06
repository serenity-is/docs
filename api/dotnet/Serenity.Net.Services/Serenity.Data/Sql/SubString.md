# Sql.SubString method

Creates a SUBSTRING() expression.

```csharp
public static string SubString(string expression, int startIndex, int endIndex)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| startIndex | The start index. |
| endIndex | The end index. |

## Return Value

The SUBSTRING() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null or empty. |

## See Also

* class [Sql](../Sql.md)