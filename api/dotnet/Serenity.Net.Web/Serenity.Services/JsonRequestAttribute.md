# JsonRequestAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class JsonRequestAttribute : ActionFilterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [JsonRequestAttribute](JsonRequestAttribute/JsonRequestAttribute.md)() | The default constructor. |
| [AllowForm](JsonRequestAttribute/AllowForm.md) { get; set; } |  |
| [AllowGet](JsonRequestAttribute/AllowGet.md) { get; set; } |  |
| [AllowQuery](JsonRequestAttribute/AllowQuery.md) { get; set; } |  |
| [ParamName](JsonRequestAttribute/ParamName.md) { get; set; } |  |
| override [OnActionExecuting](JsonRequestAttribute/OnActionExecuting.md)(…) |  |
| static [DefaultAllowForm](JsonRequestAttribute/DefaultAllowForm.md) { get; set; } |  |
| static [DefaultAllowGet](JsonRequestAttribute/DefaultAllowGet.md) { get; set; } |  |
| static [DefaultAllowQuery](JsonRequestAttribute/DefaultAllowQuery.md) { get; set; } |  |

## See Also

* **Source:** *[JsonRequestAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/JsonRequestAttribute.cs)*