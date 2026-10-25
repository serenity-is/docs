# LayoutScriptFileProvider constructor

Default implementation of [`ILayoutScriptFileProvider`](../ILayoutScriptFileProvider.md), which discovers [`LayoutScriptFileAttribute`](../LayoutScriptFileAttribute.md)s from the type source, filters them by the registered IFeatureToggles and an optional filter, and returns them ordered with duplicates removed.

```csharp
public LayoutScriptFileProvider(ITypeSource typeSource, IServiceProvider serviceProvider, 
    IOptions<LayoutScriptFileOptions> options)
```

| parameter | description |
| --- | --- |
| typeSource | The type source. |
| serviceProvider | The service provider, used to resolve the optional IFeatureToggles. |
| options | The layout script file options. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`LayoutScriptFileProvider`](../LayoutScriptFileProvider.md) class.

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [LayoutScriptFileOptions](../LayoutScriptFileOptions.md)
* class [LayoutScriptFileProvider](../LayoutScriptFileProvider.md)