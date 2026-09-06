# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for save request handlers that share state and mode neutral helper methods between synchronous and asynchronous save request handlers.

```csharp
public abstract class SaveRequestHandlerBase<TRow, TSaveRequest, TSaveResponse> : 
    ISaveRequestHandler
    where TRow : class, IRow, IIdRow, new()
    where TSaveRequest : SaveRequest<TRow>, new()
    where TSaveResponse : SaveResponse, new()
```

| parameter | description |
| --- | --- |
| TRow | Entity type |
| TSaveRequest | Save request type |
| TSaveResponse | Save response type |
| context | Request context |

## Public Members

| name | description |
| --- | --- |
| [Cache](SaveRequestHandlerBase-3/Cache.md) { get; } | Gets the two level cache from the request context. |
| [Connection](SaveRequestHandlerBase-3/Connection.md) { get; } | Gets the current connection. |
| [Context](SaveRequestHandlerBase-3/Context.md) { get; } | Gets the request context. |
| [IsCreate](SaveRequestHandlerBase-3/IsCreate.md) { get; } | Returns true if this is a Create operation. |
| [IsUpdate](SaveRequestHandlerBase-3/IsUpdate.md) { get; } | Returns true if this is an Update operation. |
| [Localizer](SaveRequestHandlerBase-3/Localizer.md) { get; } | Gets the localizer from the request context. |
| [Old](SaveRequestHandlerBase-3/Old.md) { get; protected set; } | Gets the old entity for update. |
| [Permissions](SaveRequestHandlerBase-3/Permissions.md) { get; } | Gets the permission service from the request context. |
| [Request](SaveRequestHandlerBase-3/Request.md) { get; protected set; } | Gets the request object. |
| [Response](SaveRequestHandlerBase-3/Response.md) { get; protected set; } | Gets the response object. |
| [Row](SaveRequestHandlerBase-3/Row.md) { get; protected set; } | Gets the inserted entity for Create and the new entity for Update. |
| [StateBag](SaveRequestHandlerBase-3/StateBag.md) { get; } | A state bag for behaviors to preserve state among their methods. It will be cleared before each request, e.g. Process call. |
| [UnitOfWork](SaveRequestHandlerBase-3/UnitOfWork.md) { get; protected set; } | Gets the current unit of work. |
| [User](SaveRequestHandlerBase-3/User.md) { get; } | Gets the current user from the request context. |

## Protected Members

| name | description |
| --- | --- |
| [SaveRequestHandlerBase](SaveRequestHandlerBase-3/SaveRequestHandlerBase.md)(…) | Abstract base class for save request handlers that share state and mode neutral helper methods between synchronous and asynchronous save request handlers. |
| virtual [ClearNonTableAssignments](SaveRequestHandlerBase-3/ClearNonTableAssignments.md)() | Clears assignment for fields that are marked as non table field, e.g. fields that are not mapped, view, expression etc. |
| virtual [CustomValidate](SaveRequestHandlerBase-3/CustomValidate.md)(…) | Calls custom validator. |
| virtual [GetBehaviors](SaveRequestHandlerBase-3/GetBehaviors.md)() | Gets the list of save behaviors. |
| virtual [GetDisplayOrderFilter](SaveRequestHandlerBase-3/GetDisplayOrderFilter.md)() | Gets the display order filter for current group, if the entity implements [`IDisplayOrderRow`](../Serenity.Data/IDisplayOrderRow.md) interface |
| virtual [GetEditableFields](SaveRequestHandlerBase-3/GetEditableFields.md)(…) | Gets the list of editable fields. These are fields that have Insertable (if Create), or Updatable (if Update) flags, and have the insert or update permission based on the type of the current operation. |
| virtual [GetRequiredFields](SaveRequestHandlerBase-3/GetRequiredFields.md)(…) | Gets the list of required fields based on editable list, and NotNull |
| virtual [HandleNonEditable](SaveRequestHandlerBase-3/HandleNonEditable.md)(…) | Handles assignment to a non-editable field. If the field did not change in an update operation, it will be ignored by clearing the assignment. For non-table fields it will also be ignored. |
| virtual [InvalidateCacheOnCommit](SaveRequestHandlerBase-3/InvalidateCacheOnCommit.md)() | Attaches an handler to unit of work's OnCommit event to invalidate the cache items related to this row's cache group |
| virtual [SetDefaultValue](SaveRequestHandlerBase-3/SetDefaultValue.md)(…) | Sets the default value (DefaultValueAttribute) for the field |
| virtual [SetDefaultValues](SaveRequestHandlerBase-3/SetDefaultValues.md)() | Sets the default values for all fields (DefaultValueAttribute) |
| virtual [SetTrimToEmptyFields](SaveRequestHandlerBase-3/SetTrimToEmptyFields.md)() | Sets values for TrimToEmpty fields. |
| virtual [ValidateAndClearIdField](SaveRequestHandlerBase-3/ValidateAndClearIdField.md)() | Validates and clears the ID field |
| virtual [ValidateEditable](SaveRequestHandlerBase-3/ValidateEditable.md)() | Validates editable fields. |
| virtual [ValidateEditableFields](SaveRequestHandlerBase-3/ValidateEditableFields.md)(…) | Validates editable fields, e.g. checks if the assigned fields are all in the editable set. Calls [`HandleNonEditable`](SaveRequestHandlerBase-3/HandleNonEditable.md) if not. |
| virtual [ValidateFieldValues](SaveRequestHandlerBase-3/ValidateFieldValues.md)() | Validates field values via [`ICustomValidator`](../Serenity/ICustomValidator.md) interface. |
| virtual [ValidateIsActive](SaveRequestHandlerBase-3/ValidateIsActive.md)() | Validates that record is not soft deleted |
| virtual [ValidatePermissions](SaveRequestHandlerBase-3/ValidatePermissions.md)() | Validates user permissions by checking InsertPermissionAttribute and UpdatePermissionAttribute, and ModifyPermissionAttribute or ReadPermissionAttribute if others are not found. |
| virtual [ValidateRequired](SaveRequestHandlerBase-3/ValidateRequired.md)(…) | Validates required fields |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ISaveRequestHandler](ISaveRequestHandler.md)
* interface [IRow](../Serenity.Data/IRow.md)
* interface [IIdRow](../Serenity.Data/IIdRow.md)
* class [SaveRequest&lt;TEntity&gt;](SaveRequest-1.md)
* class [TRow](../Serenity.Net.Services/SaveRequestHandlerBase-3.TRow.md)
* class [SaveResponse](SaveResponse.md)
* **Source:** *[SaveRequestHandlerBase.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Save/SaveRequestHandlerBase.cs)*