# BaseUserRetrieveService&lt;TRow&gt;.GetUsernameCacheKey method

Gets the cache key for the specified username. If the row implements [`INormalizedUsernameRow`](../INormalizedUsernameRow.md), it is based on the normalized username.

```csharp
protected override string GetUsernameCacheKey(string username)
```

| parameter | description |
| --- | --- |
| username | Username |

## See Also

* class [BaseUserRetrieveService&lt;TRow&gt;](../BaseUserRetrieveService-1.md)