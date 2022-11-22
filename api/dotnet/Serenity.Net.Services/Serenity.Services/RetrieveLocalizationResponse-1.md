# RetrieveLocalizationResponse&lt;TEntity&gt; class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The service model for a localization retrieve response

```csharp
public class RetrieveLocalizationResponse<TEntity> : ServiceResponse
    where TEntity : class, new()
```

| parameter | description |
| --- | --- |
| TEntity | Type of the entities |

## Public Members

| name | description |
| --- | --- |
| [RetrieveLocalizationResponse](RetrieveLocalizationResponse-1/RetrieveLocalizationResponse.md)() | The default constructor. |
| [Entities](RetrieveLocalizationResponse-1/Entities.md) { get; set; } | The dictionary that contains languageID, localized entity pairs containing translations. |

## See Also

* class [ServiceResponse](ServiceResponse.md)
* **Source:** *[RetrieveLocalizationResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/RetrieveLocalizationResponse.cs)*