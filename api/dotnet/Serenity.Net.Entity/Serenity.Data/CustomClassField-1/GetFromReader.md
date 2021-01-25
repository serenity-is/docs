# CustomClassField&lt;TValue&gt;.GetFromReader method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets field value from a data reader.

```csharp
protected virtual TValue GetFromReader(IDataReader reader, int index)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| index | The index. |

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException |  |

## See Also

* class [TValue](../Serenity.Net.Entity/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.GetFromReader method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets field value from a data reader.

```csharp
public override void GetFromReader(IDataReader reader, int index, IRow row)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| index | The index. |
| row | The row. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | reader |

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)