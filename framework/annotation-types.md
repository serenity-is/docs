# Annotation Types

**Annotation types** let you move UI-related attributes (editor types, formatters, etc.) out of your entity/row classes into a separate class. This keeps your rows free of UI dependencies, so they can live in a plain class library that doesn't reference the UI layer.

## The Problem They Solve

Consider a row with UI attributes placed directly on its properties:

```cs
public sealed class OrderRow : Row<OrderRow.RowFields>, IIdRow
{
    [CustomerEditor]
    public string CustomerID { get; set; }

    [AsyncLookupEditor(typeof(EmployeeRow))]
    public int? EmployeeID { get; set; }
}
```

This works, but it couples the row to UI concepts (editors, lookups). If you want to move `OrderRow` into a separate entities-only class library, you'd have to drag those UI dependencies along with it.

**Annotation types** solve this by declaring the same attributes in a separate class that *annotates* the row:

```cs
namespace Serenity.Demo.Northwind.Annotations;

[AnnotationType(typeof(OrderRow))]
public sealed class OrderRowAnnotations
{
    [CustomerEditor]
    public string CustomerID { get; set; }

    [AsyncLookupEditor(typeof(EmployeeRow))]
    public int? EmployeeID { get; set; }

    [AsyncLookupEditor(typeof(ShipperRow))]
    public int? ShipVia { get; set; }
}
```

The annotation class has properties whose **names match** the row's properties, and carries the UI attributes for them. Serenity then treats those attributes as if they were on the row itself — for forms, columns, lookups, and the generated TypeScript typings — while the row stays clean.

This is the sample used by the Northwind demo (`OrderRowAnnotations`), and it's exactly the pattern you'd use to isolate a row into an entities-only library.

## The `[AnnotationType]` Attribute

[AnnotationTypeAttribute](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/AnnotationTypeAttribute.md) declares that a class is an annotation type for another type:

```cs
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class AnnotationTypeAttribute(Type type) : Attribute
{
    public Type AnnotatedType { get; private set; }
    public bool Inherited { get; set; } = true;
    public string[]? Namespaces { get; set; }
    public string[]? Properties { get; set; }
}
```

- `AnnotatedType` — the type to match. It can be:
  - a **concrete type** (e.g. `typeof(OrderRow)`),
  - an **interface** (the annotation applies to any type implementing it),
  - an **attribute type** (the annotation applies to any type that has that attribute).
- `Inherited` — whether subclasses of the annotated type also match (default `true`; ignored for attribute types).
- `Namespaces` — restrict the annotation to types in the given namespaces (a namespace ending in `.*` also matches sub-namespaces).
- `Properties` — the annotation only matches a type if it has all the listed property names.

The attribute is `AllowMultiple`, so one annotation class can annotate several types, and a type can have several annotation classes.

## The Registry

### `IAnnotationTypeRegistry`

[IAnnotationTypeRegistry](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/IAnnotationTypeRegistry.md) is the abstraction that answers "which annotation types apply to a given type?":

```cs
public interface IAnnotationTypeRegistry
{
    IEnumerable<Type> GetAnnotationTypesFor(Type type);
}
```

### `AnnotationTypeRegistry`

[AnnotationTypeRegistry](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/AnnotationTypeRegistry.md) is the default implementation. It discovers all types decorated with `[AnnotationType]` through the type source, and `GetAnnotationTypesFor(type)` returns the ones that match the given type according to the `AnnotatedType`, `Inherited`, `Namespaces`, and `Properties` rules above.

It is registered as a singleton by `AddEntities()` (called from `AddServiceHandlers` in `Startup.cs`):

```cs
services.TryAddSingleton<IAnnotationTypeRegistry, AnnotationTypeRegistry>();
```

## Reading Annotated Attributes

### `IAnnotatedType` and `AnnotationTypeExtensions`

Once you have the annotation types for a row, [AnnotationTypeExtensions](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/AnnotationTypeExtensions.md) provides `GetAnnotatedType()`, which returns an [IAnnotatedType](../api/dotnet/Serenity.Net.Core/Serenity.Reflection/IAnnotatedType.md):

