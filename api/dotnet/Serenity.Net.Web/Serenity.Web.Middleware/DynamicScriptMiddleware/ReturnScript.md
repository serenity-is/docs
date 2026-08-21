# DynamicScriptMiddleware.ReturnScript method
**namespace:** *[Serenity.Web.Middleware](../../README.md#serenity.web.middleware-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Returns a dynamic script by its key.

```csharp
public static Task ReturnScript(HttpContext context, string scriptKey, string contentType, 
    bool json)
```

| parameter | description |
| --- | --- |
| context | The HTTP context. |
| scriptKey | The script key. |
| contentType | The content type. |
| json | `true` to return JSON. |

## See Also

* class [DynamicScriptMiddleware](../DynamicScriptMiddleware.md)