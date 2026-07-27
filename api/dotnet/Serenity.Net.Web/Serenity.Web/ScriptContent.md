# ScriptContent class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation for IScriptContent

```csharp
public class ScriptContent : IScriptContent
```

| parameter | description |
| --- | --- |
| content | Content |
| time | Time |
| compressionLevel | Suggested compression level |

## Public Members

| name | description |
| --- | --- |
| [ScriptContent](ScriptContent/ScriptContent.md)(…) | Default implementation for IScriptContent |
| [BrotliContent](ScriptContent/BrotliContent.md) { get; } |  |
| [CanCompress](ScriptContent/CanCompress.md) { get; } |  |
| [CompressedContent](ScriptContent/CompressedContent.md) { get; } |  |
| [Content](ScriptContent/Content.md) { get; } |  |
| [Hash](ScriptContent/Hash.md) { get; } | Gets script hash |
| [Time](ScriptContent/Time.md) { get; } | Gets script generated time |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## Remarks

Creates a new instance of the class

## See Also

* interface [IScriptContent](../Serenity.Net.Core/IScriptContent.md)
* **Source:** *[ScriptContent.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/DynamicScript/DynamicScript/ScriptContent.cs)*