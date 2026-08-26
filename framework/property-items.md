# Property Items & Metadata

Serenity builds the metadata that drives forms and grids — the `PropertyItem[]` array — from the attributes on your row, form, and columns classes. This page explains how that metadata is produced, so you can understand and customize it.

## What a PropertyItem Is

A [`PropertyItem`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PropertyItem.md) is a JSON-serializable object describing one property of a form or grid: its name, title, editor/formatter type, width, visibility, permissions, etc. The client-side `@serenity-is` widgets consume these to render forms and grids without hard-coding the UI.

A set of property items is wrapped in a [`PropertyItemsData`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PropertyItemsData.md) object (`Items` + `AdditionalItems`), which is what the `ColumnsScript`/`FormScript` dynamic scripts emit (see [Dynamic Scripts](dynamic-scripts/readme.md)).

## The `IPropertyItemProvider`

[`IPropertyItemProvider`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertyItemProvider.md) is the abstraction that produces the `PropertyItem[]` for a given type:

```cs
public interface IPropertyItemProvider
{
    IEnumerable<PropertyItem> GetPropertyItemsFor(Type type, Func<PropertyInfo, bool> predicate = null);
}
```

The default implementation, [`DefaultPropertyItemProvider`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/DefaultPropertyItemProvider.md), is registered by `AddDynamicScripts()` (via `AddEntities()`). It:

1. Resolves the row the type is based on (from `[BasedOnRow]`, or the type itself if it's a row).
2. Discovers every `IPropertyProcessor` from the type source and orders them by `Priority`.
3. For each public property of the type, creates a `PropertyInfoSource` and runs it through every processor, which fills in the `PropertyItem` fields from the property's attributes.
4. Optionally validates property names against the row when `CheckNames = true` (throwing if a property doesn't match a field — see `[SkipNameCheck]`).

## Property Processors

[`IPropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertyProcessor.md) is the extension point that turns a property + its attributes into a `PropertyItem`. Each processor has a `Priority` (processors run in ascending order), and the lifecycle is:

- `Initialize()` — once per type, before any property is processed.
- `Process(source, item)` — for each property.
- `PostProcess()` — a secondary pass after all properties (used for cross-property logic).

[`PropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/PropertyProcessor.md) is the empty base class (default `Priority` 50).

### `BasicPropertyProcessor`

[`BasicPropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/BasicPropertyProcessor.md) is the built-in processor that handles the vast majority of attributes — title, category, editor type, formatter, width, alignment, visibility, permissions, insertable/updatable, required, filtering, sorting, etc. It's split into many partial files, one per concern (e.g. `BasicPropertyProcessor.Title`, `BasicPropertyProcessor.Editing`, `BasicPropertyProcessor.Filtering`).

## The Property Source

[`IPropertySource`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertySource.md) abstracts the input to a processor: the `PropertyInfo`, the `BasedOnField` (the row field a property maps to, if any), the value/enum types, and the reflected type. [`PropertyInfoSource`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/PropertyInfoSource.md) is the default implementation, wrapping a `PropertyInfo` and an optional based-on row.

## Customizing the Metadata

Because the metadata is built from attributes, most customization is declarative — add attributes to your row/form/columns class. When you need to go further:

- **Custom processor** — implement `IPropertyProcessor` (or derive from `PropertyProcessor`) and it's picked up automatically from the type source, running alongside `BasicPropertyProcessor`.
- **`ICustomizePropertyItems`** — a form/columns type can implement this to tweak the generated `PropertyItemsData` after processing (used by `PropertyItemsScript`).
- **`IPropertyItemProvider` replacement** — replace the default provider in DI if you need to change the whole pipeline.

## See Also

- [Grid Columns](grid-columns.md)
- [Forms & Editors](forms-editors.md)
- [Dynamic Scripts](dynamic-scripts/readme.md)
- [Annotation Types](annotation-types.md)
- API reference: [`IPropertyItemProvider`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertyItemProvider.md),
  [`DefaultPropertyItemProvider`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/DefaultPropertyItemProvider.md),
  [`IPropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertyProcessor.md),
  [`PropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/PropertyProcessor.md),
  [`BasicPropertyProcessor`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/BasicPropertyProcessor.md),
  [`IPropertySource`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/IPropertySource.md),
  [`PropertyInfoSource`](../api/dotnet/Serenity.Net.Services/Serenity.PropertyGrid/PropertyInfoSource.md),
  [`PropertyItem`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PropertyItem.md),
  [`PropertyItemsData`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/PropertyItemsData.md)