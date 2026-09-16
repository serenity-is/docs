# DecimalEditorAttribute.AllowNegativesByDefault property

Gets or sets a value indicating whether to allow negatives by default. This is a global setting that controls if decimal editors should allow negative values unless specified otherwise. Returns the local value if any is set through [`SetLocalAllowNegativesByDefault`](./SetLocalAllowNegativesByDefault.md), otherwise the default value. The local value should be used for unit tests.

```csharp
public static bool AllowNegativesByDefault { get; set; }
```

## Property Value

`true` if negatives should be allowed by default; otherwise, `false`.

## See Also

* class [DecimalEditorAttribute](../DecimalEditorAttribute.md)