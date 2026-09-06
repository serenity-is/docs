# SqlDelete.Where method (1 of 2)

Adds a new condition to the WHERE part of the query with an "AND" between.

```csharp
public SqlDelete Where(string condition)
```

| parameter | description |
| --- | --- |
| condition | Condition. |

## Return Value

SqlDelete object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | condition is null or empty. |

## See Also

* class [SqlDelete](../SqlDelete.md)

---

# SqlDelete.Where method (2 of 2)

Adds new conditions to the WHERE part of the query with an "AND" between.

```csharp
public SqlDelete Where(params string[] conditions)
```

| parameter | description |
| --- | --- |
| conditions | Conditions. |

## Return Value

SqlDelete object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | conditions is null or empty. |

## See Also

* class [SqlDelete](../SqlDelete.md)