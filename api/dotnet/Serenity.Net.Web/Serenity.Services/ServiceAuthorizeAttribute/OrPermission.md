# ServiceAuthorizeAttribute.OrPermission property

Gets or sets an optional secondary permission to check by OR, e.g. if this is specified and the user does not have the [`Permission`](./Permission.md), the user will still be allowed access if they have the `OrPermission`.

```csharp
protected string OrPermission { get; set; }
```

## See Also

* class [ServiceAuthorizeAttribute](../ServiceAuthorizeAttribute.md)