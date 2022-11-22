# Field class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base Field class

```csharp
public abstract class Field : IFieldWithJoinInfo
```

## Public Members

| name | description |
| --- | --- |
| [AutoTextKey](Field/AutoTextKey.md) { get; } | Gets the automatic text key. |
| [Caption](Field/Caption.md) { get; set; } | Gets or sets the caption. |
| [ColumnAlias](Field/ColumnAlias.md) { get; } | Select as column alias. Can be equal to property name or name. |
| [Criteria](Field/Criteria.md) { get; } | Gets the criteria. |
| [CustomAttributes](Field/CustomAttributes.md) { get; set; } | Gets or sets the custom attributes. |
| [DefaultValue](Field/DefaultValue.md) { get; set; } | Gets or sets the default value. |
| [Expression](Field/Expression.md) { get; set; } | The expression (can be equal to name if no expression) |
| [Fields](Field/Fields.md) { get; } | Gets the fields. |
| [Flags](Field/Flags.md) { get; set; } | Gets or sets the flags. |
| [ForeignField](Field/ForeignField.md) { get; set; } | Gets or sets the foreign field. |
| [ForeignJoinAlias](Field/ForeignJoinAlias.md) { get; set; } | Gets or sets the foreign join alias. |
| [ForeignTable](Field/ForeignTable.md) { get; set; } | Gets or sets the foreign table. |
| [Index](Field/Index.md) { get; } | Gets the index. |
| [InsertPermission](Field/InsertPermission.md) { get; set; } | Gets or sets the insert permission. |
| [IsLookup](Field/IsLookup.md) { get; } | Gets if this field is one with a LookupInclude attribute or ID or Name field |
| [Join](Field/Join.md) { get; } | Gets the join. |
| [JoinAlias](Field/JoinAlias.md) { get; } | Gets the join alias. |
| [MinSelectLevel](Field/MinSelectLevel.md) { get; set; } | Gets or sets the minimum select level. |
| [Name](Field/Name.md) { get; } | Column name |
| [NaturalOrder](Field/NaturalOrder.md) { get; set; } | Gets or sets the natural order. |
| [Origin](Field/Origin.md) { get; } | Gets the origin. |
| [PropertyName](Field/PropertyName.md) { get; set; } | Gets or sets the name of the property. |
| [ReadPermission](Field/ReadPermission.md) { get; set; } | Gets or sets the read permission. |
| [ReferencedAliases](Field/ReferencedAliases.md) { get; set; } | Gets or sets the referenced aliases. |
| [Scale](Field/Scale.md) { get; set; } | Gets or sets the scale. |
| [Size](Field/Size.md) { get; } | Gets the size. |
| [TextualField](Field/TextualField.md) { get; set; } | Gets or sets the textual field. |
| [Type](Field/Type.md) { get; } | Gets the type. |
| [UpdatePermission](Field/UpdatePermission.md) { get; set; } | Gets or sets the update permission. |
| abstract [ValueType](Field/ValueType.md) { get; } | Gets the type of the value. |
| abstract [AsObject](Field/AsObject.md)(…) | Gets the value of this row as an object. (2 methods) |
| virtual [AsSqlValue](Field/AsSqlValue.md)(…) | Gets the value of this row as an SQL value. |
| [Contains](Field/Contains.md)(…) | Creates a new "the Field CONTAINS mask" criteria |
| abstract [ConvertValue](Field/ConvertValue.md)(…) | Converts the value. |
| abstract [Copy](Field/Copy.md)(…) | Copies the specified source. |
| [CopyNoAssignment](Field/CopyNoAssignment.md)(…) | Copies the no assignment. |
| [EndsWith](Field/EndsWith.md)(…) | Creates a new "the Field ENDS WITH mask" criteria |
| override [Equals](Field/Equals.md)(…) | Determines whether the specified Object, is equal to this instance. |
| abstract [GetFromReader](Field/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [GetHashCode](Field/GetHashCode.md)() | Returns a hash code for this instance. |
| [GetTitle](Field/GetTitle.md)(…) | Gets the title. |
| [In&lt;T&gt;](Field/In.md)(…) | Creates a new "the Field IN (values...)" criteria |
| abstract [IndexCompare](Field/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| [IsNotNull](Field/IsNotNull.md)() | Creates a new "the Field IS NOT NULL" criteria |
| [IsNull](Field/IsNull.md)() | Creates a new "the Field IS NULL" criteria |
| [IsNull](Field/IsNull.md)(…) | Determines whether the specified row is null. |
| [Like](Field/Like.md)(…) | Creates a new "the Field LIKE mask" criteria |
| [NotContains](Field/NotContains.md)(…) | Creates a new "the Field NOT CONTAINS mask" criteria |
| [NotIn&lt;T&gt;](Field/NotIn.md)(…) | Creates a new "the Field NOT IN (values...)" criteria |
| [NotLike](Field/NotLike.md)(…) | Creates a new "the Field NOT LIKE mask" criteria |
| [StartsWith](Field/StartsWith.md)(…) | Creates a new "the Field STARTS WITH mask" criteria |
| override [ToString](Field/ToString.md)() | Converts to string. |
| abstract [ValueFromJson](Field/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| abstract [ValueToJson](Field/ValueToJson.md)(…) | Serializes this fields value to JSON |
| [operator ==](Field/op_Equality.md) | Implements the operator ==. (10 operators) |
| [operator &gt;](Field/op_GreaterThan.md) | Implements the operator &gt;. (10 operators) |
| [operator &gt;=](Field/op_GreaterThanOrEqual.md) | Implements the operator &gt;=. (10 operators) |
| [operator !=](Field/op_Inequality.md) | Implements the operator !=. (10 operators) |
| [operator &lt;](Field/op_LessThan.md) | Implements the operator &lt;. (10 operators) |
| [operator &lt;=](Field/op_LessThanOrEqual.md) | Implements the operator &lt;=. (10 operators) |

## Protected Members

| name | description |
| --- | --- |
| [Field](Field/Field.md)(…) | Initializes a new instance of the [`Field`](Field.md) class. |
| [CheckUnassignedRead](Field/CheckUnassignedRead.md)(…) | Checks the unassigned read. |
| abstract [GetIsNull](Field/GetIsNull.md)(…) | Gets if the field value is null. |
| [JsonUnexpectedToken](Field/JsonUnexpectedToken.md)(…) | Jsons the unexpected token. |
| virtual [OnRowInitialization](Field/OnRowInitialization.md)() | Called when [row initialization]. |

## See Also

* interface [IFieldWithJoinInfo](IFieldWithJoinInfo.md)
* **Source:** *[Field.CriteriaOperators.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/Field.CriteriaOperators.cs)*