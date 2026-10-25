# LayoutCssFileProvider constructor

Default implementation of [`ILayoutCssFileProvider`](../ILayoutCssFileProvider.md), which discovers [`LayoutCssFileAttribute`](../LayoutCssFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed.

```csharp
public LayoutCssFileProvider(ITypeSource typeSource, IServiceProvider serviceProvider, 
    IOptions<LayoutCssFileOptions> options)
```

| parameter | description |
| --- | --- |
| typeSource | The type source. |
| serviceProvider | The service provider, used to resolve the optional IFeatureToggles. |
| options | The layout CSS file options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`LayoutCssFileProvider`](../LayoutCssFileProvider.md) class.

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [LayoutCssFileOptions](../LayoutCssFileOptions.md)
* class [LayoutCssFileProvider](../LayoutCssFileProvider.md)