# DeleteResponse.WasAlreadyDeleted property

True if the entity was already deleted. Not all services support this. Only soft delete services may return this information, while others may raise a record not found exception.

```csharp
public bool WasAlreadyDeleted { get; set; }
```

## See Also

* class [DeleteResponse](../DeleteResponse.md)