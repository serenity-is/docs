# Result&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing a object

```csharp
public class Result<TResponse> : ActionResult
```

| parameter | description |
| --- | --- |
| TResponse | Response data type |

## Public Members

| name | description |
| --- | --- |
| [Result](Result-1/Result.md)(…) | Creates a new instance of the class |
| [ContentEncoding](Result-1/ContentEncoding.md) { get; set; } | Content encoding |
| [ContentType](Result-1/ContentType.md) { get; set; } | Content type |
| [Data](Result-1/Data.md) { get; set; } | The data |
| [Formatting](Result-1/Formatting.md) { get; set; } | Formatting |
| [SerializerSettings](Result-1/SerializerSettings.md) { get; set; } | JSON serializer settings |
| override [ExecuteResult](Result-1/ExecuteResult.md)(…) |  |

## See Also

* **Source:** *[Result.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/Result.cs)*