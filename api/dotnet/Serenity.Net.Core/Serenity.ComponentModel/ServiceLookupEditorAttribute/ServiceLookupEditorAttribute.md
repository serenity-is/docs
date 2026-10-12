# ServiceLookupEditorAttribute constructor (1 of 3)

Initializes a new instance of the [`ServiceLookupEditorAttribute`](../ServiceLookupEditorAttribute.md) class for use by derived editor attributes.

```csharp
protected ServiceLookupEditorAttribute()
```

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)

---

# ServiceLookupEditorAttribute constructor (2 of 3)

Creates a new instance of the [`ServiceLookupEditorAttribute`](../ServiceLookupEditorAttribute.md) class with an item/row type. Service, ID, and text fields are inferred when possible. For non-row types, inference uses `[IdProperty]` and `[NameProperty]`, then conventional property names (Id/Key/Code/Value and Name/DisplayName/Text). A type with a single public string property uses that property for both ID and text. Otherwise, set [`IdField`](../ServiceLookupEditorBaseAttribute/IdField.md) and [`TextField`](../ServiceLookupEditorBaseAttribute/TextField.md) explicitly or annotate the corresponding item properties.

```csharp
public ServiceLookupEditorAttribute(Type itemType)
```

| parameter | description |
| --- | --- |
| itemType | The item/row type |

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)

---

# ServiceLookupEditorAttribute constructor (3 of 3)

Initializes a new instance of the [`ServiceLookupEditorAttribute`](../ServiceLookupEditorAttribute.md) class.

```csharp
public ServiceLookupEditorAttribute(string service, string idField, string textField)
```

| parameter | description |
| --- | --- |
| service | The service, e.g. Northwind/Customer/List. |
| idField | Id field. |
| textField | Text field. |

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)