# EntityFieldExtensions.GetTableFields method

Gets a dictionary of table fields (e.g. not a foreign or calculated field) in a row.

```csharp
public static HashSet<Field> GetTableFields(this IRow row)
```

| parameter | description |
| --- | --- |
| row | The row to return the dictionary of table fields for. |

## Return Value

A dictionary of table fields in which field objects are keys.

## See Also

* class [Field](../Field.md)
* interface [IRow](../IRow.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)