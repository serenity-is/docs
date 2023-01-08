# StringHelper.SanitizeFilename method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sanitizes the filename by removing diacritics, ı with i and replacing any invalid filename characters with underscore.

```csharp
public static string SanitizeFilename(string filename, string replacement = "_", 
    bool removeDiacritics = true)
```

| parameter | description |
| --- | --- |
| filename | The string. |
| replacement | Replacement string for invalid characters |
| removeDiacritics | True to remove diacritics |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | s is null |

## See Also

* class [StringHelper](../StringHelper.md)