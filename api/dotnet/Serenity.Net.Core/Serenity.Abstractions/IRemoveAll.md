# IRemoveAll interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for objects that support clearing all items, like a cache or local text registry.

```csharp
public interface IRemoveAll
```

## Members

| name | description |
| --- | --- |
| [RemoveAll](IRemoveAll/RemoveAll.md)() | Removes all cached items from the target object. |

## Remarks

This is introduced so that we don't have to add a RemoveAll to [`ILocalTextRegistry`](ILocalTextRegistry.md) and break backward compatibility, while trying to resolve issue: https://github.com/serenity-is/Serenity/issues/4568

## See Also

* **Source:** *[IRemoveAll.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/IRemoveAll.cs)*