# NestedPermissionKeysAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this class contains permission keys with optional subclasses that also contain permission keys.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class NestedPermissionKeysAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [NestedPermissionKeysAttribute](NestedPermissionKeysAttribute/NestedPermissionKeysAttribute.md)() | Initializes a new instance of the [`NestedPermissionKeysAttribute`](NestedPermissionKeysAttribute.md) class. |
| [LanguageID](NestedPermissionKeysAttribute/LanguageID.md) { get; set; } | Gets or sets the optional language identifier that specifies the language for texts specified in the [DisplayName] attribute. |

## See Also

* **Source:** *[NestedPermissionKeysAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Extensibility/NestedPermissionKeysAttribute.cs)*