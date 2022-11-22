# DeleteResponse.WasAlreadyDeleted field
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

True if the entity was already deleted. Not all services support this. Only soft delete services may return this information, while others may raise a record not found exception.

```csharp
public bool WasAlreadyDeleted;
```

## See Also

* class [DeleteResponse](../DeleteResponse.md)