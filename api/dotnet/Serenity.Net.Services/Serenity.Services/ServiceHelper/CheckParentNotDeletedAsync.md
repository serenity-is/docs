# ServiceHelper.CheckParentNotDeletedAsync method

Asynchronously checks that parent record is not soft deleted

```csharp
public static Task CheckParentNotDeletedAsync(IDbConnection connection, string tableName, 
    Action<SqlQuery> filter, ITextLocalizer localizer, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| tableName | Table name |
| filter | Filter callback |
| localizer | Text localizer |
| cancellationToken | Cancellation token |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [ServiceHelper](../ServiceHelper.md)