# ResultWithStatus&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing a object with status code

```csharp
public class ResultWithStatus<TResponse> : StatusCodeResult
```

| parameter | description |
| --- | --- |
| TResponse | Response data type |
| data | Data object |
| statusCode | Status code |

## Public Members

| name | description |
| --- | --- |
| [ResultWithStatus](ResultWithStatus-1/ResultWithStatus.md)(…) | An action result type containing a object with status code |
| [ContentEncoding](ResultWithStatus-1/ContentEncoding.md) { get; set; } | Content encoding |
| [ContentType](ResultWithStatus-1/ContentType.md) { get; set; } | Content type |
| [Data](ResultWithStatus-1/Data.md) { get; set; } | The data |
| [SerializerOptions](ResultWithStatus-1/SerializerOptions.md) { get; set; } | JSON serializer settings |
| override [ExecuteResultAsync](ResultWithStatus-1/ExecuteResultAsync.md)(…) |  |

## Remarks

Creates a new instance of the class

## See Also

* **Source:** *[ResultWithStatus.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/ResultWithStatus.cs)*