# GenericValueField&lt;TValue&gt;.AsObject method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets the value of this field in specified row as object.

```csharp
public override void AsObject(IRow row, object value)
```

| parameter | description |
| --- | --- |
| row | The row. |
| value | The value. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidCastException | Invalid cast exception while trying to set the value of {Name} field on {row.GetType().Name} as object. |

## See Also

* interface [IRow](../IRow.md)
* class [GenericValueField&lt;TValue&gt;](../GenericValueField-1.md)