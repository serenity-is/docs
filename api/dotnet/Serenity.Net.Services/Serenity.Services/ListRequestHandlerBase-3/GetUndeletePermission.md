# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.GetUndeletePermission method

Gets the permission required to undelete records of the current row type, e.g. UndeletePermissionAttribute, falling back to DeletePermissionAttribute, ModifyPermissionAttribute and ReadPermissionAttribute.

```csharp
protected virtual string GetUndeletePermission()
```

## See Also

* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)