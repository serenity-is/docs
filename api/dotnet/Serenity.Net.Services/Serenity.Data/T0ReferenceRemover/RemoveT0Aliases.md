# T0ReferenceRemover.RemoveT0Aliases method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Removes the "t0." aliases in SQL expression.

```csharp
public static string RemoveT0Aliases(string expression)
```

| parameter | description |
| --- | --- |
| expression | The expression. |

## Return Value

The expression with T0 references removed.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null. |

## See Also

* class [T0ReferenceRemover](../T0ReferenceRemover.md)