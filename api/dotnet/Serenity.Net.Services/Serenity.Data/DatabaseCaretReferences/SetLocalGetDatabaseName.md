# DatabaseCaretReferences.SetLocalGetDatabaseName method

Sets the local database name resolver for the current thread and async context. Useful for background tasks, async methods, and testing to set the resolver locally and for auto spawned threads.

```csharp
public static Func<string, string>? SetLocalGetDatabaseName(Func<string, string>? resolver)
```

| parameter | description |
| --- | --- |
| resolver | The resolver. Can be null. |

## Return Value

The old local resolver, if any.

## See Also

* class [DatabaseCaretReferences](../DatabaseCaretReferences.md)