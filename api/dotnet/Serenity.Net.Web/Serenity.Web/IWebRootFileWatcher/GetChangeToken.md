# IWebRootFileWatcher.GetChangeToken method

Gets a change token that fires when the given web relative file changes, or `null` if watching is not available (e.g. not in development, or the file has no physical path).

```csharp
public IChangeToken? GetChangeToken(string webRelativePath)
```

| parameter | description |
| --- | --- |
| webRelativePath | The web relative path, e.g. `Scripts/site.js`. |

## Return Value

A change token, or `null`.

## See Also

* interface [IWebRootFileWatcher](../IWebRootFileWatcher.md)