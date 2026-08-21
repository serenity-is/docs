# IContentHashCache interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An abstraction for a content hash cache, which contains hashes of web servable files.

```csharp
public interface IContentHashCache
```

## Members

| name | description |
| --- | --- |
| [ResolvePath](IContentHashCache/ResolvePath.md)(…) | Resolves a relative path. |
| [ResolveWithHash](IContentHashCache/ResolveWithHash.md)(…) | Resolves a relative path with its hash. |
| [ScriptsChanged](IContentHashCache/ScriptsChanged.md)() | Raises the scripts changed event, causing the cache to be cleared. |

## See Also

* **Source:** *[IContentHashCache.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/IContentHashCache.cs)*