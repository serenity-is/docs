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

* interface [ISchemaProvider](ISchemaProvider.md)
* **Source:** *[FirebirdSchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Schema/Providers/FirebirdSchemaProvider.cs)*