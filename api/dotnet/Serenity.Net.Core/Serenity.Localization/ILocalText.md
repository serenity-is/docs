# ILocalText interface
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface implemented by LocalText class to access initial translation value. Some classes like NestedLocalTextRegistration uses this type to avoid re-registering a initialized local text object, when their Initialization method called more than once.

```csharp
public interface ILocalText
```

## Members

| name | description |
| --- | --- |
| [Key](ILocalText/Key.md) { get; } | Gets the key |
| [OriginalKey](ILocalText/OriginalKey.md) { get; } | Returns original key before the replacement / initialization |
| [ReplaceKey](ILocalText/ReplaceKey.md)(…) | Replaces local text key with the new key and stores the original key as initial text |

## See Also

* **Source:** *[ILocalText.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/ILocalText.cs)*