# EntityFieldExtensions.OfJoin&lt;TField&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Returns a new field an expression with specified join alias. Avoid using.

```csharp
public static TField OfJoin<TField>(this TField field, Join join, string origin, 
    FieldFlags extraFlags = FieldFlags.Internal)
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

* class [TField](../Serenity.Net.Entity/../EntityFieldExtensions.TField.md)
* class [Join](../Serenity.Net.Data/../Join.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* class [Field](../Field.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)