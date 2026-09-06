# TemplateHelper.RenderViewToString method

Renders a CSHTML view to a string.

```csharp
public static string RenderViewToString(IServiceProvider serviceProvider, string viewName, 
    object model, Action<ViewContext> beforeRender = null)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |
| viewName | The view name. |
| model | The model object; can also be a ViewDataDictionary containing the actual model. |
| beforeRender | An optional callback which will be passed the view context before rendering starts. |

## Return Value

The rendered view content.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | The view is not found. |

## See Also

* class [TemplateHelper](../TemplateHelper.md)