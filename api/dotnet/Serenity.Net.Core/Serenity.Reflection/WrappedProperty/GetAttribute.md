# WrappedProperty.GetAttribute&lt;TAttr&gt; method

Gets the attribute.

```csharp
public TAttr? GetAttribute<TAttr>(AttributeOrigin origin = AttributeOrigin.All)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | The type of the attribute. |
| origin | The attribute origin to search. |

## Return Value

The attribute of the specified type, or `null` if none is found.

## See Also

* enum [AttributeOrigin](../../Serenity/AttributeOrigin.md)
* class [WrappedProperty](../WrappedProperty.md)