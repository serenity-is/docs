# ILocalText interface
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface implemented by the [`LocalText`](../Serenity/LocalText.md) class to access the initial translation value. Some classes like [`NestedLocalTextRegistration`](NestedLocalTextRegistration.md) use this type to avoid re-registering an already initialized local text object when their initialization method is called more than once.

```csharp
public interface ILocalText
```

## Members

| name | description |
| --- | --- |
| [Key](ILocalText/Key.md) { get; } | Gets the local text key. |
| [OriginalKey](ILocalText/OriginalKey.md) { get; } | Returns the original key before the replacement or initialization. |
| [ReplaceKey](ILocalText/ReplaceKey.md)(…) | Replaces the local text key with the new key and stores the original key as the initial text. |

## See Also

* **Source:** *[ILocalText.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/ILocalText.cs)*