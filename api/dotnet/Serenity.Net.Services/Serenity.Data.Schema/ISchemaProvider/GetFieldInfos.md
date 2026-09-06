# ISchemaProvider.GetFieldInfos method

Gets the field infos.

```csharp
public IEnumerable<FieldInfo> GetFieldInfos(IDbConnection connection, string schema, string table)
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| schema | The schema. |
| table | The table. |

## Return Value

The list of field metadata for the table.

## See Also

* class [FieldInfo](../FieldInfo.md)
* interface [ISchemaProvider](../ISchemaProvider.md)