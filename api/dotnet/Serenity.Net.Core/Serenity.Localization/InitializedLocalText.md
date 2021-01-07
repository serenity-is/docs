# InitializedLocalText class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A subclass of LocalText class that contains a initial translation value. Some classes like NestedLocalTextRegistration uses this type to avoid re-registering a initialized local text object, when their Initialization method called more than once.

```csharp
public class InitializedLocalText : LocalText
```

## Public Members

| name | description |
| --- | --- |
| [InitializedLocalText](InitializedLocalText/InitializedLocalText.md)(…) | Initializes a new instance of the [`InitializedLocalText`](InitializedLocalText.md) class. |
| [InitialText](InitializedLocalText/InitialText.md) { get; } | Gets the initial text. |

## See Also

* class [LocalText](../Serenity/LocalText.md)
* **Source:** *[InitializedLocalText.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/InitializedLocalText.cs)*