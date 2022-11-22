# LookupScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Placed on rows / or custom lookup classes to denote it has a lookup script. When placed on a row class, lookup scripts only transfer ID and Name fields by default to client side for security / performance reasons. Make sure you add [LookupInclude] attribute to properties you'll need to access from script.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class LookupScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [LookupScriptAttribute](LookupScriptAttribute/LookupScriptAttribute.md)() | Creates a LookupScriptAttribute with auto determined lookup key |
| [LookupScriptAttribute](LookupScriptAttribute/LookupScriptAttribute.md)(…) | Creates a LookupScriptAttribute. (2 constructors) |
| [Expiration](LookupScriptAttribute/Expiration.md) { get; set; } | Cache duration in seconds |
| [Key](LookupScriptAttribute/Key.md) { get; } | Lookup key, usually in "Module.EntityName" format. |
| [LookupType](LookupScriptAttribute/LookupType.md) { get; set; } | External lookup script type or base type that should be used for generating dynamic lookup script. Only meaningful for Row types with external lookup scripts. Can be a generic type of TRow or a simple lookup class. |
| [Permission](LookupScriptAttribute/Permission.md) { get; set; } | Permission key required to access this lookup script. Use special value "?" for all logged-in users. Use special value "*" for anyone including not logged-in users. |
| static [AutoLookupKeyFor](LookupScriptAttribute/AutoLookupKeyFor.md)(…) | When lookup key is null, e.g. default constructor is used, this method tries to determine the lookup key by looking at the type this attribute is placed on. This is a combination of module identifier and type name. If type has a [Module] attribute it is used, otherwise module identifier is determined from namespace, by removing ".Entities", ".Scripts", ".Lookups" common suffixes and the root namespace (e.g. the first part of namespace before the first dot). Type name is determined from class type name, with common suffixes like "Row" or "Lookup" removed. |

## See Also

* **Source:** *[LookupScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/LookupScriptAttribute.cs)*