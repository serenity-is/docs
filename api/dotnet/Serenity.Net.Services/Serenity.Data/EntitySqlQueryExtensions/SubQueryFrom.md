# EntitySqlQueryExtensions.SubQueryFrom&lt;TFields&gt; method

Creates a subquery and adds the specified fields as its FROM source without setting an INTO target. If the fields use the default T0 alias, an available alias is allocated from the query tree.

```csharp
public static SqlQuery SubQueryFrom<TFields>(this QueryWithParams query, TFields fields, 
    out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query. |
| fields | The fields. |
| aliased | The fields instance used as the FROM source by the created subquery, with its actual alias. |

## Return Value

The created subquery.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or fields is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [QueryWithParams](../QueryWithParams.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)