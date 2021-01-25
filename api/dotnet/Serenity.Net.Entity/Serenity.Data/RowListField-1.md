# RowListField&lt;TForeign&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a RowList value

```csharp
public class RowListField<TForeign> : CustomClassField<List<TForeign>>
    where TForeign : class, IRow
```

| parameter | description |
| --- | --- |
| TForeign | The type of the foreign. |

## Public Members

| name | description |
| --- | --- |
| [RowListField](RowListField-1/RowListField.md)(…) | Initializes a new instance of the [`RowListField`](RowListField-1.md) class. |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](RowListField-1/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](RowListField-1/CompareValues.md)(…) | Compares the values. |

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* class [TForeign](../Serenity.Net.Entity/RowListField-1.TForeign.md)
* interface [IRow](IRow.md)
* **Source:** *[RowListField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/RowListField.cs)*