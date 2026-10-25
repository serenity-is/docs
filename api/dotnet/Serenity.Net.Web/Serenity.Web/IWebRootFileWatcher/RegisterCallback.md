# IWebRootFileWatcher.RegisterCallback method

Registers a callback that is invoked when any of the given app relative files changes. Only the first registration for a given key is honored, so callers may invoke this on every request without accumulating subscriptions. Only available in development.

```csharp
public void RegisterCallback(string key, IEnumerable<string> appRelativePaths, Action callback)
```

| parameter | description |
| --- | --- |
| key | A key identifying the registration, to avoid duplicates. |
| appRelativePaths | The app relative (`~/`) file urls to watch. |
| callback | The callback to invoke on change. |

## See Also

* interface [IWebRootFileWatcher](../IWebRootFileWatcher.md)