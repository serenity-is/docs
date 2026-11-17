# StringEnumMember.IsVisible property

Gets whether the member is sent to the client, i.e. it is not hidden with [`IgnoreUIFieldAttribute`](../../Serenity.ComponentModel/IgnoreUIFieldAttribute.md) or [`TransformIgnoreAttribute`](../../Serenity.ComponentModel/TransformIgnoreAttribute.md). The server still accepts and displays hidden members, as they are values like a system assigned status that a UI never edits.

```csharp
public bool IsVisible { get; }
```

## See Also

* class [StringEnumMember](../StringEnumMember.md)