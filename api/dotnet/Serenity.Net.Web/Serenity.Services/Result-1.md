# Result&lt;TResponse&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An action result type containing a object

```csharp
public class Result<TResponse> : ActionResult
```

| parameter | description |
| --- | --- |
| TResponse | Response data type |
| data | Data object |

## Public Members

| name | description |
| --- | --- |
| [Result](Result-1/Result.md)(…) | An action result type containing a object |
| [ContentEncoding](Result-1/ContentEncoding.md) { get; set; } | Content encoding |
| [ContentType](Result-1/ContentType.md) { get; set; } | Content type |
| [Data](Result-1/Data.md) { get; set; } | The data |
| [SerializerOptions](Result-1/SerializerOptions.md) { get; set; } | JSON serializer settings |
| override [ExecuteResultAsync](Result-1/ExecuteResultAsync.md)(…) |  |

## Remarks

Creates a new instance of the class

## See Also

* **Source:** *[Result.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/Result.cs)*