# ServiceLookupEditorAttribute constructor (1 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

If you use this constructor, service will tried to be determined by module and name of the row class, and idField and textField will be determined by rows id and name fields.

```csharp
public ServiceLookupEditorAttribute(Type itemType)
```

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)

---

# ServiceLookupEditorAttribute constructor (2 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

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