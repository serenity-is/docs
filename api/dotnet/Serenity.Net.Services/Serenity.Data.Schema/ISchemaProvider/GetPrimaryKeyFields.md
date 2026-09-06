# ISchemaProvider.GetPrimaryKeyFields method

Gets the primary key fields.

```csharp
public IEnumerable<string> GetPrimaryKeyFields(IDbConnection connection, string schema, 
    string table)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| schema | The schema. |
| table | The table. |

## Return Value

The list of primary key field names for the table.

## See Also

* interface [ISchemaProvider](../ISchemaProvider.md)