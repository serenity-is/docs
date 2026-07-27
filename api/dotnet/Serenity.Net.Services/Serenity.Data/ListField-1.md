# ListField&lt;TItem&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a list value

```csharp
public class ListField<TItem> : CustomClassField<List<TItem>>
```

| parameter | description |
| --- | --- |
| TItem | The type of the item. |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Public Members

| name | description |
| --- | --- |
| [ListField](ListField-1/ListField.md)(…) | Field with a list value |

## Protected Members

| name | description |
| --- | --- |
| override [Clone](ListField-1/Clone.md)(…) | Clones the specified value. |
| override [CompareValues](ListField-1/CompareValues.md)(…) | Compares the values. |

## Remarks

Initializes a new instance of the [`ListField`](ListField-1.md) class.

## See Also

* class [CustomClassField&lt;TValue&gt;](CustomClassField-1.md)
* class [TItem](../Serenity.Net.Services/ListField-1.TItem.md)
* **Source:** *[ListField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/ListField.cs)*