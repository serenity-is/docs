# FirebirdSchemaProvider class
**namespace:** *[Serenity.Data.Schema](../README.md#serenity.data.schema-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Firebird metadata provider.

```csharp
public class FirebirdSchemaProvider : ISchemaProvider
```

## Public Members

| name | description |
| --- | --- |
| [FirebirdSchemaProvider](FirebirdSchemaProvider/FirebirdSchemaProvider.md)() | The default constructor. |
| [DefaultSchema](FirebirdSchemaProvider/DefaultSchema.md) { get; } | Gets the default schema. |
| [GetFieldInfos](FirebirdSchemaProvider/GetFieldInfos.md)(…) | Gets the field infos. |
| [GetForeignKeys](FirebirdSchemaProvider/GetForeignKeys.md)(…) | Gets the foreign keys. |
| [GetIdentityFields](FirebirdSchemaProvider/GetIdentityFields.md)(…) | Gets the identity fields. |
| [GetPrimaryKeyFields](FirebirdSchemaProvider/GetPrimaryKeyFields.md)(…) | Gets the primary key fields. |
| [GetTableNames](FirebirdSchemaProvider/GetTableNames.md)(…) | Gets the table names. |
| static [GetSqlTypeFromBlrType](FirebirdSchemaProvider/GetSqlTypeFromBlrType.md)(…) | Gets the type of the SQL type from BLR. |

## See Also

* interface [ISchemaProvider](ISchemaProvider.md)
* **Source:** *[FirebirdSchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Schema/Providers/FirebirdSchemaProvider.cs)*