# DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.InvalidateCacheOnCommit method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type.

```csharp
protected virtual void InvalidateCacheOnCommit()
```

## See Also

* class [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandler-3.md)