# SqlQuery.Skip method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets current SKIP value.

```csharp
public int Skip()
```

## Return Value

SKIP value.

## See Also

* class [SqlQuery](../SqlQuery.md)

---

# SqlQuery.Skip method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Sets SKIP value. Used for paging.

```csharp
public SqlQuery Skip(int skipRows)
```

| parameter | description |
| --- | --- |
| skipRows | Number of rows to skip (server dependant implementation) |

## Return Value

The query itself.

## See Also

* class [SqlQuery](../SqlQuery.md)