# FirebirdSchemaProvider class
**namespace:** *[Serenity.Data.Schema](../README.md#serenity.data.schema-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Firebird metadata provider.

```csharp
public class FirebirdSchemaProvider : ISchemaProvider
```

## Public Members

| name | description |
| --- | --- |
| [FirebirdSchemaProvider](FirebirdSchemaProvider/FirebirdSchemaProvider.md)() | The default constructor. |
| [DefaultSchema](FirebirdSchemaProvider/DefaultSchema.md) { get; } | Gets the default schema. |
| [GetFieldInfos](FirebirdSchemaProvider/GetFieldInfos.md)(…) |  |
| [GetForeignKeys](FirebirdSchemaProvider/GetForeignKeys.md)(…) |  |
| [GetIdentityFields](FirebirdSchemaProvider/GetIdentityFields.md)(…) |  |
| [GetPrimaryKeyFields](FirebirdSchemaProvider/GetPrimaryKeyFields.md)(…) |  |
| [GetTableNames](FirebirdSchemaProvider/GetTableNames.md)(…) |  |
| static [GetSqlTypeFromBlrType](FirebirdSchemaProvider/GetSqlTypeFromBlrType.md)(…) | Gets the type of the SQL type from BLR. |

## See Also

* interface [ISchemaProvider](./ISchemaProvider.md)
* **Source:** *[FirebirdSchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/1e66d4fe41e3c62f4c0db4bf992c68699219f1a6/src/services/Data/Schema/Providers/FirebirdSchemaProvider.cs)*