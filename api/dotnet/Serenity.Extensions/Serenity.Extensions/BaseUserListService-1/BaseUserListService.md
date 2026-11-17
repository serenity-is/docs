# BaseUserListService&lt;TRow&gt; constructor

Base user list service that lists the users from their rows. The username is the name field of the row, and the display name, email and active state are read from it when it has IDisplayNameRow, IEmailRow and IIsActiveRow. Only these fields are selected, so nothing like the password hash is loaded.

```csharp
protected BaseUserListService(ISqlConnections sqlConnections)
```

| parameter | description |
| --- | --- |
| TRow | User row type |
| sqlConnections | SQL connections |

## See Also

* interface [ISqlConnections](../../../Serenity.Net.Services/Serenity.Data/ISqlConnections.md)
* class [BaseUserListService&lt;TRow&gt;](../BaseUserListService-1.md)