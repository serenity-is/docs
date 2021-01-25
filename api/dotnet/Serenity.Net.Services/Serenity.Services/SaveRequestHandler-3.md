# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

```csharp
public class SaveRequestHandler<TRow, TSaveRequest, TSaveResponse> : 
    IRequestHandler<TRow, TSaveRequest, TSaveResponse>, ISaveRequestProcessor
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

## Public Members

| name | description |
| --- | --- |
| [SaveRequestHandler](SaveRequestHandler-3/SaveRequestHandler.md)(…) |  |
| [Cache](SaveRequestHandler-3/Cache.md) { get; } |  |
| [Connection](SaveRequestHandler-3/Connection.md) { get; } |  |
| [Context](SaveRequestHandler-3/Context.md) { get; } |  |
| [IsCreate](SaveRequestHandler-3/IsCreate.md) { get; } |  |
| [IsUpdate](SaveRequestHandler-3/IsUpdate.md) { get; } |  |
| [Localizer](SaveRequestHandler-3/Localizer.md) { get; } |  |
| [Old](SaveRequestHandler-3/Old.md) { get; protected set; } |  |
| [Permissions](SaveRequestHandler-3/Permissions.md) { get; } |  |
| [Request](SaveRequestHandler-3/Request.md) { get; protected set; } |  |
| [Response](SaveRequestHandler-3/Response.md) { get; protected set; } |  |
| [Row](SaveRequestHandler-3/Row.md) { get; protected set; } |  |
| [StateBag](SaveRequestHandler-3/StateBag.md) { get; } |  |
| [UnitOfWork](SaveRequestHandler-3/UnitOfWork.md) { get; protected set; } |  |
| [User](SaveRequestHandler-3/User.md) { get; } |  |
| [Process](SaveRequestHandler-3/Process.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](SaveRequestHandler-3/behaviors-.md) |  |
| virtual [AfterSave](SaveRequestHandler-3/AfterSave.md)() |  |
| virtual [BeforeSave](SaveRequestHandler-3/BeforeSave.md)() |  |
| virtual [ClearNonTableAssignments](SaveRequestHandler-3/ClearNonTableAssignments.md)() |  |
| virtual [CustomValidate](SaveRequestHandler-3/CustomValidate.md)(…) |  |
| virtual [ExecuteSave](SaveRequestHandler-3/ExecuteSave.md)() |  |
| virtual [GetBehaviors](SaveRequestHandler-3/GetBehaviors.md)() |  |
| virtual [GetDisplayOrderFilter](SaveRequestHandler-3/GetDisplayOrderFilter.md)() |  |
| virtual [GetEditableFields](SaveRequestHandler-3/GetEditableFields.md)(…) |  |
| virtual [GetRequiredFields](SaveRequestHandler-3/GetRequiredFields.md)(…) |  |
| virtual [HandleDisplayOrder](SaveRequestHandler-3/HandleDisplayOrder.md)(…) |  |
| virtual [HandleNonEditable](SaveRequestHandler-3/HandleNonEditable.md)(…) |  |
| virtual [InvalidateCacheOnCommit](SaveRequestHandler-3/InvalidateCacheOnCommit.md)() |  |
| virtual [InvokeSaveAction](SaveRequestHandler-3/InvokeSaveAction.md)(…) |  |
| virtual [LoadOldEntity](SaveRequestHandler-3/LoadOldEntity.md)() |  |
| virtual [OnReturn](SaveRequestHandler-3/OnReturn.md)() |  |
| virtual [PerformAuditing](SaveRequestHandler-3/PerformAuditing.md)() |  |
| virtual [PrepareQuery](SaveRequestHandler-3/PrepareQuery.md)() |  |
| virtual [SetDefaultValue](SaveRequestHandler-3/SetDefaultValue.md)(…) |  |
| virtual [SetDefaultValues](SaveRequestHandler-3/SetDefaultValues.md)() |  |
| virtual [SetInternalFields](SaveRequestHandler-3/SetInternalFields.md)() |  |
| virtual [SetTrimToEmptyFields](SaveRequestHandler-3/SetTrimToEmptyFields.md)() |  |
| virtual [ValidateAndClearIdField](SaveRequestHandler-3/ValidateAndClearIdField.md)() |  |
| virtual [ValidateEditable](SaveRequestHandler-3/ValidateEditable.md)() |  |
| virtual [ValidateEditableFields](SaveRequestHandler-3/ValidateEditableFields.md)(…) |  |
| virtual [ValidateFieldValues](SaveRequestHandler-3/ValidateFieldValues.md)() |  |
| virtual [ValidateIsActive](SaveRequestHandler-3/ValidateIsActive.md)() |  |
| virtual [ValidatePermissions](SaveRequestHandler-3/ValidatePermissions.md)() |  |
| virtual [ValidateRequest](SaveRequestHandler-3/ValidateRequest.md)() |  |
| virtual [ValidateRequired](SaveRequestHandler-3/ValidateRequired.md)(…) |  |

## See Also

* interface [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](IRequestHandler-3.md)
* class [TRow](../Serenity.Net.Services/SaveRequestHandler-3.TRow.md)
* class [TSaveRequest](../Serenity.Net.Services/SaveRequestHandler-3.TSaveRequest.md)
* class [TSaveResponse](../Serenity.Net.Services/SaveRequestHandler-3.TSaveResponse.md)
* interface [ISaveRequestProcessor](ISaveRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* **Source:** *[SaveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/SaveRequestHandler.cs)*