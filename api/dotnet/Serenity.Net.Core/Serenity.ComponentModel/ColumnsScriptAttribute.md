# ColumnsScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this type should generate a columns script, which contains information about properties in this type and is an array of PropertyItem objects. Column scripts can be accessed from client side using Q.getColumns("Key")

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class ColumnsScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ColumnsScriptAttribute](ColumnsScriptAttribute/ColumnsScriptAttribute.md)() | Initializes a new instance of the [`FormScriptAttribute`](FormScriptAttribute.md) class. The key of the form script will be the full name of the type this is placed on. |
| [ColumnsScriptAttribute](ColumnsScriptAttribute/ColumnsScriptAttribute.md)(…) | Initializes a new instance of the [`ColumnsScriptAttribute`](ColumnsScriptAttribute.md) class. |
| [Key](ColumnsScriptAttribute/Key.md) { get; } | Gets the key. |
| [LocalTextPrefix](ColumnsScriptAttribute/LocalTextPrefix.md) { get; } | If set, modifies the local text prefix that should be used instead of the automatically calculated one from Key and Namespace |

## See Also

* **Source:** *[ColumnsScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/ColumnsScriptAttribute.cs)*