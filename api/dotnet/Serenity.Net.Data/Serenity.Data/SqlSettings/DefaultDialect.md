# SqlSettings.DefaultDialect property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

The default dialect, returns the local dialect if any set through SetLocal, the default dialect otherwise. This should be only set on application start. Local dialect should be used for unit tests.

```csharp
public static ISqlDialect DefaultDialect { get; set; }
```

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSettings](../SqlSettings.md)