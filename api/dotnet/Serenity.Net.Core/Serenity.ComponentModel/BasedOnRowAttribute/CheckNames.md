# BasedOnRowAttribute.CheckNames property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets or sets a value indicating whether to check names. If this is true (by default false), if a property name doesn't exactly match a property in the RowType row, Serenity will raise error. In that case you might add [IgnoreName] attribute to properties that shouldn't be checked.

```csharp
public bool CheckNames { get; set; }
```

## Property Value

`true` if should check names; otherwise, `false`.

## See Also

* class [BasedOnRowAttribute](../BasedOnRowAttribute.md)