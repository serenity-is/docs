# ServiceQueryHelper.ApplySort method (1 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies sort order to the query

```csharp
public static SqlQuery ApplySort(this SqlQuery query, SortBy sortBy)
```

| parameter | description |
| --- | --- |
| query | Query |
| sortBy | Sort order |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [SortBy](../SortBy.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)

---

# ServiceQueryHelper.ApplySort method (2 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies sort orders to the query

```csharp
public static SqlQuery ApplySort(this SqlQuery query, IList<SortBy> sortByList, 
    params SortBy[] defaultSortBy)
```

| parameter | description |
| --- | --- |
| query | Query |
| sortByList | Sort orders |
| defaultSortBy | The default sort order |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [SortBy](../SortBy.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)

---

# ServiceQueryHelper.ApplySort method (3 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies the sort order to the query

```csharp
public static SqlQuery ApplySort(this SqlQuery query, string sort, bool descending)
```

| parameter | description |
| --- | --- |
| query | Query |
| sort | Sort field, ignored if null, empty or not a usable field (e.g. a field that is selected in the query or available in the row) |
| descending | Descending flag |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | query is null |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)