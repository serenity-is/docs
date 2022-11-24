# BaseSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for behaviors implementing [`ISaveBehavior`](ISaveBehavior.md)

```csharp
public abstract class BaseSaveBehavior : ISaveBehavior, ISaveExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterSave](BaseSaveBehavior/OnAfterSave.md)(…) |  |
| virtual [OnAudit](BaseSaveBehavior/OnAudit.md)(…) |  |
| virtual [OnBeforeSave](BaseSaveBehavior/OnBeforeSave.md)(…) |  |
| virtual [OnException](BaseSaveBehavior/OnException.md)(…) |  |
| virtual [OnPrepareQuery](BaseSaveBehavior/OnPrepareQuery.md)(…) |  |
| virtual [OnReturn](BaseSaveBehavior/OnReturn.md)(…) |  |
| virtual [OnSetInternalFields](BaseSaveBehavior/OnSetInternalFields.md)(…) |  |
| virtual [OnValidateRequest](BaseSaveBehavior/OnValidateRequest.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseSaveBehavior](BaseSaveBehavior/BaseSaveBehavior.md)() | The default constructor. |

## See Also

* interface [ISaveBehavior](ISaveBehavior.md)
* interface [ISaveExceptionBehavior](ISaveExceptionBehavior.md)
* **Source:** *[BaseSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/BaseSaveBehavior.cs)*