# ModulePageExtensions.PanelPage method (1 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Creates a panel page from the specified module page model.

```csharp
public static ModulePageResult PanelPage(this Controller controller, ModulePageModel model)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| model | The module page model. |

## Return Value

The module page result.

## See Also

* class [ModulePageResult](../ModulePageResult.md)
* class [ModulePageModel](../ModulePageModel.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)

---

# ModulePageExtensions.PanelPage method (2 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Creates a panel page for the specified module and page title.

```csharp
public static ModulePageResult PanelPage(this Controller controller, string module, 
    LocalText pageTitle, object options = null, string layout = null)
```

| parameter | description |
| --- | --- |
| controller | The controller. |
| module | The module name. |
| pageTitle | The page title. |
| options | Optional options passed to the module script. |
| layout | The layout to use. |

## Return Value

The module page result.

## See Also

* class [ModulePageResult](../ModulePageResult.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)