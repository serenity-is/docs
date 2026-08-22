# ModulePageExtensions.GridPage method (1 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Creates a grid page from the specified module page model.

```csharp
public static ModulePageResult GridPage(this Controller controller, ModulePageModel model)
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

# ModulePageExtensions.GridPage method (2 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Creates a grid page for the specified module and page title.

```csharp
public static ModulePageResult GridPage(this Controller controller, string module, 
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

---

# ModulePageExtensions.GridPage&lt;TRow&gt; method (3 of 3)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Creates a grid page for the specified row type and module.

```csharp
public static ModulePageResult GridPage<TRow>(this Controller controller, string module, 
    object options = null, string layout = null, LocalText pageTitle = null)
    where TRow : IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The row type. |
| controller | The controller. |
| module | The module name. |
| options | Optional options passed to the module script. |
| layout | The layout to use. |
| pageTitle | The page title. |

## Return Value

The module page result.

## See Also

* class [ModulePageResult](../ModulePageResult.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* interface [IRow](../Serenity.Net.Services/../../Serenity.Data/IRow.md)
* class [ModulePageExtensions](../ModulePageExtensions.md)