```cs
public interface IAnnotatedType
{
    IPropertyInfo GetAnnotatedProperty(PropertyInfo property);
}
```

`GetAnnotatedProperty(property)` returns an `IPropertyInfo` that, when you ask for attributes, first checks the real property and then falls back to the matching annotation property. This is how the framework reads attributes from both the row and its annotation types as if they were one.

## Where Annotation Types Are Used

Annotation types are consumed automatically by the framework:

- **Property item providers** build form/column metadata from both the row and its annotation types.
- **Server typings generation** (`sergen`) includes annotation attributes when generating the TypeScript `Row`/`Form`/`Columns` typings.
- **Row fields providers** (`DefaultRowFieldsProvider`) consult the annotation registry when building row fields.

So once you declare an annotation type, the UI metadata flows through to forms, grids, and client typings without any extra wiring.

## Reducing Repetitive Attributes Across Similar Fields

Beyond isolating a single row's UI dependencies, annotation types are a great way to **apply the same set of attributes to a field that appears in many rows** — without repeating those attributes on every row.

Because an annotation type matches by **property name**, you can annotate a *kind* of field (e.g. any row that has a `BirthDate` property) and put all the shared attributes there once.

### Example: A `BirthDate` Field in Many Rows

Suppose several rows have a `BirthDate` property, and you always want the same editor and validation. Instead of repeating these attributes on every row:

```cs
// repeated on every row that has BirthDate
[DateTimeEditor]
[MinValue("1900-01-01")]
[MaxValue("2100-01-01")]
public DateTime? BirthDate { get; set; }
```

Define a single annotation type that matches any type having a `BirthDate` property, using the `Properties` option:

```cs
[AnnotationType(typeof(IRow), Properties = ["BirthDate"])]
public sealed class BirthDateAnnotations
{
    [DateTimeEditor]
    [MinValue("1900-01-01")]
    [MaxValue("2100-01-01")]
    public DateTime? BirthDate { get; set; }
}
```

Now every row that has a `BirthDate` property automatically gets the `DateTimeEditor`, `MinValue`, and `MaxValue` attributes — no repetition.

### Example: Audit/Log Fields

The same idea works for common log fields like `InsertDate`, `UpdateDate`, `InsertUserId`, `UpdateUserId`. You can set their formatter, `Insertable(false)`, `Updatable(false)`, etc. once, and every row with those fields inherits the settings:

```cs
[AnnotationType(typeof(IRow), Properties = ["InsertDate", "UpdateDate", "InsertUserId", "UpdateUserId"])]
public sealed class LogFieldAnnotations
{
    [DisplayFormat("G"), Insertable(false), Updatable(false)]
    public DateTime? InsertDate { get; set; }

    [DisplayFormat("G"), Insertable(false), Updatable(false)]
    public DateTime? UpdateDate { get; set; }

    [Hidden, Insertable(false), Updatable(false)]
    public int? InsertUserId { get; set; }

    [Hidden, Insertable(false), Updatable(false)]
    public int? UpdateUserId { get; set; }
}
```

### Matching by Interface or Attribute

You can also target a whole family of rows by matching an **interface** or an **attribute** rather than listing properties:

```cs
// applies to any row implementing ILoggingRow
[AnnotationType(typeof(ILoggingRow))]
public sealed class LoggingRowAnnotations
{
    // ... shared attributes for log fields
}
```

This is especially useful when all your log rows share a common interface, so you don't have to enumerate the property names.

> **Note:** When an annotation type matches by interface or attribute, its properties still apply by **name** — so the annotation property names must match the row's property names for the attributes to be picked up.

## When to Use Them

Use annotation types when you want to:

- **Isolate dependencies** — keep rows free of UI references so they can live in an entities-only class library.
- **Reduce repetitive code** — apply the same set of UI attributes to many rows via a shared annotation class (matched by interface or attribute).
- **Centralize UI metadata** — keep editor/formatter choices in one place rather than scattered across rows.

They're optional — you can always put attributes directly on the row — but they're the recommended way to separate UI concerns from your entity model.

## See Also

- [Entities (Rows)](data-access/entities.md)
- [Forms & Editors](attributes/attributes.md)
- [Dynamic Scripts](dynamic-scripts/readme.md)
