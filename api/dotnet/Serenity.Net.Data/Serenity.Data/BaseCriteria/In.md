# BaseCriteria.In method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new binary IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria In(BaseCriteria statement)
```

| parameter | description |
| --- | --- |
| statement | The statement. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | statement is null or empty |

## See Also

* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.In method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new binary IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria In(ISqlQuery statement)
```

| parameter | description |
| --- | --- |
| statement | The statement query. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | statement is null |

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.In&lt;T&gt; method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new binary IN criteria containing this criteria as the left operand.

```csharp
public BaseCriteria In<T>(params T[] values)
```

| parameter | description |
| --- | --- |
| T | Type of values |
| values | The values. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | values |

## See Also

* class [T](../Serenity.Net.Data/../BaseCriteria.T.md)
* class [BaseCriteria](../BaseCriteria.md)