# IPropertyInfo.GetAttributes&lt;TAttr&gt; method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the attributes.

```csharp
public IEnumerable<TAttr> GetAttributes<TAttr>(AttributeOrigin origin = AttributeOrigin.All)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | The type of the attribute. |

## See Also

* class [TAttr](../Serenity.Net.Core/../IPropertyInfo.TAttr.md)
* enum [AttributeOrigin](../../Serenity/AttributeOrigin.md)
* interface [IPropertyInfo](../IPropertyInfo.md)