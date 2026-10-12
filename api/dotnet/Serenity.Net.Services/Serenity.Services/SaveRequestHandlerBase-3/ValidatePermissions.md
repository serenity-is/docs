# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidatePermissions method

Validates user permissions by checking InsertPermissionAttribute and UpdatePermissionAttribute, and ModifyPermissionAttribute or ReadPermissionAttribute if others are not found.

```csharp
protected virtual void ValidatePermissions()
```

## Remarks

This check is per row type, not per record, so it does not prevent modifying records that belong to other users or tenants by their id. For record level authorization, implement a behavior that applies the required filter in [`OnPrepareQuery`](../ISaveBehaviorSync/OnPrepareQuery.md), or override this method. See the multitenancy tutorial in Serenity docs.

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)