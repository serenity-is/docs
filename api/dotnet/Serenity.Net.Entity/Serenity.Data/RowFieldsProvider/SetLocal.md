# RowFieldsProvider.SetLocal method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Sets local row fields provider for current thread and async context. Useful for background tasks, async methods, and testing to set provider locally and for auto spawned threads.

```csharp
public static IRowFieldsProvider SetLocal(IRowFieldsProvider provider)
```

| parameter | description |
| --- | --- |
| provider | Row fields provider. Can be null. |

## Return Value

Old local provider if any.

## See Also

* interface [IRowFieldsProvider](../IRowFieldsProvider.md)
* class [RowFieldsProvider](../RowFieldsProvider.md)