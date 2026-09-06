# UserPreferenceRepository.Update method

Updates or deletes a user preference.

```csharp
public SaveResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
```

| parameter | description |
| --- | --- |
| uow | The unit of work. |
| request | The update request. |

## Return Value

The save response.

## See Also

* class [SaveResponse](../../../Serenity.Net.Services/Serenity.Services/SaveResponse.md)
* interface [IUnitOfWork](../../../Serenity.Net.Services/Serenity.Data/IUnitOfWork.md)
* class [UserPreferenceUpdateRequest](../../Serenity.Extensions/UserPreferenceUpdateRequest.md)
* class [UserPreferenceRepository](../UserPreferenceRepository.md)