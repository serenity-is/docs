# EnumLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains initialization methods for adding local text translations defined by DescriptionAttribute attributes in enumeration classes.

```csharp
public static class EnumLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddEnumTexts](EnumLocalTextRegistration/AddEnumTexts.md)(…) | Adds local text translations defined implicitly by DescriptionAttribute attributes in enumeration classes. Only enum values that have a DescriptionAttribute are added as local text. By default, enums are registered in the format "Enums.{EnumerationTypeFullName}.{EnumValueName}", where EnumerationTypeFullName is the full name of the enumeration type. This can be overridden by attaching an [`EnumKeyAttribute`](../Serenity.ComponentModel/EnumKeyAttribute.md). |

## See Also

* **Source:** *[EnumLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Localization/EnumLocalTextRegistration.cs)*