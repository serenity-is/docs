# TranslationListResponse class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

The response model for a translation list request.

```csharp
public class TranslationListResponse : ListResponse<TranslationItem>
```

## Public Members

| name | description |
| --- | --- |
| [TranslationListResponse](TranslationListResponse/TranslationListResponse.md)() | The default constructor. |
| [KeysByAssembly](TranslationListResponse/KeysByAssembly.md) { get; } | The translation keys grouped by the assembly they originate from. |

## See Also

* class [ListResponse&lt;T&gt;](../../Serenity.Net.Services/Serenity.Services/ListResponse-1.md)
* class [TranslationItem](./TranslationItem.md)
* **Source:** *[TranslationListResponse.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/Translation/TranslationListResponse.cs)*