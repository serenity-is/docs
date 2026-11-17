# BasePropertyPosition enumeration
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Where properties declared in a type are placed, relative to the properties of another type.

```csharp
public enum BasePropertyPosition
```

## Values

| name | value | description |
| --- | --- | --- |
| Default | `0` | No preference, which is before for the properties of the base types of a type, and the position the type that inherits a type gives it for the properties of the type itself. |
| Before | `1` | Before the other properties. |
| After | `2` | After the other properties. |

## See Also

* class [BasePropertyOrderAttribute](./BasePropertyOrderAttribute.md)
* **Source:** *[BasePropertyPosition.cs](https://github.com/serenity-is/Serenity/blob/99f11d8c2de6e1c3f73119b9a1b641e132f84e8d/src/core/ComponentModel/PropertyGrid/BasePropertyPosition.cs)*