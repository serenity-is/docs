# StringEnumField&lt;TStringEnum&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a string value that is one of the members of a StringEnum type. Like [`EnumField`](./EnumField-1.md), a value that is not one of the members is rejected while the value is deserialized from JSON, so it never reaches the row.

```csharp
public class StringEnumField<TStringEnum> : StringField, IEnumTypeField
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |

## Public Members

| name | description |
| --- | --- |
| [StringEnumField](StringEnumField-1/StringEnumField.md)(…) | Initializes a new instance of the [`StringEnumField`](./StringEnumField-1.md) class. |
| [EnumType](StringEnumField-1/EnumType.md) { get; set; } | Gets or sets the type of the string enumeration. It is *TStringEnum* by default, and no validation is performed when it is set to null, like Int32Field.EnumType. |

## Protected Members

| name | description |
| --- | --- |
| override [ConvertJsonValue](StringEnumField-1/ConvertJsonValue.md)(…) | Checks that the value read from JSON is one of the members of the string enumeration. An empty value is converted to null, like an empty string is for an enum field, so it is left to the required field validation. |

## Remarks

A value stored earlier that is no longer a member, e.g. a retired one, is rejected too when a row that has it is deserialized, as it is for numeric enums. Set [`EnumType`](./StringEnumField-1/EnumType.md) to null to skip the validation.

## See Also

* class [StringField](./StringField.md)
* interface [IEnumTypeField](./IEnumTypeField.md)
* class [StringEnum](../../Serenity.Net.Core/Serenity/StringEnum.md)
* **Source:** *[StringEnumField.cs](https://github.com/serenity-is/Serenity/blob/2dea051d74da64325a0cde1e9bd05bca3bc03280/src/services/Entity/FieldTypes/StringEnumField.cs)*