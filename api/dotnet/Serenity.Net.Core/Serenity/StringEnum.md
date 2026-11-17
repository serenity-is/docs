# StringEnum class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for string enumerations, which are classes having public constant string fields as their members, an alternative to numeric enums for sets of values that are stored and sent to the client as strings. Only the members declared on the type are part of its set, which is what the server typings generator emits.

```csharp
public abstract class StringEnum
```

## Public Members

| name | description |
| --- | --- |
| static [GetInfo](StringEnum/GetInfo.md)(…) | Gets the cached information for a string enumeration type. |
| static [GetInfo&lt;TStringEnum&gt;](StringEnum/GetInfo.md)() | Gets the cached information for a string enumeration type. |
| static [GetName](StringEnum/GetName.md)(…) | Gets the name of the member with the given value. |
| static [GetName&lt;TStringEnum&gt;](StringEnum/GetName.md)(…) | Gets the name of the member with the given value. |
| static [GetNames](StringEnum/GetNames.md)(…) | Gets the names of all the members in their declaration order, including the members hidden from the client. |
| static [GetNames&lt;TStringEnum&gt;](StringEnum/GetNames.md)() | Gets the names of all the members in their declaration order, including the members hidden from the client. |
| static [GetText](StringEnum/GetText.md)(…) | Gets the display text of the member with the given value, using the `Enums.<EnumKey>.<Name>` local text key, like a numeric enum. |
| static [GetText&lt;TStringEnum&gt;](StringEnum/GetText.md)(…) | Gets the display text of the member with the given value, using the `Enums.<EnumKey>.<Name>` local text key, like a numeric enum. |
| static [GetValue](StringEnum/GetValue.md)(…) | Gets the string value of the member with the given name. |
| static [GetValue&lt;TStringEnum&gt;](StringEnum/GetValue.md)(…) | Gets the string value of the member with the given name. |
| static [GetValues](StringEnum/GetValues.md)(…) | Gets the string values of all the members in their declaration order, including the members hidden from the client. Like Type), which knows every member of an enum. |
| static [GetValues&lt;TStringEnum&gt;](StringEnum/GetValues.md)() | Gets the string values of all the members in their declaration order, including the members hidden from the client. |
| static [IsDefined](StringEnum/IsDefined.md)(…) | Gets whether the given value is one of the members of the string enumeration. |
| static [IsDefined&lt;TStringEnum&gt;](StringEnum/IsDefined.md)(…) | Gets whether the given value is one of the members of the string enumeration. |
| static [IsStringEnum](StringEnum/IsStringEnum.md)(…) | Gets whether the given type is a string enumeration type. |

## Protected Members

| name | description |
| --- | --- |
| [StringEnum](StringEnum/StringEnum.md)() | The default constructor. |

## Examples

```csharp
[EnumKey("MyApp.WidgetCategory")]
public abstract class WidgetCategory : StringEnum
{
    [Description("Charts")]
    public const string Charts = "charts";
    public const string Tables = "tables";
}
```

## See Also

* **Source:** *[StringEnum.cs](https://github.com/serenity-is/Serenity/blob/a75b99310ca194a360f1da1b131f539fd279c957/src/core/StringEnum/StringEnum.cs)*