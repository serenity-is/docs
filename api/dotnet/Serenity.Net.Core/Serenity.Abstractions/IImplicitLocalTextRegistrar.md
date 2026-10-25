# IImplicitLocalTextRegistrar interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface implemented by type attributes that register implicit local text keys, and their default translations, generally during application startup.

```csharp
public interface IImplicitLocalTextRegistrar
```

## Members

| name | description |
| --- | --- |
| [AddLocalTexts](IImplicitLocalTextRegistrar/AddLocalTexts.md)(…) | Adds local text keys and their default translations to the specified registry. This is usually called before other registration types like NestedLocalText so texts added here might be overridden by subsequent registrations. It is a good practice to skip adding keys that already exist in the registry. |

## See Also

* **Source:** *[IImplicitLocalTextRegistrar.cs](https://github.com/serenity-is/Serenity/blob/3a58f573e72b80328379377bcf4a9880efa4c00e/src/core/Localization/IImplicitLocalTextRegistrar.cs)*