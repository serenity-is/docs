# PostgresSchemaProvider class
**namespace:** *[Serenity.Data.Schema](../README.md#serenity.data.schema-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

PostgreSQL metadata provider.

```csharp
public class PostgresSchemaProvider : ISchemaProvider
```

## Public Members

| name | description |
| --- | --- |
| [PostgresSchemaProvider](PostgresSchemaProvider/PostgresSchemaProvider.md)() | The default constructor. |
| [DefaultSchema](PostgresSchemaProvider/DefaultSchema.md) { get; } | Gets the default schema. |
| [GetFieldInfos](PostgresSchemaProvider/GetFieldInfos.md)(…) |  |
| [GetForeignKeys](PostgresSchemaProvider/GetForeignKeys.md)(…) |  |
| [GetIdentityFields](PostgresSchemaProvider/GetIdentityFields.md)(…) |  |
| [GetPrimaryKeyFields](PostgresSchemaProvider/GetPrimaryKeyFields.md)(…) |  |
| [GetTableNames](PostgresSchemaProvider/GetTableNames.md)(…) |  |

## See Also

* interface [ISchemaProvider](ISchemaProvider.md)
* **Source:** *[PostgresSchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Schema/Providers/PostgresSchemaProvider.cs)*