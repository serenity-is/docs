# DisplayOrderHelper.GetNextValue method (1 of 2)

Gets the next display order value for a table or a group of records.

```csharp
public static int GetNextValue(IDbConnection connection, IDisplayOrderRow row, 
    ICriteria? filter = null)
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| row | Row with a display order field (required). |
| filter | Filter for records (can be null). |

## Return Value

One more of maximum display order values of records in the group. If none, 1.

## Remarks

Not race safe: the value is computed here but inserted later, so concurrent inserts in the same group may compute the same value. A unique index on the display order column is recommended so the database rejects duplicates. See the class remarks.

## See Also

* interface [IDisplayOrderRow](../IDisplayOrderRow.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)

---

# DisplayOrderHelper.GetNextValue method (2 of 2)

Gets the next display order value for a table or a group of records.

```csharp
public static int GetNextValue(IDbConnection connection, string tableName, Field orderField, 
    ICriteria? filter)
```

| parameter | description |
| --- | --- |
| connection | Connection (required). |
| tableName | Table name (required). |
| orderField | Display order field meta (required). |
| filter | Filter for records (can be null). |

## Return Value

One more of maximum display order values of records in the group. If none, 1.

## Remarks

Not race safe: the value is computed here but inserted later, so concurrent inserts in the same group may compute the same value. A unique index on the display order column is recommended so the database rejects duplicates. See the class remarks.

## See Also

* class [Field](../Field.md)
* interface [ICriteria](../../Serenity/ICriteria.md)
* class [DisplayOrderHelper](../DisplayOrderHelper.md)