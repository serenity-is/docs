# FormScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this type should generate a form script, which contains information about properties in this type and is an array of PropertyItem objects. Form scripts can be accessed from client side using Q.getForm("Key")

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class FormScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FormScriptAttribute](FormScriptAttribute/FormScriptAttribute.md)() | Initializes a new instance of the [`FormScriptAttribute`](FormScriptAttribute.md) class. The key of the form script will be the full name of the type this is placed on. |
| [FormScriptAttribute](FormScriptAttribute/FormScriptAttribute.md)(…) | Initializes a new instance of the [`FormScriptAttribute`](FormScriptAttribute.md) class. |
| [Key](FormScriptAttribute/Key.md) { get; } | Gets the key. |

## See Also

* **Source:** *[FormScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/FormScriptAttribute.cs)*