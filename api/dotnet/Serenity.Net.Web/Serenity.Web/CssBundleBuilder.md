# CssBundleBuilder class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`ICssBundleBuilder`](./ICssBundleBuilder.md).

```csharp
public class CssBundleBuilder : ICssBundleBuilder
```

| parameter | description |
| --- | --- |
| options | The CSS bundling options. |
| scriptManager | The dynamic script manager. |
| cssMinifier | The CSS minifier. |
| hostEnvironment | The web host environment. |
| logger | The logger. |

## Public Members

| name | description |
| --- | --- |
| [CssBundleBuilder](CssBundleBuilder/CssBundleBuilder.md)(…) | Default implementation of [`ICssBundleBuilder`](./ICssBundleBuilder.md). |
| [BuildBundle](CssBundleBuilder/BuildBundle.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`CssBundleBuilder`](./CssBundleBuilder.md) class.

## See Also

* interface [ICssBundleBuilder](./ICssBundleBuilder.md)
* **Source:** *[CssBundleBuilder.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/CssBundling/CssBundleBuilder.cs)*