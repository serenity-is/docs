# CustomEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base attribute class that all other custom editor types derive from.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class CustomEditorAttribute : EditorTypeAttribute
```

| parameter | description |
| --- | --- |
| editorType | Type of the editor. |

## Public Members

| name | description |
| --- | --- |
| override [SetParams](CustomEditorAttribute/SetParams.md)(…) | Sets the parameters for each pair in the editorParams dictionary. |

## Protected Members

| name | description |
| --- | --- |
| [CustomEditorAttribute](CustomEditorAttribute/CustomEditorAttribute.md)(…) | Base attribute class that all other custom editor types derive from. |
| [GetOption&lt;TType&gt;](CustomEditorAttribute/GetOption.md)(…) | Gets the editor option. |
| [SetOption](CustomEditorAttribute/SetOption.md)(…) | Sets the editor option. |

## Remarks

Initializes a new instance of the [`CustomEditorAttribute`](CustomEditorAttribute.md) class.

## See Also

* class [EditorTypeAttribute](EditorTypeAttribute.md)
* **Source:** *[CustomEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/Editing/CustomEditorAttribute.cs)*