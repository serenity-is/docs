# DynamicScriptMiddleware class
**namespace:** *[Serenity.Web.Middleware](../README.md#serenity.web.middleware-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script middleware that handles "/DynJS.axd/" and "/DynamicData/" paths.

```csharp
public class DynamicScriptMiddleware
```

| parameter | description |
| --- | --- |
| next | Next request delegate |

## Public Members

| name | description |
| --- | --- |
| [DynamicScriptMiddleware](DynamicScriptMiddleware/DynamicScriptMiddleware.md)(…) | Dynamic script middleware that handles "/DynJS.axd/" and "/DynamicData/" paths. |
| [Invoke](DynamicScriptMiddleware/Invoke.md)(…) | Invokes the middleware in the context |
| static [ReturnScript](DynamicScriptMiddleware/ReturnScript.md)(…) | Returns a dynamic script by its key |
| static [WriteWithIfModifiedSinceControl](DynamicScriptMiddleware/WriteWithIfModifiedSinceControl.md)(…) | Writes a file content to the response with modified since control |

## Remarks

Creates a new instance of the middleware

## See Also

* **Source:** *[DynamicScriptMiddleware.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/DynamicScript/DynamicScript/DynamicScriptMiddleware.cs)*