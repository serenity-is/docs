# ISchemaProvider interface
**namespace:** *[Serenity.Data.Schema](../README.md#serenity.data.schema-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Abstraction for SQL metadata providers

```csharp
public interface ISchemaProvider
```

## Members

| name | description |
| --- | --- |
| [DefaultSchema](ISchemaProvider/DefaultSchema.md) { get; } | Gets the default schema. |
| [GetFieldInfos](ISchemaProvider/GetFieldInfos.md)(…) | Gets the field infos. |
| [GetForeignKeys](ISchemaProvider/GetForeignKeys.md)(…) | Gets the foreign keys. |
| [GetIdentityFields](ISchemaProvider/GetIdentityFields.md)(…) | Gets the identity fields. |
| [GetPrimaryKeyFields](ISchemaProvider/GetPrimaryKeyFields.md)(…) | Gets the primary key fields. |
| [GetTableNames](ISchemaProvider/GetTableNames.md)(…) | Gets the table names. |

## See Also

* **Source:** *[ISchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Schema/ISchemaProvider.cs)*