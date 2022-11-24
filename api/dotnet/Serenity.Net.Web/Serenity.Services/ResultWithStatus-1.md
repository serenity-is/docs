# ResultWithStatus&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing a object with status code

```csharp
public class ResultWithStatus<TResponse> : StatusCodeResult
```

| parameter | description |
| --- | --- |
| TResponse | Response data type |

## Public Members

| name | description |
| --- | --- |
| [ResultWithStatus](ResultWithStatus-1/ResultWithStatus.md)(…) | Creates a new instance of the class |
| [ContentEncoding](ResultWithStatus-1/ContentEncoding.md) { get; set; } | Content encoding |
| [ContentType](ResultWithStatus-1/ContentType.md) { get; set; } | Content type |
| [Data](ResultWithStatus-1/Data.md) { get; set; } | The data |
| [Formatting](ResultWithStatus-1/Formatting.md) { get; set; } | Formatting |
| [SerializerSettings](ResultWithStatus-1/SerializerSettings.md) { get; set; } | JSON serializer settings |
| override [ExecuteResult](ResultWithStatus-1/ExecuteResult.md)(…) |  |

## See Also

* **Source:** *[ResultWithStatus.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/ResultWithStatus.cs)*