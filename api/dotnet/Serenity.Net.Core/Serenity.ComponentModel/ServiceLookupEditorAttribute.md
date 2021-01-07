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
| static [AutoServiceFor](ServiceLookupEditorAttribute/AutoServiceFor.md)(…) | When service is null, this method tries to determine the service by looking at the type this attribute is placed on. This is a combination of module identifier and type name. If type has a [Module] attribute it is used, otherwise module identifier is determined from namespace, by removing ".Entities", ".Scripts", ".Lookups" common suffixes and the root namespace (e.g. the first part of namespace before the first dot). Type name is determined from class type name, with common suffixes like "Row" or "Lookup" removed. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* class [ServiceLookupEditorBaseAttribute](ServiceLookupEditorBaseAttribute.md)
* **Source:** *[ServiceLookupEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/EditorTypes/ServiceLookupEditorAttribute.cs)*