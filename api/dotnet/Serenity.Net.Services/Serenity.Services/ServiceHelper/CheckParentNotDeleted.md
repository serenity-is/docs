# ServiceHelper.CheckParentNotDeleted method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks that parent record is not soft deleted

```csharp
public static void CheckParentNotDeleted(IDbConnection connection, string tableName, 
    Action<SqlQuery> filter, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| tableName | Table name |
| filter | Filter callback |
| localizer | Text localizer |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ServiceHelper](../ServiceHelper.md)