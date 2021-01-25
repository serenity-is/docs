# IFieldWithJoinInfo interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Interface for a field with join and referenced join alias information

```csharp
public interface IFieldWithJoinInfo : IField
```

## Members

| name | description |
| --- | --- |
| [Joins](IFieldWithJoinInfo/Joins.md) { get; } | List of all joins in fields entity |
| [ReferencedAliases](IFieldWithJoinInfo/ReferencedAliases.md) { get; } | List of referenced joins in field expression |

## See Also

* interface [IField](../Serenity.Net.Data/IField.md)
* **Source:** *[IFieldWithJoinInfo.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Contracts/IFieldWithJoinInfo.cs)*