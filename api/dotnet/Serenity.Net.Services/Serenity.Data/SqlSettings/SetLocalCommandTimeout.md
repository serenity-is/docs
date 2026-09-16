# SqlSettings.SetLocalCommandTimeout method

Sets the local command timeout for the current thread and async context. Useful for background tasks, async methods, and testing to set the timeout locally and for auto spawned threads.

```csharp
public static int? SetLocalCommandTimeout(int? timeout)
```

| parameter | description |
| --- | --- |
| timeout | The timeout. Can be null. |

## Return Value

The old local timeout, if any.

## See Also

* class [SqlSettings](../SqlSettings.md)