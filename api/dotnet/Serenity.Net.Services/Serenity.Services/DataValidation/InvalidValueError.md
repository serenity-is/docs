# DataValidation.InvalidValueError method (1 of 2)

Returns an invalid value error.

```csharp
public static ValidationError InvalidValueError(Field field, object value, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| field | Field |
| value | Value |
| localizer | Text localizer |

## Return Value

The invalid value error.

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.InvalidValueError method (2 of 2)

Returns an invalid value error.

```csharp
public static ValidationError InvalidValueError(IRow row, Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| field | Field |
| localizer | Text localizer |

## Return Value

The invalid value error.

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* interface [IRow](../../Serenity.Data/IRow.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)