# DynamicScriptMiddleware class
**namespace:** *[Serenity.Web.Middleware](../README.md#serenity.web.middleware-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script middleware that handles "/DynJS.axd/" and "/DynamicData/" paths.

```csharp
public class DynamicScriptMiddleware
```

## Public Members

| name | description |
| --- | --- |
| [DynamicScriptMiddleware](DynamicScriptMiddleware/DynamicScriptMiddleware.md)(…) | Creates a new instance of the middleware |
| [Invoke](DynamicScriptMiddleware/Invoke.md)(…) | Invokes the middleware in the context |
| static [ReturnScript](DynamicScriptMiddleware/ReturnScript.md)(…) | Returns a dynamic script by its key |
| static [WriteWithIfModifiedSinceControl](DynamicScriptMiddleware/WriteWithIfModifiedSinceControl.md)(…) | Writes a file content to the response with modified since control |

## See Also

* **Source:** *[DynamicScriptMiddleware.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScript/DynamicScriptMiddleware.cs)*