# RowJsonConverter.ShouldSerializeExtension property

Should serialize extension. Returns the local hook if any is set through [`SetLocalShouldSerializeExtension`](./SetLocalShouldSerializeExtension.md), otherwise the default hook. The local hook should be used for unit tests.

```csharp
public static Func<IRow, string, bool>? ShouldSerializeExtension { get; set; }
```

## See Also

* interface [IRow](../../Serenity.Data/IRow.md)
* class [RowJsonConverter](../RowJsonConverter.md)