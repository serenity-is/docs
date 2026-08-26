# Reflection

Serenity has a small set of reflection-related types in the `Serenity.Reflection` namespace. Most of them are **internal extension points** — you'll rarely use them directly, but they're worth knowing about because they power the property item system, annotation types, and the code generator.

## `IPropertyInfo`

[IPropertyInfo](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/IPropertyInfo.md) virtualizes property attribute access. Instead of working with a raw `PropertyInfo`, code can ask for attributes through this interface, which lets the framework merge attributes from multiple sources (see `AttributeOrigin` below):

```cs
public interface IPropertyInfo
{
    string Name { get; }
    Type PropertyType { get; }
    TAttr? GetAttribute<TAttr>(AttributeOrigin origin = AttributeOrigin.All) where TAttr : Attribute;
    IEnumerable<TAttr> GetAttributes<TAttr>(AttributeOrigin origin = AttributeOrigin.All) where TAttr : Attribute;
}
```

## `WrappedProperty`

[WrappedProperty](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/WrappedProperty.md) is the default implementation of `IPropertyInfo` that wraps a `PropertyInfo`. It caches the property's attributes and supports the `AttributeOrigin` filtering.

## `AttributeOrigin`

[AttributeOrigin](../api/dotnet/Serenity.Net.Core/Serenity/AttributeOrigin.md) is a flags enum that controls where attributes are searched from when calling `IPropertyInfo.GetAttribute` / `GetAttributes`:

| Flag | Meaning |
| --- | --- |
| `Explicit` | Only attributes directly declared on the property |
| `Inherit` | Attributes inherited from base classes or interfaces |
| `Intrinsic` | Attributes provided by an `IIntrinsicPropertyAttributeProvider` |
| `Annotation` | Attributes derived from annotation types (`[AnnotationType]`) |
| `BasedOnField` | Attributes from the row field the property is based on (via `[BasedOnRow]`) |
| `All` | Combination of `Inherit`, `Intrinsic`, `Annotation`, and `BasedOnField` |
| `ExcludeInherit` | `Intrinsic` + `Annotation` + `BasedOnField` (no inherited) |
| `ExcludeBasedOnField` | `Inherit` + `Intrinsic` + `Annotation` (no based-on-field) |

This is how the property item providers combine attributes from a row, its annotation types, and its based-on field into a single view. See [Annotation Types](annotation-types.md) and [Grid Columns](grid-columns.md).

## `CodeWriter`

[CodeWriter](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/CodeWriter.md) writes formatted code to a `StringBuilder` with indentation support (`IncreaseIndent`, `DecreaseIndent`, `Block`). It's used internally by the code generator (`sergen`) to emit generated C#/TypeScript code.

## See Also

- [Annotation Types](data-access/annotation-types.md)
- [Grid Columns](grid-columns.md)
- [Forms & Editors](forms-editors.md)
- [Script Generation](dynamic-scripts/script-generation.md)