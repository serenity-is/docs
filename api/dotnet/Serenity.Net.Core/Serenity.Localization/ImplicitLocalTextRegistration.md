# ImplicitLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains initialization methods for adding implicit local text keys defined by attributes implementing [`IImplicitLocalTextRegistrar`](../Serenity.Abstractions/IImplicitLocalTextRegistrar.md).

```csharp
public static class ImplicitLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddImplicitTexts](ImplicitLocalTextRegistration/AddImplicitTexts.md)(…) | Adds implicit local text keys defined by attributes implementing [`IImplicitLocalTextRegistrar`](../Serenity.Abstractions/IImplicitLocalTextRegistrar.md) to the specified registry. This method iterates through all types provided by the *typeSource* and invokes the [`AddLocalTexts`](../Serenity.Abstractions/IImplicitLocalTextRegistrar/AddLocalTexts.md) method on each attribute implementing [`IImplicitLocalTextRegistrar`](../Serenity.Abstractions/IImplicitLocalTextRegistrar.md). |

## See Also

* **Source:** *[ImplicitLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/3a58f573e72b80328379377bcf4a9880efa4c00e/src/core/Localization/ImplicitLocalTextRegistration.cs)*