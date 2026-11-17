# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetFieldValidations method

Gets the assigned fields that have validation rules, with their rules and the context to check them in.

```csharp
protected IEnumerable<(Field Field, List<ValidationAttribute> Rules, ValidationContext Context)> 
    GetFieldValidations()
```

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)