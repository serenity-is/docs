# JsonRequestAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action filter for methods that accept JSON content via their "request" arguments.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class JsonRequestAttribute : ActionFilterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [JsonRequestAttribute](JsonRequestAttribute/JsonRequestAttribute.md)() | Initializes a new instance of the [`JsonRequestAttribute`](JsonRequestAttribute.md) class. |
| [AllowForm](JsonRequestAttribute/AllowForm.md) { get; set; } | Gets or sets whether to allow getting the JSON body from the posted form. |
| [AllowGet](JsonRequestAttribute/AllowGet.md) { get; set; } | Gets or sets whether to allow this filter for GET requests. |
| [AllowQuery](JsonRequestAttribute/AllowQuery.md) { get; set; } | Gets or sets whether to allow getting the JSON body from the query string. |
| [ParamName](JsonRequestAttribute/ParamName.md) { get; set; } | Gets or sets the parameter name for the `request` argument. |
| override [OnActionExecutionAsync](JsonRequestAttribute/OnActionExecutionAsync.md)(…) |  |
| static [DefaultAllowForm](JsonRequestAttribute/DefaultAllowForm.md) { get; set; } | The default for [`AllowForm`](JsonRequestAttribute/AllowForm.md), which is `true`. |
| static [DefaultAllowGet](JsonRequestAttribute/DefaultAllowGet.md) { get; set; } | The default for [`AllowGet`](JsonRequestAttribute/AllowGet.md), which is `true`. |
| static [DefaultAllowQuery](JsonRequestAttribute/DefaultAllowQuery.md) { get; set; } | The default for [`AllowQuery`](JsonRequestAttribute/AllowQuery.md), which is `true`. |

## See Also

* **Source:** *[JsonRequestAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/JsonRequestAttribute.cs)*