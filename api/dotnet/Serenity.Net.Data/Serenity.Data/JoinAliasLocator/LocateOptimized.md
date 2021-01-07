# JoinAliasLocator.LocateOptimized method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Locates the aliases in a SQL expression, returning first alias in an out parameter.

```csharp
public static HashSet<string> LocateOptimized(string expression, out string singleAlias)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| singleAlias | The single alias. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null |

## See Also

* class [JoinAliasLocator](../JoinAliasLocator.md)