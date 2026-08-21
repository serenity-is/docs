# IPropertyInfo.GetAttribute&lt;TAttr&gt; method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the attribute of the specified type.

```csharp
public TAttr GetAttribute<TAttr>(AttributeOrigin origin = AttributeOrigin.All)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | The type of the attribute. |
| origin | The attribute origin to search. |

## Return Value

The attribute of the specified type, or `null` if none is found.

## See Also

* class [TAttr](../Serenity.Net.Core/../IPropertyInfo.TAttr.md)
* enum [AttributeOrigin](../../Serenity/AttributeOrigin.md)
* interface [IPropertyInfo](../IPropertyInfo.md)