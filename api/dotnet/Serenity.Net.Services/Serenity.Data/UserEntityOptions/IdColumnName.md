# UserEntityOptions.IdColumnName property

Gets or sets the name of the user ID column. Assigning [`RowType`](./RowType.md) initializes this from the [IdProperty] property's [`ColumnAttribute`](../../Serenity.Data.Mapping/ColumnAttribute.md), or its property name when no column attribute exists. If no name is available, it defaults to "UserId".

```csharp
public string? IdColumnName { get; set; }
```

## See Also

* class [UserEntityOptions](../UserEntityOptions.md)