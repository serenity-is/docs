# AutoValidateAntiforgeryIgnoreBearerAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An attribute that causes validation of antiforgery tokens for all unsafe HTTP methods. An antiforgery token is required for HTTP methods other than GET, HEAD, OPTIONS, and TRACE, and when there is no cookie header and authorization is Bearer, e.g. JWT etc.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AutoValidateAntiforgeryIgnoreBearerAttribute : Attribute, IFilterFactory, 
    IOrderedFilter
```

## Public Members

| name | description |
| --- | --- |
| [AutoValidateAntiforgeryIgnoreBearerAttribute](AutoValidateAntiforgeryIgnoreBearerAttribute/AutoValidateAntiforgeryIgnoreBearerAttribute.md)() | The default constructor. |
| [IsReusable](AutoValidateAntiforgeryIgnoreBearerAttribute/IsReusable.md) { get; } |  |
| [Order](AutoValidateAntiforgeryIgnoreBearerAttribute/Order.md) { get; set; } |  |
| [CreateInstance](AutoValidateAntiforgeryIgnoreBearerAttribute/CreateInstance.md)(…) |  |

## Remarks

[`AutoValidateAntiforgeryIgnoreBearerAttribute`](AutoValidateAntiforgeryIgnoreBearerAttribute.md) can be applied as a global filter to trigger validation of antiforgery tokens by default for an application. Use IgnoreAntiforgeryTokenAttribute to suppress validation of the antiforgery token for a controller or action.

## See Also

* **Source:** *[AutoValidateAntiforgeryIgnoreBearerAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/AutoValidateAntiforgeryIgnoreBearerAttribute.cs)*