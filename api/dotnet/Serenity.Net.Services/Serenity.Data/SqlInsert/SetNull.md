# SqlInsert.SetNull method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Assigns NULL as the field value.

```csharp
public SqlInsert SetNull(string field)
```

| parameter | description |
| --- | --- |
| field | Field (required). |

## Return Value

SqlInsert object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [SqlInsert](../SqlInsert.md)