# SqlUpdate.SetTo method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Sets field value to the expression.

```csharp
public SqlUpdate SetTo(IField field, string value)
```

| parameter | description |
| --- | --- |
| field | Field name (required). |
| value | Field expression (required). |

## Return Value

SqlInsert object itself.

## See Also

* interface [IField](../IField.md)
* class [SqlUpdate](../SqlUpdate.md)

---

# SqlUpdate.SetTo method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Sets field value to the expression.

```csharp
public SqlUpdate SetTo(string field, string value)
```

| parameter | description |
| --- | --- |
| field | Field name (required). |
| value | Field value (expression, required). |

## Return Value

SqlUpdate object itself.

## See Also

* class [SqlUpdate](../SqlUpdate.md)