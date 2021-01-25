# EntityFieldExtensions.GetAttributes&lt;TAttribute&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the attributes.

```csharp
public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this Field field)
    where TAttribute : Attribute
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attribute. |
| field | The field. |

## Return Value

Attributes with specified type.

## See Also

* class [TAttribute](../Serenity.Net.Entity/../EntityFieldExtensions.TAttribute.md)
* class [Field](../Field.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)