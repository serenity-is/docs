# BasePropertyOrderAttribute constructor

Orders the properties a type inherits from its base types relative to the ones it declares itself in its property items, instead of the order the types are declared in their assembly, which doesn't tell which of a type and its base type comes first. A type hierarchy where none of the types has this attribute keeps the declaration order. The order of the properties declared in the same type is always their declaration order.

All its parts are optional, and each type of a hierarchy that has it applies it to its own base types:

* [`Position`](./Position.md) places the properties of all the base types before, or after, the ones of the type.
* [`TypesBefore`](./TypesBefore.md) and [`TypesAfter`](./TypesAfter.md) place the properties of the listed base types before or after the ones of the type, in the order of the lists, which wins over what a base type asks for itself.
* [`WhenInherited`](./WhenInherited.md) is for the type itself: its properties are placed first or last in any type that inherits it, e.g. the audit properties of a base type, unless that type lists it.

```csharp
public BasePropertyOrderAttribute(BasePropertyPosition position = BasePropertyPosition.Default)
```

| parameter | description |
| --- | --- |
| position | Where the properties of the base types are placed, relative to the ones of the type. |

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

* enum [BasePropertyPosition](../BasePropertyPosition.md)
* class [BasePropertyOrderAttribute](../BasePropertyOrderAttribute.md)