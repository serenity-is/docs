# LocalizationBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior for handling localizable rows / properties

```csharp
public class LocalizationBehavior : BaseSaveDeleteBehavior, IImplicitBehavior, IRetrieveBehavior
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [LocalizationBehavior](LocalizationBehavior/LocalizationBehavior.md)(…) | Behavior for handling localizable rows / properties |
| [ActivateFor](LocalizationBehavior/ActivateFor.md)(…) |  |
| [OnAfterExecuteQuery](LocalizationBehavior/OnAfterExecuteQuery.md)(…) |  |
| override [OnAfterSave](LocalizationBehavior/OnAfterSave.md)(…) |  |
| override [OnBeforeDelete](LocalizationBehavior/OnBeforeDelete.md)(…) |  |
| [OnBeforeExecuteQuery](LocalizationBehavior/OnBeforeExecuteQuery.md)(…) |  |
| [OnPrepareQuery](LocalizationBehavior/OnPrepareQuery.md)(…) |  |
| [OnReturn](LocalizationBehavior/OnReturn.md)(…) |  |
| [OnValidateRequest](LocalizationBehavior/OnValidateRequest.md)(…) |  |
| static [GetLocalizationMatch](LocalizationBehavior/GetLocalizationMatch.md)(…) | Gets localization match for a field |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | handlerFactory is null |

## Remarks

Creates an instance of the class

## See Also

* class [BaseSaveDeleteBehavior](BaseSaveDeleteBehavior.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* interface [IRetrieveBehavior](IRetrieveBehavior.md)
* **Source:** *[LocalizationBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/Localization/LocalizationBehavior.cs)*