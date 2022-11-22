# DefaultPropertyItemProvider.GetPropertyItemsFor method
**namespace:** *[Serenity.PropertyGrid](../../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

```csharp
public IEnumerable<PropertyItem> GetPropertyItemsFor(Type type, Func<PropertyInfo, bool> predicate)
```

| parameter | description |
| --- | --- |
| type | The type. |
| predicate |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | type is null |
| InvalidProgramException | CheckNames is true and there is name mismatch |

## See Also

* class [PropertyItem](../Serenity.Net.Core/../../Serenity.ComponentModel/PropertyItem.md)
* class [DefaultPropertyItemProvider](../DefaultPropertyItemProvider.md)