# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generic base class for save request handlers

```csharp
public class SaveRequestHandler<TRow, TSaveRequest, TSaveResponse> : 
    ISaveHandler<TRow, TSaveRequest, TSaveResponse>, ISaveRequestProcessor
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |

## Public Members

| name | description |
| --- | --- |
| [SaveRequestHandler](SaveRequestHandler-3/SaveRequestHandler.md)(…) | Creates a new instance of the class |
| [Cache](SaveRequestHandler-3/Cache.md) { get; } | Gets the two level cache from the request context |
| [Connection](SaveRequestHandler-3/Connection.md) { get; } | Gets connection |
| [Context](SaveRequestHandler-3/Context.md) { get; } | Gets the request context |
| [IsCreate](SaveRequestHandler-3/IsCreate.md) { get; } | Returns true if this is a Create operation |
| [IsUpdate](SaveRequestHandler-3/IsUpdate.md) { get; } | Returns true if this is an Update operation |
| [Localizer](SaveRequestHandler-3/Localizer.md) { get; } | Gets localizer from the request context |
| [Old](SaveRequestHandler-3/Old.md) { get; protected set; } | The old entity for update |
| [Permissions](SaveRequestHandler-3/Permissions.md) { get; } | Gets permission service from the request context |
| [Request](SaveRequestHandler-3/Request.md) { get; protected set; } | Request object |
| [Response](SaveRequestHandler-3/Response.md) { get; protected set; } | Response object |
| [Row](SaveRequestHandler-3/Row.md) { get; protected set; } | The inserted entity for Create and new entity for Update |
| [StateBag](SaveRequestHandler-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](SaveRequestHandler-3/UnitOfWork.md) { get; protected set; } | Gets the current unit of work |
| [User](SaveRequestHandler-3/User.md) { get; } | Gets current user from the request context |
| [Create](SaveRequestHandler-3/Create.md)(…) |  |
| [Process](SaveRequestHandler-3/Process.md)(…) | Processes the save request. This is the entry point for the handler. |
| [Update](SaveRequestHandler-3/Update.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [behaviors-](SaveRequestHandler-3/behaviors-.md) | Lazy list of behaviors that is activated for this request |
| virtual [AfterSave](SaveRequestHandler-3/AfterSave.md)() | Called after executing the insert/update statement |
| virtual [BeforeSave](SaveRequestHandler-3/BeforeSave.md)() | Called before executing the insert/update statement |
| virtual [ClearNonTableAssignments](SaveRequestHandler-3/ClearNonTableAssignments.md)() | Clears assignment for fields that are marked as non table field, e.g. fields that are not mapped, view, expression etc. |
| virtual [CustomValidate](SaveRequestHandler-3/CustomValidate.md)(…) | Calls custom validator |
| virtual [ExecuteSave](SaveRequestHandler-3/ExecuteSave.md)() | Executes the actual SQL save operation |
| virtual [GetBehaviors](SaveRequestHandler-3/GetBehaviors.md)() | Gets the list of save behaviors |
| virtual [GetDisplayOrderFilter](SaveRequestHandler-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements IDisplayOrderRow interface |
| virtual [GetEditableFields](SaveRequestHandler-3/GetEditableFields.md)(…) | Gets the list of editable fields. These are fields that have Insertable (if Create), or Updatable (if Update) flags, and have the insert or update permission based on the type of the current operation. |
| virtual [GetRequiredFields](SaveRequestHandler-3/GetRequiredFields.md)(…) | Gets the list of required fields based on editable list, and NotNull |
| virtual [HandleDisplayOrder](SaveRequestHandler-3/HandleDisplayOrder.md)(…) | Handles display order field calculation before and after save |
| virtual [HandleNonEditable](SaveRequestHandler-3/HandleNonEditable.md)(…) | Handles assignment to a non-editable field. If the field did not change in an update operation, it will be ignored by clearing the assignment. For non-table fields it will also be ignored. |
| virtual [InvalidateCacheOnCommit](SaveRequestHandler-3/InvalidateCacheOnCommit.md)() | Attaches an handler to unit of work's OnCommit event to invalidate the cache items related to this row's cache group |
| virtual [InvokeSaveAction](SaveRequestHandler-3/InvokeSaveAction.md)(…) | Invokes the passed save action method |
| virtual [LoadOldEntity](SaveRequestHandler-3/LoadOldEntity.md)() | Loads the old entity for an update operation |
| virtual [OnReturn](SaveRequestHandler-3/OnReturn.md)() | Called just before the response is returned |
| virtual [PerformAuditing](SaveRequestHandler-3/PerformAuditing.md)() | Performs auditing |
| virtual [PrepareQuery](SaveRequestHandler-3/PrepareQuery.md)() | Prepares the query for selecting old record in an update operation |
| virtual [SetDefaultValue](SaveRequestHandler-3/SetDefaultValue.md)(…) | Sets the default value (DefaultValueAttribute) for the field |
| virtual [SetDefaultValues](SaveRequestHandler-3/SetDefaultValues.md)() | Sets the default values for all fields (DefaultValueAttribute) |
| virtual [SetInternalFields](SaveRequestHandler-3/SetInternalFields.md)() | Sets values for internal fields |
| virtual [SetTrimToEmptyFields](SaveRequestHandler-3/SetTrimToEmptyFields.md)() | Sets values for TrimToEmpty fields. |
| virtual [ValidateAndClearIdField](SaveRequestHandler-3/ValidateAndClearIdField.md)() | Validates and clears the ID field |
| virtual [ValidateEditable](SaveRequestHandler-3/ValidateEditable.md)() | Validates editable fields |
| virtual [ValidateEditableFields](SaveRequestHandler-3/ValidateEditableFields.md)(…) | Validates editable fields, e.g. checks if the assigned fields are all in the editable set. Calls [`HandleNonEditable`](SaveRequestHandler-3/HandleNonEditable.md) if not. |
| virtual [ValidateFieldValues](SaveRequestHandler-3/ValidateFieldValues.md)() | Validates field values via ICustomValidator interface. |
| virtual [ValidateIsActive](SaveRequestHandler-3/ValidateIsActive.md)() | Validates that record is not soft deleted |
| virtual [ValidatePermissions](SaveRequestHandler-3/ValidatePermissions.md)() | Validates user permissions by checking InsertPermissionAttribute and UpdatePermissionAttribute, and ModifyPermissionAttribute or ReadPermissionAttribute if others are not found. |
| virtual [ValidateRequest](SaveRequestHandler-3/ValidateRequest.md)() | Validates the request by checking insert / update permissions. |
| virtual [ValidateRequired](SaveRequestHandler-3/ValidateRequired.md)(…) | Validates required fields |

## See Also

* interface [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](ISaveHandler-3.md)
* class [TRow](../Serenity.Net.Services/SaveRequestHandler-3.TRow.md)
* class [TSaveRequest](../Serenity.Net.Services/SaveRequestHandler-3.TSaveRequest.md)
* class [TSaveResponse](../Serenity.Net.Services/SaveRequestHandler-3.TSaveResponse.md)
* interface [ISaveRequestProcessor](ISaveRequestProcessor.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Net.Entity/../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [SaveResponse](SaveResponse.md)
* **Source:** *[SaveRequestHandler.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/SaveRequestHandler.cs)*