# EntitySqlQueryExtensions.SelectAs method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a field or an expression to the SELECT statement with a column name of a field's name. The field is marked as a target at current index for future loading from a data reader.

```csharp
public static SqlQuery SelectAs(this SqlQuery query, string expression, IField intoField)
```

| parameter | description |
| --- | --- |
| query | The query. |
| expression | A field name or an expression |
| intoField | A field object whose name to be used as a column name. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field or alias |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)