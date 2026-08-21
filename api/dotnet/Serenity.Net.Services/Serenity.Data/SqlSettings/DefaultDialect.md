# SqlSettings.DefaultDialect property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets or sets the default dialect. Returns the local dialect if any is set through [`SetLocalDialect`](SetLocalDialect.md), otherwise the default dialect. This should only be set on application start. The local dialect should be used for unit tests.

```csharp
public static ISqlDialect DefaultDialect { get; set; }
```

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSettings](../SqlSettings.md)