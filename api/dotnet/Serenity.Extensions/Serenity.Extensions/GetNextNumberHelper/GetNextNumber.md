# GetNextNumberHelper.GetNextNumber method

Gets the next number for the specified field based on the request prefix and length.

```csharp
public static GetNextNumberResponse GetNextNumber(IDbConnection connection, 
    GetNextNumberRequest request, Field field)
```

| parameter | description |
| --- | --- |
| connection | The database connection. |
| request | The request containing the prefix and length. |
| field | The field to query for the maximum existing number. |

## Return Value

The next number and its serial representation.

## See Also

* class [GetNextNumberResponse](../GetNextNumberResponse.md)
* class [GetNextNumberRequest](../GetNextNumberRequest.md)
* class [Field](../../../Serenity.Net.Services/Serenity.Data/Field.md)
* class [GetNextNumberHelper](../GetNextNumberHelper.md)