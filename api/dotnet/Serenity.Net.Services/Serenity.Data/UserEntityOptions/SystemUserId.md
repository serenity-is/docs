# UserEntityOptions.SystemUserId property

Gets or sets the ID of the user that rows created by the system, e.g. by migrations or sample data, are attributed to, like their `InsertUserId`. It should be the ID of an existing user, e.g. the admin user created by the initial migration.

```csharp
public object? SystemUserId { get; set; }
```

## Remarks

When not explicitly set, it defaults to `1` for [`Int32Field`](../Int32Field.md) and [`Int64Field`](../Int64Field.md) IDs, which is the ID of the first user in an identity column. There is no such default for [`GuidField`](../GuidField.md) and [`StringField`](../StringField.md) IDs, so it has to be set for them before running migrations that insert such rows, and its value should be of the ID type, e.g. a Guid.

## See Also

* class [UserEntityOptions](../UserEntityOptions.md)