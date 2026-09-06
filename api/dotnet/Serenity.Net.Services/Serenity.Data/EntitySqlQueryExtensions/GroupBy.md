# EntitySqlQueryExtensions.GroupBy method (1 of 2)

Adds a field's expression to the group by list.

```csharp
public static SqlQuery GroupBy(this SqlQuery query, IField field)
```

| parameter | description |
| --- | --- |
| query | The query. |
| field | The field. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)

---

# EntitySqlQueryExtensions.GroupBy method (2 of 2)

Adds field expressions to the group by list.

```csharp
public static SqlQuery GroupBy(this SqlQuery query, params IField[] fields)
```

| parameter | description |
| --- | --- |
| query | The query. |
| fields | The fields. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | fields is null. |

## See Also

* class [SqlQuery](../SqlQuery.md)
* interface [IField](../IField.md)
* class [EntitySqlQueryExtensions](../EntitySqlQueryExtensions.md)