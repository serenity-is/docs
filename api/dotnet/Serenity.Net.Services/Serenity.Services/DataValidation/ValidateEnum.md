# DataValidation.ValidateEnum method (1 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates enum is within allowed values, e.g. one its members

```csharp
public static void ValidateEnum(IRow row, Field field, Type enumType, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| field | Field |
| enumType | Enum type |
| localizer | Text localizer |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.ValidateEnum&lt;T&gt; method (2 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates enum is one of allowed values, e.g. one of its members

```csharp
public static void ValidateEnum<T>(T value, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| T | Enum type |
| value | Enum value |
| localizer | Text localizer |

## See Also

* class [T](../Serenity.Net.Services/../DataValidation.T.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.ValidateEnum&lt;T&gt; method (3 of 3)
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates enum is within allowed values, e.g. one of its members

```csharp
public static void ValidateEnum<T>(IRow row, GenericValueField<T> field, ITextLocalizer localizer)
    where T : struct, IComparable<T>
```

| parameter | description |
| --- | --- |
| T | Type of enum |
| row | Row instance |
| field | Field |
| localizer | Text localizer |

## See Also

* interface [IRow](../Serenity.Net.Entity/../../Serenity.Data/IRow.md)
* class [GenericValueField&lt;TValue&gt;](../Serenity.Net.Entity/../../Serenity.Data/GenericValueField-1.md)
* struct [T](../Serenity.Net.Services/../DataValidation.T.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)