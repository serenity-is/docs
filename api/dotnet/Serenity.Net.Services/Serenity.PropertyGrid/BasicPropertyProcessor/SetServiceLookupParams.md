# BasicPropertyProcessor.SetServiceLookupParams method

Sets the options of a service lookup editor that its attribute doesn't give, like the service, the id, text and icon fields, the capabilities, and the columns to include, as they are for a property with the attribute. It does nothing for other attributes. Options that are already in the dictionary are left as they are.

```csharp
public static void SetServiceLookupParams(EditorTypeAttribute? editorTypeAttr, 
    Dictionary<string, object?> editorParams)
```

| parameter | description |
| --- | --- |
| editorTypeAttr | The editor attribute, e.g. a ServiceLookupEditorAttribute with an item type. |
| editorParams | The options of the editor to add to. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The attribute is a plain service lookup editor attribute, and the id or text field can't be determined. |

## See Also

* class [EditorTypeAttribute](../../../Serenity.Net.Core/Serenity.ComponentModel/EditorTypeAttribute.md)
* class [BasicPropertyProcessor](../BasicPropertyProcessor.md)