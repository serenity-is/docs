# LookupScriptAttribute.AutoLookupKeyFor method
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

When lookup key is null, e.g. default constructor is used, this method tries to determine the lookup key by looking at the type this attribute is placed on. This is a combination of module identifier and type name. If type has a [Module] attribute it is used, otherwise module identifier is determined from namespace, by removing ".Entities", ".Scripts", ".Lookups" common suffixes and the root namespace (e.g. the first part of namespace before the first dot). Type name is determined from class type name, with common suffixes like "Row" or "Lookup" removed.

```csharp
public static string AutoLookupKeyFor(Type type)
```

| parameter | description |
| --- | --- |
| type | Type to generate a lookup key for |

## Return Value

Auto generated lookup key

## See Also

* class [LookupScriptAttribute](../LookupScriptAttribute.md)