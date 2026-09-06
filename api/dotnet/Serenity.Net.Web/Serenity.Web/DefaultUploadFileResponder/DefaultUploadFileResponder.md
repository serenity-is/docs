# DefaultUploadFileResponder constructor

Default implementation of the upload file responder.

```csharp
public DefaultUploadFileResponder(IUploadStorage uploadStorage)
```

| parameter | description |
| --- | --- |
| uploadStorage | The upload storage. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *uploadStorage* is `null`. |

## Remarks

Initializes a new instance of the [`DefaultUploadFileResponder`](../DefaultUploadFileResponder.md) class.

## See Also

* interface [IUploadStorage](../../../Serenity.Net.Services/Serenity.Web/IUploadStorage.md)
* class [DefaultUploadFileResponder](../DefaultUploadFileResponder.md)