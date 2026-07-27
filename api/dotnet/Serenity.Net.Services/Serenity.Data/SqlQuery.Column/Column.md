# SqlQuery.Column constructor (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the [`Column`](../SqlQuery.Column.md) class.

```csharp
public Column(SqlQuery query, string expression, string columnName, object intoField)
```

| parameter | description |
| --- | --- |
| query | The query. |
| expression | The expression. |
| columnName | Name of the column. |
| intoField | The select into field. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [Column](../SqlQuery.Column.md)

---

# SqlQuery.Column constructor (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Holds information about a column in SELECT clause.

```csharp
public Column(string expression, string columnName, int intoRow, object intoField)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| columnName | Name of the column. |
| intoRow | The select into row index. |
| intoField | The select into field. |

## Remarks

Initializes a new instance of the [`Column`](../SqlQuery.Column.md) class.

## See Also

* class [Column](../SqlQuery.Column.md)