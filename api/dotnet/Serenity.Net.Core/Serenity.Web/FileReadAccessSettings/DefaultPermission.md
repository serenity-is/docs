# FileReadAccessSettings.DefaultPermission property

Permission to check when no FileReadAccess attribute is present, or its PermissionOnly is true but no permission is specified. Default is "*" for compat, e.g. allow access to anyone that have access to the entity.

```csharp
public string? DefaultPermission { get; set; }
```

## See Also

* class [FileReadAccessSettings](../FileReadAccessSettings.md)