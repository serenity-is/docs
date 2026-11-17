# FormScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this type should generate a form script, which contains information about properties in this type and is an array of PropertyItem objects. Form scripts can be accessed from the client side using Serenity.getForm("Key").

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class FormScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FormScriptAttribute](FormScriptAttribute/FormScriptAttribute.md)() | Initializes a new instance of the [`FormScriptAttribute`](./FormScriptAttribute.md) class. The key of the form script will be the full name of the type this is placed on. |
| [FormScriptAttribute](FormScriptAttribute/FormScriptAttribute.md)(…) | Initializes a new instance of the [`FormScriptAttribute`](./FormScriptAttribute.md) class. |
| [InferKey](FormScriptAttribute/InferKey.md) { get; set; } | Indicates whether the key should be inferred automatically from the type name, module name and namespace. For compat, this defaults to false, resulting in using the full type name as the key. |
| [Key](FormScriptAttribute/Key.md) { get; } | Gets the key. If no key is set, and InferKey is true, the key will be inferred automatically from the type name, module name and namespace. If InferKey is false, the key is full type name of the type this attribute is placed on. |
| [LocalTextPrefix](FormScriptAttribute/LocalTextPrefix.md) { get; set; } | If set, modifies the local text prefix that should be used instead of the automatically calculated one from Key and Namespace |
| static [AutoFormKeyFor](FormScriptAttribute/AutoFormKeyFor.md)(…) | Gets the automatically inferred form key for the specified type. |

## See Also

* **Source:** *[FormScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/1ae08f36779a1f22f8f4600e4e68d4a9c8a89382/src/core/ComponentModel/Extensibility/FormScriptAttribute.cs)*