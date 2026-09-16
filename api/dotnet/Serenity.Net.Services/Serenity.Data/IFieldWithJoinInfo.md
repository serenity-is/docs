# IFieldWithJoinInfo interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for a field with join and referenced join alias information.

```csharp
public interface IFieldWithJoinInfo : IField
```

## Members

| name | description |
| --- | --- |
| [Joins](IFieldWithJoinInfo/Joins.md) { get; } | List of all joins in the field's entity. |
| [ReferencedAliases](IFieldWithJoinInfo/ReferencedAliases.md) { get; } | List of referenced joins in the field expression. |

## See Also

* interface [IField](./IField.md)
* **Source:** *[IFieldWithJoinInfo.cs](https://github.com/serenity-is/Serenity/blob/03d9544633af3a843d9921adc3e91fceec981ad4/src/services/Entity/Contracts/IFieldWithJoinInfo.cs)*