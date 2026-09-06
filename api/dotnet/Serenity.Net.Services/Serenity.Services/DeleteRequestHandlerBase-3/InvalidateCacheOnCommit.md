# DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.InvalidateCacheOnCommit method

Attaches a cache invalidation call to to OnCommit callback of the current unit of work. This would clear cached items related to this row type.

```csharp
protected virtual void InvalidateCacheOnCommit()
```

## See Also

* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerBase-3.md)