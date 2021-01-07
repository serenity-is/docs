# ServiceLookupEditorAttribute.AutoServiceFor method
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

When service is null, this method tries to determine the service by looking at the type this attribute is placed on. This is a combination of module identifier and type name. If type has a [Module] attribute it is used, otherwise module identifier is determined from namespace, by removing ".Entities", ".Scripts", ".Lookups" common suffixes and the root namespace (e.g. the first part of namespace before the first dot). Type name is determined from class type name, with common suffixes like "Row" or "Lookup" removed.

```csharp
public static string AutoServiceFor(Type type)
```

| parameter | description |
| --- | --- |
| type | Type to generate a service for |

## Return Value

Auto generated service

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)