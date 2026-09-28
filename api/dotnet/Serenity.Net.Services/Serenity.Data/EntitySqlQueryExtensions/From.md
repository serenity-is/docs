# EntitySqlQueryExtensions.From method (1 of 7)

Adds the entity as a FROM source and sets it as the query's INTO target. For row entities, applies the fields' dialect if the query dialect has not been overridden, and allocates another alias if the default T0 alias is already in use.

```csharp
public static SqlQuery From(this SqlQuery query, IEntity entity)
```

| parameter | description |
| --- | --- |
| query | The query. |
| entity | The entity. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or entity is null. |
| InvalidOperationException | The query already has an INTO row. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IEntity](../IEntity.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From method (2 of 7)

Adds row fields as a FROM source and applies their dialect when the query dialect is not overridden.

```csharp
public static SqlQuery From(this SqlQuery query, RowFieldsBase fields)
```

| parameter | description |
| --- | --- |
| query | The query. |
| fields | The fields whose table is added to the query. |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From&lt;TFields&gt; method (3 of 7)

Adds the row as a FROM source and sets it as the query's INTO target. Applies the row fields' dialect if the query dialect has not been overridden.

```csharp
public static SqlQuery From<TFields>(this SqlQuery query, IRow<TFields> row)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query |
| row | The row whose table is added to the query. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or row is null. |
| InvalidOperationException | The query already has an INTO target. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow&lt;TFields&gt;](../IRow-1.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From&lt;TFields&gt; method (4 of 7)

Adds the row as a FROM source using the specified alias and sets it as the query's INTO target. Applies the row fields' dialect if the query dialect has not been overridden.

```csharp
public static SqlQuery From<TFields>(this SqlQuery query, IRow<TFields> row, string alias)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query |
| row | The row whose table is added to the query. |
| alias | The alias to use for the row. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or row is null. |
| InvalidOperationException | The query already has an INTO target. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow&lt;TFields&gt;](../IRow-1.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From&lt;TFields&gt; method (5 of 7)

Adds the row as a FROM source, returns its possibly adjusted fields, and sets it as the query's INTO target. Applies the row fields' dialect if the query dialect has not been overridden.

```csharp
public static SqlQuery From<TFields>(this SqlQuery query, IRow<TFields> row, out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query. |
| row | The row whose fields are added to the query. |
| aliased | The fields instance used as the FROM source, with the alias used by this query. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or row is null. |
| InvalidOperationException | The query already has an INTO target. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow&lt;TFields&gt;](../IRow-1.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From&lt;TFields&gt; method (6 of 7)

Adds fields as a FROM source, adjusting the default T0 alias when it is already used. This overload does not set an INTO target.

```csharp
public static SqlQuery From<TFields>(this SqlQuery query, TFields fields, out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query. |
| fields | The fields whose table is added to the query. |
| aliased | The fields instance used as the FROM source, with the alias used by this query. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or fields is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.From&lt;TFields&gt; method (7 of 7)

Adds the row as a FROM source using the specified alias, returns its aliased fields, and sets it as the query's INTO target. Applies the row fields' dialect if the query dialect has not been overridden.

```csharp
public static SqlQuery From<TFields>(this SqlQuery query, IRow<TFields> row, string alias, 
    out TFields aliased)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The row fields type. |
| query | The query. |
| row | The row whose fields are added to the query. |
| alias | The alias to use for the row. |
| aliased | The fields instance used as the FROM source, with the alias used by this query. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query or row is null. |
| InvalidOperationException | The query already has an INTO target. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IRow&lt;TFields&gt;](../IRow-1.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)