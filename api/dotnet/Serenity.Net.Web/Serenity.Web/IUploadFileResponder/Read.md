# IUploadFileResponder.Read method

Reads the file, e.g. writes to the response.

```csharp
public IActionResult Read(string pathInfo, IHeaderDictionary responseHeaders)
```

| parameter | description |
| --- | --- |
| pathInfo | The path information. |
| responseHeaders | The response headers. |

## Return Value

An action result based on the file mime type.

## See Also

* interface [IUploadFileResponder](../IUploadFileResponder.md)