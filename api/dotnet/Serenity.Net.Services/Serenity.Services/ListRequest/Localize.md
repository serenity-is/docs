# ListRequest.Localize property
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Set to "true" to localize fields with the Localize attribute. Note that this will also affect filtering and sorting as the field's expression will be changed to a COALESCE one. To get a localized version in a specific language, pass the language code as the value.

```csharp
public string Localize { get; set; }
```

## See Also

* class [ListRequest](../ListRequest.md)