# UserListOptions.UserIds property

Gets or sets the identifiers of the users to list, e.g. to show the usernames of the users that the records of another table refer to, which may be in another database, so they can't be joined. Only these users are listed when it is set, whether they are active or not, as they are asked for by who they are. The ones that are not found or are not valid identifiers are left out. It is no restriction when it is null, and an empty list lists nobody. If [`Usernames`](./Usernames.md) is set too, the users of either are listed.

```csharp
public IEnumerable<string>? UserIds { get; set; }
```

## See Also

* class [UserListOptions](../UserListOptions.md)