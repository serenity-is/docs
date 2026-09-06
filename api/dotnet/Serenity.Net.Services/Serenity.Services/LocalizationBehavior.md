# LocalizationBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior for handling localizable rows / properties.

```csharp
public class LocalizationBehavior : BaseSaveDeleteBehaviorAsync, IDeleteBehaviorSync, 
    IImplicitBehavior, IRetrieveBehaviorAsync, IRetrieveBehaviorSync, ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [LocalizationBehavior](LocalizationBehavior/LocalizationBehavior.md)(…) | Behavior for handling localizable rows / properties. |
| [ActivateFor](LocalizationBehavior/ActivateFor.md)(…) |  |
| virtual [OnAfterSave](LocalizationBehavior/OnAfterSave.md)(…) |  |
| override [OnAfterSaveAsync](LocalizationBehavior/OnAfterSaveAsync.md)(…) |  |
| virtual [OnBeforeDelete](LocalizationBehavior/OnBeforeDelete.md)(…) |  |
| override [OnBeforeDeleteAsync](LocalizationBehavior/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnReturn](LocalizationBehavior/OnReturn.md)(…) |  |
| virtual [OnReturnAsync](LocalizationBehavior/OnReturnAsync.md)(…) |  |
| static [GetLocalizationMatch](LocalizationBehavior/GetLocalizationMatch.md)(…) | Gets localization match for a field |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handlerFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveDeleteBehaviorAsync](BaseSaveDeleteBehaviorAsync.md)
* interface [IDeleteBehaviorSync](IDeleteBehaviorSync.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* interface [IRetrieveBehaviorAsync](IRetrieveBehaviorAsync.md)
* interface [IRetrieveBehaviorSync](IRetrieveBehaviorSync.md)
* interface [ISaveBehaviorSync](ISaveBehaviorSync.md)
* **Source:** *[LocalizationBehavior.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/IntegratedFeatures/Localization/LocalizationBehavior.cs)*