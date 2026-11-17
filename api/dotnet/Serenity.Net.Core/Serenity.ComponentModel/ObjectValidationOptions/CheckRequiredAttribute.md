# ObjectValidationOptions.CheckRequiredAttribute property

Gets or sets whether the [`RequiredAttribute`](../RequiredAttribute.md)s of the properties are checked, which is the default, while their [`RequiredWhenAttribute`](../RequiredWhenAttribute.md)s always are. They are not for a row, as a required field of a row is one that is not null in the database, which is checked otherwise, and its attribute only makes a field required in the forms.

```csharp
public bool CheckRequiredAttribute { get; set; }
```

## See Also

* class [ObjectValidationOptions](../ObjectValidationOptions.md)