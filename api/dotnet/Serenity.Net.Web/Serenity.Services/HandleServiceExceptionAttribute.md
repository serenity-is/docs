# HandleServiceExceptionAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An exception filter attribute to handle service exceptions and return them as ServiceResponse objects.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class HandleServiceExceptionAttribute : ExceptionFilterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [HandleServiceExceptionAttribute](HandleServiceExceptionAttribute/HandleServiceExceptionAttribute.md)() | The default constructor. |
| override [OnException](HandleServiceExceptionAttribute/OnException.md)(…) |  |

## See Also

* **Source:** *[HandleServiceExceptionAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/HandleServiceExceptionAttribute.cs)*