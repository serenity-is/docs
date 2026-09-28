# EntitySqlQueryExtensions.IntoForeignRow&lt;TFields&gt; method

Selects fields from an already joined foreign row into a row-valued property.

```csharp
public static SqlQuery IntoForeignRow<TFields>(this SqlQuery query, Field foreignRowField, 
    Action<TFields, SqlQuery> configure)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The fields type of the foreign row. |
| query | The query. |
| foreignRowField | The row field representing the foreign row. |
| configure | Configures selected fields for the foreign row. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query, foreignRowField, or configure is null. |
| ArgumentException | The field is not row-valued or does not belong to the current into row. |
| InvalidOperationException | The foreign row metadata is invalid or there is no current into row. |

## Remarks

Nested calls to `IntoForeignRow` are not currently supported.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [Field](../Field.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)