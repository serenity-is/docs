# StringEnumInfo class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

The members and lookups of a [`StringEnum`](./StringEnum.md) type, which are built once for the type and cached by [`GetInfo`](./StringEnum/GetInfo.md).

```csharp
public sealed class StringEnumInfo
```

## Public Members

| name | description |
| --- | --- |
| [EnumKey](StringEnumInfo/EnumKey.md) { get; } | Gets the key of the string enumeration, which is its [`EnumKeyAttribute`](../Serenity.ComponentModel/EnumKeyAttribute.md) value, or its full name. |
| [Members](StringEnumInfo/Members.md) { get; } | Gets all the members in their declaration order, including the ones hidden from the client. |
| [Names](StringEnumInfo/Names.md) { get; } | Gets the names of all the members in their declaration order. |
| [Type](StringEnumInfo/Type.md) { get; } | Gets the string enumeration type. |
| [Values](StringEnumInfo/Values.md) { get; } | Gets the values of all the members in their declaration order. |
| [VisibleMembers](StringEnumInfo/VisibleMembers.md) { get; } | Gets the members that are sent to the client, in their declaration order. |
| [FindByName](StringEnumInfo/FindByName.md)(…) | Finds the member with the given name. |
| [FindByValue](StringEnumInfo/FindByValue.md)(…) | Finds the member with the given value. |

## Remarks

Only the members declared on the type itself are read, like the server typings generator, so a type deriving from another one has its own set. When two members have the same value, the one declared first is used, like the first icon of an alias in a numeric enum. All members are included, also the ones hidden from the client with [`IgnoreUIFieldAttribute`](../Serenity.ComponentModel/IgnoreUIFieldAttribute.md) or [`TransformIgnoreAttribute`](../Serenity.ComponentModel/TransformIgnoreAttribute.md), as the server accepts them; [`IsVisible`](./StringEnumMember/IsVisible.md) tells which ones are sent to the client.

## See Also

* **Source:** *[StringEnumInfo.cs](https://github.com/serenity-is/Serenity/blob/a75b99310ca194a360f1da1b131f539fd279c957/src/core/StringEnum/StringEnumInfo.cs)*