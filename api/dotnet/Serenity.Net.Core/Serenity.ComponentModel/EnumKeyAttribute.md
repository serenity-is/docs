# EnumKeyAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets the enumeration key of an enum, or of a [`StringEnum`](../Serenity/StringEnum.md), which is used as the `Enums.<EnumKey>.<Name>` prefix of its member texts.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
public class EnumKeyAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [EnumKeyAttribute](EnumKeyAttribute/EnumKeyAttribute.md)() | Initializes a new instance of the [`EnumKeyAttribute`](./EnumKeyAttribute.md) class with the key inferred from module attribute, if available and namespace. |
| [EnumKeyAttribute](EnumKeyAttribute/EnumKeyAttribute.md)(…) | Initializes a new instance of the [`EnumKeyAttribute`](./EnumKeyAttribute.md) class with the specified key. |
| [InferKey](EnumKeyAttribute/InferKey.md) { get; } | Gets a value indicating whether the key should be inferred. |
| [Value](EnumKeyAttribute/Value.md) { get; } | Gets the enum key. |
| static [AutoEnumKeyFor](EnumKeyAttribute/AutoEnumKeyFor.md)(…) | Automatically generates an enum key for the specified type based on its module and name. |

## See Also

* **Source:** *[EnumKeyAttribute.cs](https://github.com/serenity-is/Serenity/blob/1ae08f36779a1f22f8f4600e4e68d4a9c8a89382/src/core/ComponentModel/Extensibility/EnumKeyAttribute.cs)*