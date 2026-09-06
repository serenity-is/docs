# ScriptContent class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of IScriptContent.

```csharp
public class ScriptContent : IScriptContent
```

| parameter | description |
| --- | --- |
| content | The content bytes. |
| time | The generation time. |
| compressionLevel | The suggested compression level. |

## Public Members

| name | description |
| --- | --- |
| [ScriptContent](ScriptContent/ScriptContent.md)(…) | Default implementation of IScriptContent. |
| [BrotliContent](ScriptContent/BrotliContent.md) { get; } |  |
| [CanCompress](ScriptContent/CanCompress.md) { get; } |  |
| [CompressedContent](ScriptContent/CompressedContent.md) { get; } |  |
| [Content](ScriptContent/Content.md) { get; } |  |
| [Hash](ScriptContent/Hash.md) { get; } | Gets the script hash. |
| [Time](ScriptContent/Time.md) { get; } | Gets the script generation time. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *content* is `null`. |

## Remarks

Initializes a new instance of the [`ScriptContent`](./ScriptContent.md) class.

## See Also

* interface [IScriptContent](../../Serenity.Net.Core/Serenity.Web/IScriptContent.md)
* **Source:** *[ScriptContent.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicScript/ScriptContent.cs)*