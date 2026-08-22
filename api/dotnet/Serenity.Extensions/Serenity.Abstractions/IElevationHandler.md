# IElevationHandler interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Interface for account elevation.

```csharp
public interface IElevationHandler
```

## Members

| name | description |
| --- | --- |
| [AppendElevationTokenToCookies](IElevationHandler/AppendElevationTokenToCookies.md)() | Appends ElevationToken to cookies. |
| [DeleteToken](IElevationHandler/DeleteToken.md)() | Deletes ElevationToken. |
| [ValidateElevationToken](IElevationHandler/ValidateElevationToken.md)() | Checks to see if ElevationToken in cookies is valid. |

## See Also

* **Source:** *[IElevationHandler.cs](https://github.com/serenity-is/Serenity/blob/bb0064f552b586c1549668ffee8248a7ac86b3c4/common-features/src/extensions/Modules/Elevation/IElevationHandler.cs)*