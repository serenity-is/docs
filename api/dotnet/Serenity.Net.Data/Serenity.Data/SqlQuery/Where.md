# SqlQuery.Where method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds an expression to WHERE clause. If query already has a WHERE clause, inserts AND between existing one and new one.

```csharp
public SqlQuery Where(string expression)
```

| parameter | description |
| --- | --- |
| expression | An expression |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Where method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds expressions to WHERE clause, inserting AND between them.

```csharp
public SqlQuery Where(params string[] expressions)
```

| parameter | description |
| --- | --- |
| expressions | An array of expressions |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)