# DefaultElevationHandler class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Default implementation of [`IElevationHandler`](../Serenity.Abstractions/IElevationHandler.md)

```csharp
public class DefaultElevationHandler : BaseRequestHandler, IElevationHandler
```

## Public Members

| name | description |
| --- | --- |
| [DefaultElevationHandler](DefaultElevationHandler/DefaultElevationHandler.md)(…) | Default implementation of [`IElevationHandler`](../Serenity.Abstractions/IElevationHandler.md) |
| [AppendElevationTokenToCookies](DefaultElevationHandler/AppendElevationTokenToCookies.md)() |  |
| [DeleteToken](DefaultElevationHandler/DeleteToken.md)() |  |
| [ValidateElevationToken](DefaultElevationHandler/ValidateElevationToken.md)() |  |
| const [ElevationTokenDuration](DefaultElevationHandler/ElevationTokenDuration.md) | The duration in minutes that an elevation token remains valid. |

## See Also

* class [BaseRequestHandler](../../Serenity.Net.Services/Serenity.Services/BaseRequestHandler.md)
* interface [IElevationHandler](../Serenity.Abstractions/IElevationHandler.md)
* **Source:** *[DefaultElevationHandler.cs](https://github.com/serenity-is/Serenity/blob/f681c4775d515f42ae248938da92305df66f5c02/common-features/src/extensions/Modules/Elevation/DefaultElevationHandler.cs)*