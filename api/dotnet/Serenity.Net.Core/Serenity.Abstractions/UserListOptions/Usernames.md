# UserListOptions.Usernames property

Gets or sets the usernames of the users to list, e.g. to show their display names. They are compared the way the users are looked up by their usernames, so the case is ignored when the application does so. Only these users are listed when it is set, whether they are active or not, as they are asked for by who they are. It is no restriction when it is null, and an empty list lists nobody. If [`UserIds`](./UserIds.md) is set too, the users of either are listed.

```csharp
public IEnumerable<string>? Usernames { get; set; }
```

## See Also

* class [UserListOptions](../UserListOptions.md)