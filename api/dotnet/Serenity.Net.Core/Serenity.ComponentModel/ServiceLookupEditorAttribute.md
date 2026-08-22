# ServiceLookupEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "ServiceLookup" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ServiceLookupEditorAttribute : ServiceLookupEditorBaseAttribute
```

## Public Members

| name | description |
| --- | --- |
| [ServiceLookupEditorAttribute](ServiceLookupEditorAttribute/ServiceLookupEditorAttribute.md)(…) | Initializes a new instance of the [`ServiceLookupEditorAttribute`](ServiceLookupEditorAttribute.md) class. (2 constructors) |
| const [Key](ServiceLookupEditorAttribute/Key.md) | Editor type key |
| static [AutoServiceFor](ServiceLookupEditorAttribute/AutoServiceFor.md)(…) | When service is null, this method tries to determine the service by looking at the type this attribute is placed on. This is a combination of module identifier and type name. If the type has a [Module] attribute, it is used, otherwise the module identifier is determined from the namespace, by removing ".Entities", ".Scripts", ".Lookups" common suffixes and the root namespace (e.g. the first part of the namespace before the first dot). Type name is determined from the class type name, with common suffixes like "Row" or "Lookup" removed. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* class [ServiceLookupEditorBaseAttribute](ServiceLookupEditorBaseAttribute.md)
* **Source:** *[ServiceLookupEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/EditorTypes/ServiceLookupEditorAttribute.cs)*