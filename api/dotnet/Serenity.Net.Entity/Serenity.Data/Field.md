# Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

```csharp
public abstract class Field : IFieldWithJoinInfo
```

## Public Members

| name | description |
| --- | --- |
| [AutoTextKey](Field/AutoTextKey.md) { get; } |  |
| [Caption](Field/Caption.md) { get; set; } |  |
| [ColumnAlias](Field/ColumnAlias.md) { get; } |  |
| [Criteria](Field/Criteria.md) { get; } |  |
| [CustomAttributes](Field/CustomAttributes.md) { get; set; } |  |
| [DefaultValue](Field/DefaultValue.md) { get; set; } |  |
| [Expression](Field/Expression.md) { get; set; } |  |
| [Fields](Field/Fields.md) { get; } |  |
| [Flags](Field/Flags.md) { get; set; } |  |
| [ForeignField](Field/ForeignField.md) { get; set; } |  |
| [ForeignJoinAlias](Field/ForeignJoinAlias.md) { get; set; } |  |
| [ForeignTable](Field/ForeignTable.md) { get; set; } |  |
| [Index](Field/Index.md) { get; } |  |
| [InsertPermission](Field/InsertPermission.md) { get; set; } |  |
| [Join](Field/Join.md) { get; } |  |
| [JoinAlias](Field/JoinAlias.md) { get; } |  |
| [MinSelectLevel](Field/MinSelectLevel.md) { get; set; } |  |
| [Name](Field/Name.md) { get; } |  |
| [NaturalOrder](Field/NaturalOrder.md) { get; set; } |  |
| [Origin](Field/Origin.md) { get; } |  |
| [PropertyName](Field/PropertyName.md) { get; set; } |  |
| [ReadPermission](Field/ReadPermission.md) { get; set; } |  |
| [ReferencedAliases](Field/ReferencedAliases.md) { get; set; } |  |
| [Scale](Field/Scale.md) { get; set; } |  |
| [Size](Field/Size.md) { get; } |  |
| [TextualField](Field/TextualField.md) { get; set; } |  |
| [Type](Field/Type.md) { get; } |  |
| [UpdatePermission](Field/UpdatePermission.md) { get; set; } |  |
| abstract [ValueType](Field/ValueType.md) { get; } |  |
| abstract [AsObject](Field/AsObject.md)(…) |  (2 methods) |
| virtual [AsSqlValue](Field/AsSqlValue.md)(…) |  |
| [Contains](Field/Contains.md)(…) |  |
| abstract [ConvertValue](Field/ConvertValue.md)(…) |  |
| abstract [Copy](Field/Copy.md)(…) |  |
| [CopyNoAssignment](Field/CopyNoAssignment.md)(…) |  |
| [EndsWith](Field/EndsWith.md)(…) |  |
| override [Equals](Field/Equals.md)(…) |  |
| [ForeignJoin](Field/ForeignJoin.md)(…) |  |
| abstract [GetFromReader](Field/GetFromReader.md)(…) |  |
| override [GetHashCode](Field/GetHashCode.md)() |  |
| [GetTitle](Field/GetTitle.md)(…) |  |
| [In&lt;T&gt;](Field/In.md)(…) |  |
| abstract [IndexCompare](Field/IndexCompare.md)(…) |  |
| [IsNotNull](Field/IsNotNull.md)() |  |
| [IsNull](Field/IsNull.md)() |  |
| [IsNull](Field/IsNull.md)(…) |  |
| [Like](Field/Like.md)(…) |  |
| [NotContains](Field/NotContains.md)(…) |  |
| [NotIn&lt;T&gt;](Field/NotIn.md)(…) |  |
| [NotLike](Field/NotLike.md)(…) |  |
| [StartsWith](Field/StartsWith.md)(…) |  |
| override [ToString](Field/ToString.md)() |  |
| abstract [ValueFromJson](Field/ValueFromJson.md)(…) |  |
| abstract [ValueToJson](Field/ValueToJson.md)(…) |  |
| [operator ==](Field/op_Equality.md) |  (10 operators) |
| [operator &gt;](Field/op_GreaterThan.md) |  (10 operators) |
| [operator &gt;=](Field/op_GreaterThanOrEqual.md) |  (10 operators) |
| [operator !=](Field/op_Inequality.md) |  (10 operators) |
| [operator &lt;](Field/op_LessThan.md) |  (10 operators) |
| [operator &lt;=](Field/op_LessThanOrEqual.md) |  (10 operators) |

## Protected Members

| name | description |
| --- | --- |
| [Field](Field/Field.md)(…) |  |
| [CheckUnassignedRead](Field/CheckUnassignedRead.md)(…) |  |
| abstract [GetIsNull](Field/GetIsNull.md)(…) |  |
| [JsonUnexpectedToken](Field/JsonUnexpectedToken.md)(…) |  |
| virtual [OnRowInitialization](Field/OnRowInitialization.md)() |  |

## See Also

* interface [IFieldWithJoinInfo](IFieldWithJoinInfo.md)
* **Source:** *[Field.CriteriaOperators.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/Field.CriteriaOperators.cs)*