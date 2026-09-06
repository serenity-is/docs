# DynamicScriptMiddleware.ReturnScript method

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