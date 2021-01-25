# ListField&lt;TItem&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Field with a list value

```csharp
public class ListField<TItem> : CustomClassField<List<TItem>>
```

| parameter | description |
| --- | --- |
| TItem | The type of the item. |

## Public Members

| name | description |
| --- | --- |
| [ListField](ListField-1/ListField.md)(…) | Initializes a new instance of the [`ListField`](ListField-1.md) class. |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](ListField-1/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](ListField-1/CompareValues.md)(…) | Compares the values. |

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* class [TItem](../Serenity.Net.Entity/ListField-1.TItem.md)
* **Source:** *[ListField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/ListField.cs)*