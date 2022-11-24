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
| [JsonRequestAttribute](JsonRequestAttribute/JsonRequestAttribute.md)() | Creates a new instance of the attribute |
| [AllowForm](JsonRequestAttribute/AllowForm.md) { get; set; } | True to allow getting JSON body from the posted form |
| [AllowGet](JsonRequestAttribute/AllowGet.md) { get; set; } | True to allow this filter for GET request |
| [AllowQuery](JsonRequestAttribute/AllowQuery.md) { get; set; } | True to allow getting JSON body from query string |
| [ParamName](JsonRequestAttribute/ParamName.md) { get; set; } | The parameter name for "request" argument. |
| override [OnActionExecuting](JsonRequestAttribute/OnActionExecuting.md)(…) |  |
| static [DefaultAllowForm](JsonRequestAttribute/DefaultAllowForm.md) { get; set; } | The default for AllowForm which is true |
| static [DefaultAllowGet](JsonRequestAttribute/DefaultAllowGet.md) { get; set; } | The default for AllowGet which is True |
| static [DefaultAllowQuery](JsonRequestAttribute/DefaultAllowQuery.md) { get; set; } | The default for AllowQuery which is true |

## See Also

* **Source:** *[JsonRequestAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/JsonRequestAttribute.cs)*