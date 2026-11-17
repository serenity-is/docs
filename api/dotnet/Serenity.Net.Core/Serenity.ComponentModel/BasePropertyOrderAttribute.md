# BasePropertyOrderAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Orders the properties a type inherits from its base types relative to the ones it declares itself in its property items, instead of the order the types are declared in their assembly, which doesn't tell which of a type and its base type comes first. A type hierarchy where none of the types has this attribute keeps the declaration order. The order of the properties declared in the same type is always their declaration order.

All its parts are optional, and each type of a hierarchy that has it applies it to its own base types:

* [`Position`](./BasePropertyOrderAttribute/Position.md) places the properties of all the base types before, or after, the ones of the type.
* [`TypesBefore`](./BasePropertyOrderAttribute/TypesBefore.md) and [`TypesAfter`](./BasePropertyOrderAttribute/TypesAfter.md) place the properties of the listed base types before or after the ones of the type, in the order of the lists, which wins over what a base type asks for itself.
* [`WhenInherited`](./BasePropertyOrderAttribute/WhenInherited.md) is for the type itself: its properties are placed first or last in any type that inherits it, e.g. the audit properties of a base type, unless that type lists it.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class BasePropertyOrderAttribute : Attribute
```

| parameter | description |
| --- | --- |
| position | Where the properties of the base types are placed, relative to the ones of the type. |

## Public Members

| name | description |
| --- | --- |
| [BasePropertyOrderAttribute](BasePropertyOrderAttribute/BasePropertyOrderAttribute.md)(…) | Orders the properties a type inherits from its base types relative to the ones it declares itself in its property items, instead of the order the types are declared in their assembly, which doesn't tell which of a type and its base type comes first. A type hierarchy where none of the types has this attribute keeps the declaration order. The order of the properties declared in the same type is always their declaration order. |
| [Position](BasePropertyOrderAttribute/Position.md) { get; set; } | Gets or sets where the properties of the base types of the type are placed, relative to the ones of the type. The default is before. The ones of the types in [`TypesBefore`](./BasePropertyOrderAttribute/TypesBefore.md) and [`TypesAfter`](./BasePropertyOrderAttribute/TypesAfter.md), and the ones of the base types that are placed by [`WhenInherited`](./BasePropertyOrderAttribute/WhenInherited.md), are not placed by this. |
| [TypesAfter](BasePropertyOrderAttribute/TypesAfter.md) { get; set; } | Gets or sets the base types whose properties are placed after the ones of the type, in this order, and after the properties of the other base types. A type that is not a base type is ignored. |
| [TypesBefore](BasePropertyOrderAttribute/TypesBefore.md) { get; set; } | Gets or sets the base types whose properties are placed before the ones of the type, in this order, and before the properties of the other base types. A type that is not a base type is ignored. |
| [WhenInherited](BasePropertyOrderAttribute/WhenInherited.md) { get; set; } | Gets or sets where the properties of the type are placed in a type that inherits it, instead of the position that type gives its base types, which is Default. Before is before all the other properties, and After is after all of them, unless the inheriting type lists it. |

## Examples

```csharp
[BasePropertyOrder(WhenInherited = BasePropertyPosition.After)]
public abstract class AuditOptions { /* CreatedBy, ... */ }                // always after the others

[BasePropertyOrder(Position = BasePropertyPosition.After)]
public abstract class DatasetOptions : TitleOptions { /* Dataset, ... */ }  // Dataset, ..., then Title, ...

public class ChartOptions : DatasetOptions { /* ChartType, ... */ }         // Dataset, ..., Title, ..., ChartType, ...

[BasePropertyOrder(TypesBefore = [typeof(AuditOptions)])]
public class OtherOptions : AuditOptions { /* ... */ }                      // Audit first, as it is listed
```

## See Also

* **Source:** *[BasePropertyOrderAttribute.cs](https://github.com/serenity-is/Serenity/blob/99f11d8c2de6e1c3f73119b9a1b641e132f84e8d/src/core/ComponentModel/PropertyGrid/BasePropertyOrderAttribute.cs)*