# BaseSaveBehaviorAsync class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for behaviors implementing [`ISaveBehaviorAsync`](ISaveBehaviorAsync.md)

```csharp
public abstract class BaseSaveBehaviorAsync : ISaveBehaviorAsync, ISaveExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterSaveAsync](BaseSaveBehaviorAsync/OnAfterSaveAsync.md)(…) |  |
| virtual [OnAuditAsync](BaseSaveBehaviorAsync/OnAuditAsync.md)(…) |  |
| virtual [OnBeforeSaveAsync](BaseSaveBehaviorAsync/OnBeforeSaveAsync.md)(…) |  |
| virtual [OnException](BaseSaveBehaviorAsync/OnException.md)(…) |  |
| virtual [OnPrepareQueryAsync](BaseSaveBehaviorAsync/OnPrepareQueryAsync.md)(…) |  |
| virtual [OnReturnAsync](BaseSaveBehaviorAsync/OnReturnAsync.md)(…) |  |
| virtual [OnSetInternalFieldsAsync](BaseSaveBehaviorAsync/OnSetInternalFieldsAsync.md)(…) |  |
| virtual [OnValidateRequestAsync](BaseSaveBehaviorAsync/OnValidateRequestAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseSaveBehaviorAsync](BaseSaveBehaviorAsync/BaseSaveBehaviorAsync.md)() | The default constructor. |

## See Also

* interface [ISaveBehaviorAsync](ISaveBehaviorAsync.md)
* interface [ISaveExceptionBehavior](ISaveExceptionBehavior.md)
* **Source:** *[BaseSaveBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/Save/BaseSaveBehaviorAsync.cs)*