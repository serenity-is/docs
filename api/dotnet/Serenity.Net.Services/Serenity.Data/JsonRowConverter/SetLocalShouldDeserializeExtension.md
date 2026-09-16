# JsonRowConverter.SetLocalShouldDeserializeExtension method

Sets the local [`ShouldDeserializeExtension`](./ShouldDeserializeExtension.md) hook for the current thread and async context. Useful for background tasks, async methods, and testing to set the hook locally without affecting other threads or tests.

```csharp
public static Func<IRow, string, bool>? SetLocalShouldDeserializeExtension(
    Func<IRow, string, bool>? value)
```

| parameter | description |
| --- | --- |
| value | The hook. Can be null to use the default hook. |

## Return Value

The old local hook, if any.

## See Also

* interface [IRow](../IRow.md)
* class [JsonRowConverter](../JsonRowConverter.md)