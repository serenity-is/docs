# TemplateHelper.RenderViewToString method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Renders a CSHTML view to string

```csharp
public static string RenderViewToString(IServiceProvider serviceProvider, string viewName, 
    object model, Action<ViewContext> beforeRender = null)
```

| parameter | description |
| --- | --- |
| serviceProvider | Service provider |
| viewName | View name |
| model | Model object, can also be ViewDataDictionary containing the actual model |
| beforeRender | An optional callback which will be passed the view context before rendering starts |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException |  |

## See Also

* class [TemplateHelper](../TemplateHelper.md)