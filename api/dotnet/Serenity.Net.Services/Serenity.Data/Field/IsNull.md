# Field.IsNull method (1 of 2)

Creates a new "the Field IS NULL" criteria.

```csharp
public BaseCriteria IsNull()
```

## Return Value

The IS NULL criteria.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [Field](../Field.md)

---

# Field.IsNull method (2 of 2)

Determines whether the specified row is null. This method checks for assignment if TrackWithChecks is true and may throw an exception if the field is unassigned. Use IsNullNoCheck to skip that check.

```csharp
public bool IsNull(IRow row)
```

| parameter | description |
| --- | --- |
| row | The row. |

## Return Value

`true` if the specified row is null; otherwise, `false`.

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)