# ISaveRequest.IgnoreConcurrencyVersion property

Gets or sets a value indicating whether the concurrency version check should be skipped for this save request. This is a server side only option and is ignored in client JSON, intended for internal services that need to update a row regardless of its version.

```csharp
public bool IgnoreConcurrencyVersion { get; set; }
```

## See Also

* interface [ISaveRequest](../ISaveRequest.md)