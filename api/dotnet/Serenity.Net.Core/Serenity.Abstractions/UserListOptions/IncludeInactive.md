# UserListOptions.IncludeInactive property

Gets or sets whether to list the users that are disabled too, which is `false` by default. The users that are deleted are never listed, unless they are asked for with [`UserIds`](./UserIds.md) or [`Usernames`](./Usernames.md).

```csharp
public bool IncludeInactive { get; set; }
```

## See Also

* class [UserListOptions](../UserListOptions.md)