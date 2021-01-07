# CustomEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base attribute class that all other custom editor types derives from.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class CustomEditorAttribute : EditorTypeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [CustomEditorAttribute](CustomEditorAttribute/CustomEditorAttribute.md)(…) | Initializes a new instance of the [`CustomEditorAttribute`](CustomEditorAttribute.md) class. |
| override [SetParams](CustomEditorAttribute/SetParams.md)(…) | Sets the parameters for each pair in the editorParams dictionary. |

## Protected Members

| name | description |
| --- | --- |
| [GetOption&lt;TType&gt;](CustomEditorAttribute/GetOption.md)(…) | Gets the editor option. |
| [SetOption](CustomEditorAttribute/SetOption.md)(…) | Sets the editor option. |

## See Also

* class [EditorTypeAttribute](EditorTypeAttribute.md)
* **Source:** *[CustomEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/Editing/CustomEditorAttribute.cs)*