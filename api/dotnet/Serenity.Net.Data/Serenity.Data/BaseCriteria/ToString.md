# BaseCriteria.ToString method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Converts the criteria to string. Raises an exception if criteria contains parameters.

```csharp
public override string ToString()
```

## Return Value

A String that represents this instance.

## See Also

* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.ToString method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Converts the criteria to string representation while adding params to the target query.

```csharp
public string ToString(IQueryWithParams query)
```

| parameter | description |
| --- | --- |
| query | The target query to add params to. |

## Return Value

A String that represents this instance.

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [BaseCriteria](../BaseCriteria.md)

---

# BaseCriteria.ToString method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Converts the criteria to string representation into a string builder, while adding its params to the target query.

```csharp
public virtual void ToString(StringBuilder sb, IQueryWithParams query)
```

| parameter | description |
| --- | --- |
| sb | The string builder. |
| query | The target query to add params to. |

## See Also

* interface [IQueryWithParams](../IQueryWithParams.md)
* class [BaseCriteria](../BaseCriteria.md)