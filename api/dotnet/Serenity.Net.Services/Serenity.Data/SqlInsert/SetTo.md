# SqlInsert.SetTo method (1 of 2)

Sets field value.

```csharp
public SqlInsert SetTo(IField field, string expression)
```

| parameter | description |
| --- | --- |
| field | Field (required). |
| expression | Field expression, required. |

## Return Value

SqlInsert object itself.

## See Also

* interface [IField](../IField.md)
* class [SqlInsert](../SqlInsert.md)

---

# SqlInsert.SetTo method (2 of 2)

Sets field value.

```csharp
public SqlInsert SetTo(string field, string expression)
```

| parameter | description |
| --- | --- |
| field | Field name (required). |
| expression | Field expression, required. |

## Return Value

SqlInsert object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field or expression is null or empty. |

## See Also

* class [SqlInsert](../SqlInsert.md)