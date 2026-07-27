# FileReadAccessAttribute.Permission property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Permission to check for file read access. Use "*" for public/unrestricted, "?" for any logged in user, or a specific permission key. If using LogicOperatorPermissionService, permission can also be a logical expression like A&#x7C;B&amp;!C.

```csharp
public string Permission { get; protected internal set; }
```

## See Also

* class [FileReadAccessAttribute](../FileReadAccessAttribute.md)