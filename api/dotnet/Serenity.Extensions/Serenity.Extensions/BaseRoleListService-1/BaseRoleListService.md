# BaseRoleListService&lt;TRow&gt; constructor

Base role list service that lists the roles from their rows. The name of a role is the name field of the row, and its key is read from it when it has [`IRoleKeyRow`](../IRoleKeyRow.md).

```csharp
protected BaseRoleListService(ISqlConnections sqlConnections)
```

| parameter | description |
| --- | --- |
| TRow | Role row type |
| sqlConnections | SQL connections |

## See Also

* interface [ISqlConnections](../../../Serenity.Net.Services/Serenity.Data/ISqlConnections.md)
* class [BaseRoleListService&lt;TRow&gt;](../BaseRoleListService-1.md)