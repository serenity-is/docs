# IRemoveAll interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Abstraction for objects that supports clearing all items, like a cache or local text registry.

```csharp
public interface IRemoveAll
```

## Members

| name | description |
| --- | --- |
| [RemoveAll](IRemoveAll/RemoveAll.md)() | Removes all cached items from target object. |

## Remarks

This is introduced so that we don't have to add a RemoveAll to ILocalTextRegistry and break backward compatibility, while trying to resolve issue: https://github.com/serenity-is/Serenity/issues/4568

## See Also

* **Source:** *[IRemoveAll.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/IRemoveAll.cs)*