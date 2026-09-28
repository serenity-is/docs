# UserEntityOptions.TableName property

Gets or sets the user table name. When not explicitly set, the name comes from the user row's [`TableNameAttribute`](../../Serenity.Data.Mapping/TableNameAttribute.md); if no row type or attribute is available, it defaults to "Users".

```csharp
public string TableName { get; set; }
```

## See Also

* class [UserEntityOptions](../UserEntityOptions.md)