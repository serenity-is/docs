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

* interface [IField](IField.md)
* **Source:** *[IFieldWithJoinInfo.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/Contracts/IFieldWithJoinInfo.cs)*