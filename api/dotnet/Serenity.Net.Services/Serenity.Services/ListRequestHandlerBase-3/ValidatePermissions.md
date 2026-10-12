# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ValidatePermissions method

Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute and ServiceLookupPermissionAttribute if the request is in lookup access mode.

```csharp
protected virtual void ValidatePermissions()
```

## Remarks

This check is per row type, not per record, so it does not prevent listing records that belong to other users or tenants. For record level authorization, implement a behavior that applies the required filter in [`OnPrepareQuery`](../IListBehaviorSync/OnPrepareQuery.md), or override this method. See the multitenancy tutorial in Serenity docs.

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)