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

* class [BaseRequestHandler](../Serenity.Net.Services/../Serenity.Services/BaseRequestHandler.md)
* interface [IElevationHandler](../Serenity.Abstractions/IElevationHandler.md)
* **Source:** *[DefaultElevationHandler.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/Elevation/DefaultElevationHandler.cs)*