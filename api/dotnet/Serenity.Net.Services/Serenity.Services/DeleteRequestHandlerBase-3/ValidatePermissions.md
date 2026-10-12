# DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.ValidatePermissions method

Validates the user permissions for delete operation

```csharp
protected virtual void ValidatePermissions()
```

## Remarks

This check is per row type, not per record, so it does not prevent deleting records that belong to other users or tenants by their id. For record level authorization, implement a behavior that applies the required filter in [`OnPrepareQuery`](../IDeleteBehaviorSync/OnPrepareQuery.md), or override this method. See the multitenancy tutorial in Serenity docs.

## See Also

* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerBase-3.md)