# GroupBy constructor (1 of 2)

Creates an empty GroupBy object

```csharp
public GroupBy()
```

## See Also

* class [GroupBy](../GroupBy.md)

---

# GroupBy constructor (2 of 2)

Creates a GroupBy object for the specified field name.

```csharp
public GroupBy(string field, bool descending = false, DateGroupInterval? interval = default)
```

| parameter | description |
| --- | --- |
| field | The field name. |
| descending | Whether the groups are in descending order of the field. |
| interval | The interval the values of a date field are grouped by. |

## See Also

* enum [DateGroupInterval](../DateGroupInterval.md)
* class [GroupBy](../GroupBy.md)