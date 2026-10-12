# UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.ValidatePermissions method

Validates the user permissions for undelete operation

```csharp
protected virtual void ValidatePermissions()
```

## Remarks

This check is per row type, not per record, so it does not prevent undeleting records that belong to other users or tenants by their id. For record level authorization, implement a behavior that applies the required filter in [`OnPrepareQuery`](../IUndeleteBehaviorSync/OnPrepareQuery.md), or override this method. See the multitenancy tutorial in Serenity docs.

## See Also

* class [UndeleteRequestHandlerBase&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandlerBase-3.md)