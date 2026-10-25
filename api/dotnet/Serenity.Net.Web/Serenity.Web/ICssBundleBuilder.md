# ICssBundleBuilder interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for building a CSS bundle from a list of source files.

```csharp
public interface ICssBundleBuilder
```

## Members

| name | description |
| --- | --- |
| [BuildBundle](ICssBundleBuilder/BuildBundle.md)(…) | Builds a dynamic script that concatenates the given CSS source files, processing `@import` statements, minimizing and rewriting relative urls as configured by [`CssBundlingOptions`](./CssBundlingOptions.md). |

## See Also

* **Source:** *[ICssBundleBuilder.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/CssBundling/ICssBundleBuilder.cs)*