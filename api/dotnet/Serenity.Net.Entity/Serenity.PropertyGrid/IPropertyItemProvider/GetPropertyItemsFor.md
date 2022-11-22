# IPropertyItemProvider.GetPropertyItemsFor method
**namespace:** *[Serenity.PropertyGrid](../../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the property items for specified type

```csharp
public IEnumerable<PropertyItem> GetPropertyItemsFor(Type type, 
    Func<PropertyInfo, bool> predicate = null)
```

| parameter | description |
| --- | --- |
| type | The type. |
| predicate | Optional predicate that should return true for items to be processed |

## See Also

* class [PropertyItem](../Serenity.Net.Core/../../Serenity.ComponentModel/PropertyItem.md)
* interface [IPropertyItemProvider](../IPropertyItemProvider.md)