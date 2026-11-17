# ValidateUrlAttribute constructor

Requires a text to be an absolute http, https or ftp address with a host, which the forms also check. It is stricter than UrlAttribute, which only checks how the text starts, and can not be derived from. Like it, it is a DataTypeAttribute of Url, which tools like OpenAPI read. An empty value is valid, as being required is [`RequiredAttribute`](../RequiredAttribute.md)'s concern.

```csharp
public ValidateUrlAttribute()
```

## See Also

* class [ValidateUrlAttribute](../ValidateUrlAttribute.md)