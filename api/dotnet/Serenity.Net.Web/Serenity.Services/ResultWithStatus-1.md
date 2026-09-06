# ResultWithStatus&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing an object with a status code.

```csharp
public class ResultWithStatus<TResponse> : StatusCodeResult
```

| parameter | description |
| --- | --- |
| TResponse | The response data type. |
| data | The data object. |
| statusCode | The status code. |

## Public Members

| name | description |
| --- | --- |
| [ResultWithStatus](ResultWithStatus-1/ResultWithStatus.md)(…) | An action result type containing an object with a status code. |
| [ContentEncoding](ResultWithStatus-1/ContentEncoding.md) { get; set; } | Gets or sets the content encoding. |
| [ContentType](ResultWithStatus-1/ContentType.md) { get; set; } | Gets or sets the content type. |
| [Data](ResultWithStatus-1/Data.md) { get; set; } | Gets or sets the data. |
| [SerializerOptions](ResultWithStatus-1/SerializerOptions.md) { get; set; } | Gets or sets the JSON serializer settings. |
| override [ExecuteResultAsync](ResultWithStatus-1/ExecuteResultAsync.md)(…) |  |

## Remarks

Initializes a new instance of the [`ResultWithStatus`](ResultWithStatus-1.md) class.

## See Also

* **Source:** *[ResultWithStatus.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/web/Mvc/ResultWithStatus.cs)*