# ISchemaProvider interface
**namespace:** *[Serenity.Data.Schema](../README.md#serenity.data.schema-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for SQL metadata providers.

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

* **Source:** *[ISchemaProvider.cs](https://github.com/serenity-is/Serenity/blob/2a28525933e32e2024b92a826ed8ec67fa1a48e0/src/services/Data/Schema/ISchemaProvider.cs)*