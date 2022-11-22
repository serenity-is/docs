# RetrieveRequest class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The request model for a Retrieve service

```csharp
public class RetrieveRequest : ServiceRequest, IIncludeExcludeColumns
```

## Public Members

| name | description |
| --- | --- |
| [RetrieveRequest](RetrieveRequest/RetrieveRequest.md)() | The default constructor. |
| [ColumnSelection](RetrieveRequest/ColumnSelection.md) { get; set; } | The group of columns to select. This is RetrieveColumnSelection.Details by default, e.g. all the table / view columns, but not unmapped or complex object style (list etc.) columns. |
| [EntityId](RetrieveRequest/EntityId.md) { get; set; } | The entity ID to retrieve |
| [ExcludeColumns](RetrieveRequest/ExcludeColumns.md) { get; set; } |  |
| [IncludeColumns](RetrieveRequest/IncludeColumns.md) { get; set; } |  |

## See Also

* class [ServiceRequest](ServiceRequest.md)
* interface [IIncludeExcludeColumns](IIncludeExcludeColumns.md)
* **Source:** *[RetrieveRequest.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/RetrieveRequest.cs)*