# DefaultImplicitBehaviorRegistry class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for the [`IImplicitBehaviorRegistry`](./IImplicitBehaviorRegistry.md)

```csharp
public class DefaultImplicitBehaviorRegistry : IImplicitBehaviorRegistry
```

| parameter | description |
| --- | --- |
| typeSource | The type source to extract [`IImplicitBehavior`](./IImplicitBehavior.md) types from |

## Public Members

| name | description |
| --- | --- |
| [DefaultImplicitBehaviorRegistry](DefaultImplicitBehaviorRegistry/DefaultImplicitBehaviorRegistry.md)(…) | Default implementation for the [`IImplicitBehaviorRegistry`](./IImplicitBehaviorRegistry.md) |
| [GetTypes](DefaultImplicitBehaviorRegistry/GetTypes.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *typeSource* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IImplicitBehaviorRegistry](./IImplicitBehaviorRegistry.md)
* **Source:** *[DefaultImplicitBehaviorRegistry.cs](https://github.com/serenity-is/Serenity/blob/0ecdd6666300147eb7b98189e3ebb71954692e8c/src/services/RequestHandlers/Behavior/DefaultImplicitBehaviorRegistry.cs)*