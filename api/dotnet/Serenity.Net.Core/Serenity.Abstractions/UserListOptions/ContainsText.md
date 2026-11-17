# UserListOptions.ContainsText property

Gets or sets a text that the username or the display name of the users should contain. The username is compared the way the users are looked up by it, which is by its normalized form when the application keeps one, and the display name the way the database compares text, so it is case insensitive with the usual collations. All users match when it is blank.

```csharp
public string? ContainsText { get; set; }
```

## See Also

* class [UserListOptions](../UserListOptions.md)