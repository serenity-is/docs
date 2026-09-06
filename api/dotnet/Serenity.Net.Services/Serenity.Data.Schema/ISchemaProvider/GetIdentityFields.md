# ISchemaProvider.GetIdentityFields method

Gets the identity fields.

```csharp
public IEnumerable<string> GetIdentityFields(IDbConnection connection, string schema, string table)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| schema | The schema. |
| table | The table. |

## Return Value

The list of identity field names for the table.

## See Also

* interface [ISchemaProvider](../ISchemaProvider.md)