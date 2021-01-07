# TimeSpanField.Factory method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static TimeSpanField Factory(ICollection<Field> collection, string name, LocalText caption, 
    int size, FieldFlags flags, Func<IRow, TimeSpan?> getValue, Action<IRow, TimeSpan?> setValue)
```

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TimeSpanField](../TimeSpanField.md)