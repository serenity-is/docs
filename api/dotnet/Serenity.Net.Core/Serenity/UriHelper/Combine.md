# UriHelper.Combine method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Combine a url with a filename by inserting "/" char between them.This works like Path.Combine

```csharp
public static string Combine(string url, string fileName)
```

| parameter | description |
| --- | --- |
| url | URL will be combined (null or empty can be used). |
| fileName | Filename or Path (required). |

## Return Value

New string which consists of combining URL and Filename by inserting "/" char between them

## Remarks

This function is used for only simple combining actions. like ".." relative actions doesn't be checked as well as URL with querystring doesn't be supported.

## See Also

* class [UriHelper](../UriHelper.md)