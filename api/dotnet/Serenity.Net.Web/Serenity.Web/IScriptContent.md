# IScriptContent interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Cached dynamic script content

```csharp
public interface IScriptContent
```

## Members

| name | description |
| --- | --- |
| [BrotliContent](IScriptContent/BrotliContent.md) { get; } | Compressed Brotli content |
| [CanCompress](IScriptContent/CanCompress.md) { get; } | Returns true if the content can be compressed |
| [CompressedContent](IScriptContent/CompressedContent.md) { get; } | Compressed Gzip content |
| [Content](IScriptContent/Content.md) { get; } | Uncompressed content |
| [Hash](IScriptContent/Hash.md) { get; } | Hash of the cached content |
| [Time](IScriptContent/Time.md) { get; } | Time the cached content is generated at |

## See Also

* **Source:** *[IScriptContent.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScript/IScriptContent.cs)*