# ServiceHelper.IsUniqueIndexException method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks if an exception seems to be an unique index exception

```csharp
public static bool IsUniqueIndexException(IDbConnection connection, Exception exception, 
    string indexName, IRow oldRow, IRow newRow, params Field[] indexFields)
```

| parameter | description |
| --- | --- |
| connection | Connection |
| exception | Exception |
| indexName | Optional index name to check |
| oldRow | Old row |
| newRow | New row |
| indexFields | List of index fields |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | connection or exception is null |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [ServiceHelper](../ServiceHelper.md)