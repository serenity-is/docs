# UploadPathHelper.CheckFileNameSecurity method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks file name security, e.g. it is a relative file (not rooted) that does not contain ".." etc.

```csharp
public static void CheckFileNameSecurity(string path)
```

| parameter | description |
| --- | --- |
| path | The file path to check. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | *path* is not a secure relative file. |

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)