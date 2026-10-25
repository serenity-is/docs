# LocalText class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Defines a localizable text resource. Contains a local text key and has implicit conversions to and from String.

```csharp
public class LocalText : ILocalText
```

| parameter | description |
| --- | --- |
| key | The local text key. |

## Public Members

| name | description |
| --- | --- |
| [LocalText](LocalText/LocalText.md)(…) | Defines a localizable text resource. Contains a local text key and has implicit conversions to and from String. |
| static readonly [Empty](LocalText/Empty.md) | An empty local text instance, similar to Empty. |
| [Key](LocalText/Key.md) { get; } | Gets the local text key. |
| [ToString](LocalText/ToString.md)(…) | Returns the translation for the current context. |
| const [InvariantLanguageID](LocalText/InvariantLanguageID.md) | The invariant language ID, which is an empty string. |
| static [IsLocalTextKeyCandidate](LocalText/IsLocalTextKeyCandidate.md)(…) | Determines whether the specified text is a candidate for a local text key, optionally restricting to UI key prefixes. |
| static [ResolveFromAttribute](LocalText/ResolveFromAttribute.md)(…) | Resolves the local text key and invariant text for an attribute value. |
| [implicit operator](LocalText/op_Implicit.md) | Implicit conversion from String that creates a new instance of [`LocalText`](./LocalText.md) with the specified key. |

## Remarks

Creates a new [`LocalText`](./LocalText.md) instance that contains the specified local text key.

## See Also

* interface [ILocalText](../Serenity.Localization/ILocalText.md)
* **Source:** *[LocalText.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/core/Localization/LocalText.cs)*