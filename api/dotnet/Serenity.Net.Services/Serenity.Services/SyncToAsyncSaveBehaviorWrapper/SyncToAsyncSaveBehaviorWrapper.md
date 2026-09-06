# SyncToAsyncSaveBehaviorWrapper constructor

Initializes a new instance of the class.

```csharp
public SyncToAsyncSaveBehaviorWrapper(ISaveBehaviorSync syncBehavior)
```

| parameter | description |
| --- | --- |
| syncBehavior | Synchronous save behavior to wrap |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *syncBehavior* is `null`. |

## See Also

* interface [ISaveBehaviorSync](../ISaveBehaviorSync.md)
* class [SyncToAsyncSaveBehaviorWrapper](../SyncToAsyncSaveBehaviorWrapper.md)