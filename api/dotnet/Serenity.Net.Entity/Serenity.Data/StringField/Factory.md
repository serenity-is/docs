# StringField.Factory method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public static StringField Factory(ICollection<Field> collection, string name, LocalText caption, 
    int size, FieldFlags flags, Func<IRow, string> getValue, Action<IRow, string> setValue)
```

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [StringField](../StringField.md)