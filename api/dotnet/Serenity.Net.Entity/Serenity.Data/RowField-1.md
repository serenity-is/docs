# RowField&lt;TForeign&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a Row value

```csharp
public class RowField<TForeign> : CustomClassField<TForeign>
    where TForeign : class, IRow
```

| parameter | description |
| --- | --- |
| TForeign | The type of the foreign. |

## Public Members

| name | description |
| --- | --- |
| [RowField](RowField-1/RowField.md)(…) | Initializes a new instance of the [`RowField`](RowField-1.md) class. |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](RowField-1/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](RowField-1/CompareValues.md)(…) | Compares the values. |

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* class [TForeign](../Serenity.Net.Entity/RowField-1.TForeign.md)
* interface [IRow](IRow.md)
* **Source:** *[RowField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/RowField.cs)*