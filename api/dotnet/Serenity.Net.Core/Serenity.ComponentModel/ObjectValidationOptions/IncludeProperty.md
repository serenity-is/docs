# ObjectValidationOptions.IncludeProperty property

Gets or sets which properties are checked, e.g. only the ones an update has, by their names. All are checked when it is not set. The ones that are not checked are still read for the conditions of the others.

```csharp
public Func<string, bool>? IncludeProperty { get; set; }
```

## See Also

* class [ObjectValidationOptions](../ObjectValidationOptions.md)