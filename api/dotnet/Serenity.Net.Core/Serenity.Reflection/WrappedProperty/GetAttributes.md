# WrappedProperty.GetAttributes&lt;TAttr&gt; method

Gets the attributes.

```csharp
public IEnumerable<TAttr> GetAttributes<TAttr>(AttributeOrigin origin = AttributeOrigin.All)
    where TAttr : Attribute
```

| parameter | description |
| --- | --- |
| TAttr | The type of the attribute. |
| origin | The attribute origin to search. |

## Return Value

The attributes of the specified type.

## See Also

* enum [AttributeOrigin](../../Serenity/AttributeOrigin.md)
* class [WrappedProperty](../WrappedProperty.md)