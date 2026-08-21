# ScriptContent constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Default implementation of IScriptContent.

```csharp
public ScriptContent(byte[] content, DateTime time, CompressionLevel compressionLevel)
```

| parameter | description |
| --- | --- |
| content | The content bytes. |
| time | The generation time. |
| compressionLevel | The suggested compression level. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *content* is `null`. |

## Remarks

Initializes a new instance of the [`ScriptContent`](../ScriptContent.md) class.

## See Also

* class [ScriptContent](../ScriptContent.md)