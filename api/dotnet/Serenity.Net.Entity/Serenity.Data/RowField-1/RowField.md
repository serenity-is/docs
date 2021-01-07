# RowField&lt;TForeign&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public RowField(ICollection<Field> collection, string name, LocalText caption = null, int size = 0, 
    FieldFlags flags = FieldFlags.None | FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, TForeign> getValue = null, Action<IRow, TForeign> setValue = null)
```

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TForeign](../Serenity.Net.Entity/../RowField-1.TForeign.md)
* class [RowField&lt;TForeign&gt;](../RowField-1.md)