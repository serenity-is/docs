# UserEntityOptions.RowType property

Gets or sets the user row type. It must implement [`IRow`](../IRow.md) and have an [IdProperty] property. That property's type determines the user ID field type, while its [Column] and [Size] attributes provide the default ID column name and size. Its [TableName] attribute provides the default user table name. Set [`TableName`](./TableName.md) or [`IdColumnName`](./IdColumnName.md) to override those names. Other user column names are not configured by this option.

```csharp
public Type? RowType { get; set; }
```

## See Also

* class [UserEntityOptions](../UserEntityOptions.md)