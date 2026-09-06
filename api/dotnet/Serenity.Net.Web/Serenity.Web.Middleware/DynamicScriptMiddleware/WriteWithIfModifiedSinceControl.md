# DynamicScriptMiddleware.WriteWithIfModifiedSinceControl method

Writes file content to the response with If-Modified-Since control.

```csharp
public static Task WriteWithIfModifiedSinceControl(HttpContext context, byte[] bytes, 
    DateTime lastWriteTime)
```

| parameter | description |
| --- | --- |
| context | The HTTP context. |
| bytes | The content bytes. |
| lastWriteTime | The last write time. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *context* is `null`. |

## See Also

* class [DynamicScriptMiddleware](../DynamicScriptMiddleware.md)