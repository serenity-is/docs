# ConcatAttribute.NullAsEmpty property
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

When true (default), NULLS values are assumed to be empty. This is done using the COALESCE operator for dialects that is necessary. SQLServer Concat() returns empty string even when all the arguments are null. Oracle only returns null when all the arguments are null.

```csharp
public bool NullAsEmpty { get; set; }
```

## See Also

* class [ConcatAttribute](../ConcatAttribute.md)