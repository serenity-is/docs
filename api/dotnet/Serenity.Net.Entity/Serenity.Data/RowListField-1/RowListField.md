# RowListField&lt;TForeign&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public RowListField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.None | FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, List<TForeign>> getValue = null, Action<IRow, List<TForeign>> setValue = null)
```

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TForeign](../Serenity.Net.Entity/../RowListField-1.TForeign.md)
* class [RowListField&lt;TForeign&gt;](../RowListField-1.md)