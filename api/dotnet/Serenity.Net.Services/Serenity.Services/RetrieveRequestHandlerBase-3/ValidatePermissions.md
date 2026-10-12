# RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.ValidatePermissions method

Validates if the user is allowed to query this entity type by checking ReadPermissionAttribute

```csharp
protected virtual void ValidatePermissions()
```

## Remarks

This check is per row type, not per record, so it does not prevent accessing records that belong to other users or tenants by their id. For record level authorization, implement a behavior that applies the required filter in [`OnPrepareQuery`](../IRetrieveBehaviorSync/OnPrepareQuery.md), or override this method. See the multitenancy tutorial in Serenity docs.

## See Also

* class [RetrieveRequestHandlerBase&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandlerBase-3.md)