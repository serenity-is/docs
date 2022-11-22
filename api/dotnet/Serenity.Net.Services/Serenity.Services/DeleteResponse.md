# DeleteResponse class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The response object returned from a delete service

```csharp
public class DeleteResponse : ServiceResponse
```

## Public Members

| name | description |
| --- | --- |
| [DeleteResponse](DeleteResponse/DeleteResponse.md)() | The default constructor. |
| [WasAlreadyDeleted](DeleteResponse/WasAlreadyDeleted.md) | True if the entity was already deleted. Not all services support this. Only soft delete services may return this information, while others may raise a record not found exception. |

## See Also

* class [ServiceResponse](ServiceResponse.md)
* **Source:** *[DeleteResponse.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/DeleteResponse.cs)*