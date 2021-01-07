# ICriteria.ToString method (1 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

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

* interface [IQueryWithParams](../../Serenity.Data/IQueryWithParams.md)
* interface [ICriteria](../ICriteria.md)

---

# ICriteria.ToString method (2 of 2)
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Converts the criteria to string representation into a string builder, while adding its params to the target query.

```csharp
public void ToString(StringBuilder sb, IQueryWithParams query)
```

| parameter | description |
| --- | --- |
| sb | The string builder. |
| query | The target query to add params to. |

## See Also

* interface [IQueryWithParams](../../Serenity.Data/IQueryWithParams.md)
* interface [ICriteria](../ICriteria.md)