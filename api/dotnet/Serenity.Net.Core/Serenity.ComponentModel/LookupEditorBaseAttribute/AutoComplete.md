# LookupEditorBaseAttribute.AutoComplete property

Allows dynamically creating new options from text input by the user in the search box. This option should only be used for free text inputs, not ID / Text pairs. When this option is enabled, InplaceAdd cannot be used. A newly created option will have the same ID / Text as the user-entered text.

```csharp
public bool AutoComplete { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)