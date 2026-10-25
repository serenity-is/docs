# ICssBundleBuilder.BuildBundle method

Builds a dynamic script that concatenates the given CSS source files, processing `@import` statements, minimizing and rewriting relative urls as configured by [`CssBundlingOptions`](../CssBundlingOptions.md).

```csharp
public DynamicScript BuildBundle(string rootPrefix, IEnumerable<string> sourceFiles)
```

| parameter | description |
| --- | --- |
| rootPrefix | The root prefix used when rewriting relative urls, e.g. `"../"` for a bundle served from one level below the application root. |
| sourceFiles | The app relative (`~/`) CSS file urls or `dynamic://` references to other dynamic scripts. |

## Return Value

A dynamic script producing the bundle content.

## See Also

* class [DynamicScript](../../../Serenity.Net.Services/Serenity.Web/DynamicScript.md)
* interface [ICssBundleBuilder](../ICssBundleBuilder.md)