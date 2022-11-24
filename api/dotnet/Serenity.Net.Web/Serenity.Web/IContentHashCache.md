# IContentHashCache interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An abstraction for content hash cache, which contains hashes of web servable files.

```csharp
public interface IContentHashCache
```

## Members

| name | description |
| --- | --- |
| [ResolvePath](IContentHashCache/ResolvePath.md)(…) | Resolves a relative path |
| [ResolveWithHash](IContentHashCache/ResolveWithHash.md)(…) | Resolves a relative path with its hash |
| [ScriptsChanged](IContentHashCache/ScriptsChanged.md)() | Raises scripts changed event causing cache to be cleared |

## See Also

* **Source:** *[IContentHashCache.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/IContentHashCache.cs)*