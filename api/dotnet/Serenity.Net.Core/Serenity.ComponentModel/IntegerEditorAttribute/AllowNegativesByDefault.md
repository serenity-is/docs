# IntegerEditorAttribute.AllowNegativesByDefault property

Gets or sets a value indicating whether editors should allow negatives by default. This is a global setting that controls the default of the AllowNegatives property in this attribute. Returns the local value if any is set through [`SetLocalAllowNegativesByDefault`](./SetLocalAllowNegativesByDefault.md), otherwise the default value. The local value should be used for unit tests.

```csharp
public static bool AllowNegativesByDefault { get; set; }
```

## Property Value

`true` if editors should allow negatives by default; otherwise, `false`.

## See Also

* class [IntegerEditorAttribute](../IntegerEditorAttribute.md)