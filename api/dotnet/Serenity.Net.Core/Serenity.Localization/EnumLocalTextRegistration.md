# EnumLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains initialization method for adding local text translations defined by Description attributes in enumeration classes.

```csharp
public static class EnumLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddEnumTexts](EnumLocalTextRegistration/AddEnumTexts.md)(…) | Adds local text translations defined implicitly by Description attributes in enumeration classes. Only enum values that has Description attribute are added as local text. By default, enums are registered in format: "Enums.{EnumerationTypeFullName}.{EnumValueName}". EnumerationTypeFullName, is fullname of the enumeration type. This can be overridden by attaching a EnumKey attribute. |

## See Also

* **Source:** *[EnumLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/EnumLocalTextRegistration.cs)*