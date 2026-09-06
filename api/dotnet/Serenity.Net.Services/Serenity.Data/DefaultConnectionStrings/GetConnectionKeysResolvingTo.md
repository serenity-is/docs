# DefaultConnectionStrings.GetConnectionKeysResolvingTo method

Returns all connection keys (including themselves) whose fallback chain resolves to the specified connection key. Only keys that actually resolve to a configured connection are included, so this is a configuration-aware operation.

```csharp
public virtual IEnumerable<string> GetConnectionKeysResolvingTo(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## Return Value

The connection keys resolving to the specified key.

## See Also

* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)