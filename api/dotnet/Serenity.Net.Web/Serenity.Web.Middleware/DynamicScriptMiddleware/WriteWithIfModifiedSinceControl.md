# DynamicScriptMiddleware.WriteWithIfModifiedSinceControl method
**namespace:** *[Serenity.Web.Middleware](../../README.md#serenity.web.middleware-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Writes a file content to the response with modified since control

```csharp
public static Task WriteWithIfModifiedSinceControl(HttpContext context, byte[] bytes, 
    DateTime lastWriteTime)
```

| parameter | description |
| --- | --- |
| context | HTTP context |
| bytes | Content bytes |
| lastWriteTime | Last write time |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Context is null |

## See Also

* class [DynamicScriptMiddleware](../DynamicScriptMiddleware.md)