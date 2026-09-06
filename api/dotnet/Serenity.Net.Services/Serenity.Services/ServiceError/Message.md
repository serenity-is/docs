# ServiceError.Message property

The error message. In non-development mode the message might be something generic like "some error occurred" if the error itself is not a ValidationError. The detailed error can be seen in exception log.

```csharp
public string Message { get; set; }
```

## See Also

* class [ServiceError](../ServiceError.md)