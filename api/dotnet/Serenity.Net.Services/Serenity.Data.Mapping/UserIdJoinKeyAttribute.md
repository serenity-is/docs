# UserIdJoinKeyAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Declares that the the join key (ForeignKeyAttribute) for this property should be based on [`UserEntityOptions`](../Serenity.Data/UserEntityOptions.md), e.g. use its TableName and IdColumnName properties.

```csharp
[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class UserIdJoinKeyAttribute : ForeignKeyAttribute
```

## Public Members

| name | description |
| --- | --- |
| [UserIdJoinKeyAttribute](UserIdJoinKeyAttribute/UserIdJoinKeyAttribute.md)() | Declares that the the join key (ForeignKeyAttribute) for this property should be based on [`UserEntityOptions`](../Serenity.Data/UserEntityOptions.md), e.g. use its TableName and IdColumnName properties. |

## See Also

* class [ForeignKeyAttribute](./ForeignKeyAttribute.md)
* **Source:** *[UserIdJoinKeyAttribute.cs](https://github.com/serenity-is/Serenity/blob/946b4765d8a337deec82c919259aeeb4b626bd6f/src/services/Data/Mapping/UserIdJoinKeyAttribute.cs)*