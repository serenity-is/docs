# ISchemaProvider.GetForeignKeys method

Gets the foreign keys.

```csharp
public IEnumerable<ForeignKeyInfo> GetForeignKeys(IDbConnection connection, string schema, 
    string table)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| schema | The schema. |
| table | The table. |

## Return Value

The list of foreign keys for the table.

## See Also

* class [ForeignKeyInfo](../ForeignKeyInfo.md)
* interface [ISchemaProvider](../ISchemaProvider.md)