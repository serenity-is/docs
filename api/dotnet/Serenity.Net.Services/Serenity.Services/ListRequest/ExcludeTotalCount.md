# ListRequest.ExcludeTotalCount property
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Exclude the total count from the result. Set this to true if you don't need the total number of records when Skip / Take parameters are passed. Otherwise, a second query will be required to get number of total records.

```csharp
public bool ExcludeTotalCount { get; set; }
```

## See Also

* class [ListRequest](../ListRequest.md)