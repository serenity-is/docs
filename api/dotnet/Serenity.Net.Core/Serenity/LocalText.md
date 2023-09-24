# LocalText class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Defines a localizable text resource. Contains a local text key and has implicit conversions to and from String.

```csharp
public class LocalText : ILocalText
```

## Public Members

| name | description |
| --- | --- |
| [LocalText](LocalText/LocalText.md)(…) | Creates a new LocalText instance that contains the specified local text key |
| static readonly [Empty](LocalText/Empty.md) | An empty local text instance like string.Empty |
| [Key](LocalText/Key.md) { get; } | Gets the local text key |
| [ToString](LocalText/ToString.md)(…) | Returns the translation for current context |
| const [InvariantLanguageID](LocalText/InvariantLanguageID.md) | Invariant language ID is an empty string |
| [implicit operator](LocalText/op_Implicit.md) | Implicit conversion from String that creates a new instance of LocalText with the specified key. |

## See Also

* interface [ILocalText](../Serenity.Localization/ILocalText.md)
* **Source:** *[LocalText.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/LocalText.cs)*