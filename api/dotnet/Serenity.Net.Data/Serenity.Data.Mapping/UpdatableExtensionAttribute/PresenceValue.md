# UpdatableExtensionAttribute.PresenceValue property
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

This extension should only be inserted if PresenceField value is equal to this one. For example, you might have a PersonType column in PersonRow and student record should only be created (if not already) if PersonType = "Student".

```csharp
public object PresenceValue { get; set; }
```

## See Also

* class [UpdatableExtensionAttribute](../UpdatableExtensionAttribute.md)