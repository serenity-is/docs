# ListField&lt;TItem&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public ListField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.None | FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, List<TItem>> getValue = null, Action<IRow, List<TItem>> setValue = null)
```

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TItem](../Serenity.Net.Entity/../ListField-1.TItem.md)
* class [ListField&lt;TItem&gt;](../ListField-1.md)