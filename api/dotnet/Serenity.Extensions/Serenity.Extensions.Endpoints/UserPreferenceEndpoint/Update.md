# UserPreferenceEndpoint.Update method
**namespace:** *[Serenity.Extensions.Endpoints](../../README.md#serenity.extensions.endpoints-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Updates or deletes a user preference.

```csharp
public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
```

| parameter | description |
| --- | --- |
| uow | The unit of work. |
| request | The update request. |

## Return Value

The save response.

## See Also

* class [ServiceResponse](../Serenity.Net.Services/../../Serenity.Services/ServiceResponse.md)
* interface [IUnitOfWork](../Serenity.Net.Services/../../Serenity.Data/IUnitOfWork.md)
* class [UserPreferenceUpdateRequest](../../Serenity.Extensions/UserPreferenceUpdateRequest.md)
* class [UserPreferenceEndpoint](../UserPreferenceEndpoint.md)