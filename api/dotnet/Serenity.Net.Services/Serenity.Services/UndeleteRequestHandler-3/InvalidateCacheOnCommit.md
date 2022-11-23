# UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;.InvalidateCacheOnCommit method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type.

```csharp
protected virtual void InvalidateCacheOnCommit()
```

## See Also

* class [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](../UndeleteRequestHandler-3.md)