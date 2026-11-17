# StringEnumMember class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A member of a [`StringEnum`](./StringEnum.md), with its name, value and optional text information.

```csharp
public sealed class StringEnumMember
```

## Public Members

| name | description |
| --- | --- |
| [StringEnumMember](StringEnumMember/StringEnumMember.md)(…) | Initializes a new instance of the [`StringEnumMember`](./StringEnumMember.md) class. |
| [IsVisible](StringEnumMember/IsVisible.md) { get; } | Gets whether the member is sent to the client, i.e. it is not hidden with [`IgnoreUIFieldAttribute`](../Serenity.ComponentModel/IgnoreUIFieldAttribute.md) or [`TransformIgnoreAttribute`](../Serenity.ComponentModel/TransformIgnoreAttribute.md). The server still accepts and displays hidden members, as they are values like a system assigned status that a UI never edits. |
| [Name](StringEnumMember/Name.md) { get; } | Gets the name of the member, which is the name of its field. |
| [Text](StringEnumMember/Text.md) { get; } | Gets the invariant text of the member, if it has a text attribute. |
| [TextKey](StringEnumMember/TextKey.md) { get; } | Gets the local text key of the member, if it has a text attribute with a key. |
| [Value](StringEnumMember/Value.md) { get; } | Gets the string value of the member. |

## See Also

* **Source:** *[StringEnumMember.cs](https://github.com/serenity-is/Serenity/blob/a75b99310ca194a360f1da1b131f539fd279c957/src/core/StringEnum/StringEnumMember.cs)*