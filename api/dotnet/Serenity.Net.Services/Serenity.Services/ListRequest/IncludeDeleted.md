# ListRequest.IncludeDeleted property

Include the deleted records. Default is false. This is only supported by services and entities that implement soft delete, e.g. IsActive etc. The value is ignored unless the current user has the undelete permission (UndeletePermissionAttribute, falling back to delete, modify and read permissions).

```csharp
public bool IncludeDeleted { get; set; }
```

## See Also

* class [ListRequest](../ListRequest.md)