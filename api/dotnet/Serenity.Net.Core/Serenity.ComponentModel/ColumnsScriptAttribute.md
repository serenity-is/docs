# ColumnsScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this type should generate a columns script, which contains information about properties in this type and is an array of PropertyItem objects. Column scripts can be accessed from the client side using Serenity.getColumns("Key").

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class ColumnsScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ColumnsScriptAttribute](ColumnsScriptAttribute/ColumnsScriptAttribute.md)() | Initializes a new instance of the [`ColumnsScriptAttribute`](./ColumnsScriptAttribute.md) class. The key of the columns script will be the full name of the type this is placed on. |
| [ColumnsScriptAttribute](ColumnsScriptAttribute/ColumnsScriptAttribute.md)(…) | Initializes a new instance of the [`ColumnsScriptAttribute`](./ColumnsScriptAttribute.md) class. |
| [InferKey](ColumnsScriptAttribute/InferKey.md) { get; set; } | Indicates whether the key should be inferred automatically from the type name, module name and namespace. |
| [Key](ColumnsScriptAttribute/Key.md) { get; } | Gets the key. If no key is set, and InferKey is true, the key will be inferred automatically from the type name, module name and namespace. If InferKey is false, the key is full type name of the type this attribute is placed on. |
| [LocalTextPrefix](ColumnsScriptAttribute/LocalTextPrefix.md) { get; set; } | If set, modifies the local text prefix that should be used instead of the automatically calculated one from Key and Namespace |
| static [AutoColumnsKeyFor](ColumnsScriptAttribute/AutoColumnsKeyFor.md)(…) | Gets the automatically inferred columns key for the specified type. |

## See Also

* **Source:** *[ColumnsScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/1ae08f36779a1f22f8f4600e4e68d4a9c8a89382/src/core/ComponentModel/Extensibility/ColumnsScriptAttribute.cs)*