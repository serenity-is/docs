# HttpContextUserAccessor class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of IUserAccessor that reads the current user from the HTTP context.

```csharp
public class HttpContextUserAccessor : IUserAccessor
```

| parameter | description |
| --- | --- |
| httpContextAccessor | The HTTP context accessor. |

## Public Members

| name | description |
| --- | --- |
| [HttpContextUserAccessor](HttpContextUserAccessor/HttpContextUserAccessor.md)(…) | Default implementation of IUserAccessor that reads the current user from the HTTP context. |
| [User](HttpContextUserAccessor/User.md) { get; } |  |

## Remarks

Initializes a new instance of the [`HttpContextUserAccessor`](HttpContextUserAccessor.md) class.

## See Also

* interface [IUserAccessor](../Serenity.Net.Core/../Serenity.Abstractions/IUserAccessor.md)
* **Source:** *[HttpContextUserAccessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Common/HttpContextUserAccessor.cs)*