# ValidateEmailAttribute constructor

Requires a text to be an email address, by [`Pattern`](./Pattern.md), which is stricter than EmailAddressAttribute, as that only checks for an @ that is not the first or the last character, and can not be derived from. Like it, it is a DataTypeAttribute of EmailAddress, which tools like OpenAPI read. The forms also check it. An empty value is valid, as being required is [`RequiredAttribute`](../RequiredAttribute.md)'s concern.

```csharp
public ValidateEmailAttribute()
```

## See Also

* class [ValidateEmailAttribute](../ValidateEmailAttribute.md)