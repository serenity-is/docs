# SqlSettings.SetLocalDialect method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Sets local dialect for current thread and async context. Useful for background tasks, async methods, and testing to set dialect locally and for auto spawned threads.

```csharp
public static ISqlDialect SetLocalDialect(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | Dialect. Can be null. |

## Return Value

Old local dialect if any.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSettings](../SqlSettings.md)