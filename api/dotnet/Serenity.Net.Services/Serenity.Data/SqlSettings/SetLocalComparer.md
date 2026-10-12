# SqlSettings.SetLocalComparer method

Sets the local comparer for the current thread and async context. Useful for background tasks, async methods, and testing to set the comparer locally and for auto spawned threads.

```csharp
public static IComparer? SetLocalComparer(IComparer? comparer)
```

| parameter | description |
| --- | --- |
| comparer | The comparer. Can be null. |

## Return Value

The old local comparer, if any.

## See Also

* class [SqlSettings](../SqlSettings.md)