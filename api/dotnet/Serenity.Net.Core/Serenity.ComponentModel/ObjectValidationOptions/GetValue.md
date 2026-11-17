# ObjectValidationOptions.GetValue property

Gets or sets how the value of a property is read, e.g. from the fields of a row, by its name. The values are read from the properties of the object when it is not set, and a property the object doesn't have is not checked.

```csharp
public Func<string, object?>? GetValue { get; set; }
```

## See Also

* class [ObjectValidationOptions](../ObjectValidationOptions.md)