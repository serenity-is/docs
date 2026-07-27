# ServiceQueryHelper.ApplyContainsText method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies contains text criteria to the query

```csharp
public static SqlQuery ApplyContainsText(this SqlQuery query, string containsText, 
    Action<string, long?> filter)
```

| parameter | description |
| --- | --- |
| query | Query |
| containsText | Contains text |
| filter | Filter callback |

## See Also

* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ServiceQueryHelper](../ServiceQueryHelper.md)