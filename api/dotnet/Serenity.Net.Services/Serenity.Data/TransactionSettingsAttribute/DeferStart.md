# TransactionSettingsAttribute.DeferStart property

Gets or sets whether the transaction start should be deferred if possible (generally until the connection property of the unit of work object is read). This might have undesired side effects, so use with care.

```csharp
public bool DeferStart { get; set; }
```

## See Also

* class [TransactionSettingsAttribute](../TransactionSettingsAttribute.md)