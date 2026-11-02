# ILayoutScriptFileProvider.GetFiles method

Gets the list of app relative (`~/`) JS file urls to include in the layout, in the order they should be included, with duplicates removed. These don't include the ES modules, see [`GetModuleFiles`](./GetModuleFiles.md).

```csharp
public IReadOnlyList<string> GetFiles()
```

## Return Value

The list of JS file urls.

## See Also

* interface [ILayoutScriptFileProvider](../ILayoutScriptFileProvider.md)