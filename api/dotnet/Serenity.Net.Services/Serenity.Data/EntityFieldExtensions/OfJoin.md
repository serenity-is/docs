# EntityFieldExtensions.OfJoin&lt;TField&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns a new field an expression with specified join alias. Avoid using.

```csharp
public static TField OfJoin<TField>(this TField field, Join join, string origin, 
    FieldFlags extraFlags = FieldFlags.None)
    where TField : Field
```

| parameter | description |
| --- | --- |
| TField | The type of the field. |
| field | The field. |
| join | The join. |
| origin | The origin. |
| extraFlags | The extra flags. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | join |

## See Also

* class [TField](../Serenity.Net.Services/../EntityFieldExtensions.TField.md)
* class [Join](../Join.md)
* enum [FieldFlags](../FieldFlags.md)
* class [Field](../Field.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)