# ServiceHelper.IsUniqueIndexException method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public static bool IsUniqueIndexException(IDbConnection connection, Exception exception, 
    string indexName, IRow oldRow, IRow newRow, params Field[] indexFields)
```

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [ServiceHelper](../ServiceHelper.md)