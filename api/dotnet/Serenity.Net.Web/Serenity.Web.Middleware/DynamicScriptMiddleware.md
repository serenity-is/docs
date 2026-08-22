# DynamicScriptMiddleware class
**namespace:** *[Serenity.Web.Middleware](../README.md#serenity.web.middleware-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script middleware that handles `/DynJS.axd/` and `/DynamicData/` paths.

```csharp
public class DynamicScriptMiddleware
```

| parameter | description |
| --- | --- |
| next | The next request delegate. |

## Public Members

| name | description |
| --- | --- |
| [DynamicScriptMiddleware](DynamicScriptMiddleware/DynamicScriptMiddleware.md)(…) | Dynamic script middleware that handles `/DynJS.axd/` and `/DynamicData/` paths. |
| [Invoke](DynamicScriptMiddleware/Invoke.md)(…) | Invokes the middleware in the given context. |
| static [ReturnScript](DynamicScriptMiddleware/ReturnScript.md)(…) | Returns a dynamic script by its key. |
| static [WriteWithIfModifiedSinceControl](DynamicScriptMiddleware/WriteWithIfModifiedSinceControl.md)(…) | Writes file content to the response with If-Modified-Since control. |

## Remarks

Initializes a new instance of the [`DynamicScriptMiddleware`](DynamicScriptMiddleware.md) class.

## See Also

* **Source:** *[DynamicScriptMiddleware.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicScript/DynamicScriptMiddleware.cs)*