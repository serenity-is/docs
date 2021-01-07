# NestedLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of local texts in nested static classes. Nested static contains LocalText objects with actual translations as keys. This class locates them (with NestedLocalTextsAttribute at outermost class), determines keys by path from outermost to nested class name, replaces existing LocalText instance with a InitializedLocalText instance containing this generated key and initial translation, and registers this translation in ILocalTextRegistry provider.

```csharp
public static class NestedLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddNestedTexts](NestedLocalTextRegistration/AddNestedTexts.md)(…) | Adds translations from static nested local text classes marked with NestedLocalTextAttribute. |

## See Also

* **Source:** *[NestedLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/NestedLocalTextRegistration.cs)*