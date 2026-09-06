# Result&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing an object.

```csharp
public class Result<TResponse> : ActionResult
```

| parameter | description |
| --- | --- |
| TResponse | The response data type. |
| data | The data object. |

## Public Members

| name | description |
| --- | --- |
| [Result](Result-1/Result.md)(…) | An action result type containing an object. |
| [ContentEncoding](Result-1/ContentEncoding.md) { get; set; } | Gets or sets the content encoding. |
| [ContentType](Result-1/ContentType.md) { get; set; } | Gets or sets the content type. |
| [Data](Result-1/Data.md) { get; set; } | Gets or sets the data. |
| [SerializerOptions](Result-1/SerializerOptions.md) { get; set; } | Gets or sets the JSON serializer settings. |
| override [ExecuteResultAsync](Result-1/ExecuteResultAsync.md)(…) |  |

## Remarks

Initializes a new instance of the [`Result`](Result-1.md) class.

## See Also

* **Source:** *[Result.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/web/Mvc/Result.cs)*