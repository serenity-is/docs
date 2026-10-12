# SqlUpdate.SetTo method (1 of 2)

Sets field value to the expression.

```csharp
public SqlUpdate SetTo(IField field, string expression)
```

| parameter | description |
| --- | --- |
| field | Field name (required). |
| expression | Field expression (required). |

## Return Value

SqlUpdate object itself.

## See Also

* interface [IField](../IField.md)
* class [SqlUpdate](../SqlUpdate.md)

---

# SqlUpdate.SetTo method (2 of 2)

Sets field value to the expression.

```csharp
public SqlUpdate SetTo(string field, string expression)
```

| parameter | description |
| --- | --- |
| field | Field name (required). |
| expression | Field expression, required. |

## Return Value

SqlUpdate object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | field or expression is null or empty, or field was already set. |

## See Also

* class [SqlUpdate](../SqlUpdate.md)