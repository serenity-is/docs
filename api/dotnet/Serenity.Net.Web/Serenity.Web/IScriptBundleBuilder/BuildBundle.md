# IScriptBundleBuilder.BuildBundle method

Builds a dynamic script that concatenates the given JS source files, minimizing the files as configured by [`ScriptBundlingOptions`](../ScriptBundlingOptions.md).

```csharp
public DynamicScript BuildBundle(IEnumerable<string> sourceFiles)
```

| parameter | description |
| --- | --- |
| sourceFiles | The app relative (`~/`) JS file urls or `dynamic://` references to other dynamic scripts. |

## Return Value

A dynamic script producing the bundle content.

## See Also

* class [DynamicScript](../../../Serenity.Net.Services/Serenity.Web/DynamicScript.md)
* interface [IScriptBundleBuilder](../IScriptBundleBuilder.md)