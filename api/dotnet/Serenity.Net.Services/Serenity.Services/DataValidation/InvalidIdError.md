# DataValidation.InvalidIdError method (1 of 2)

Returns an invalid ID error.

```csharp
public static ValidationError InvalidIdError(Field field, long value, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| field | Field |
| value | Value |
| localizer | Text localizer |

## Return Value

The invalid ID error.

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)

---

# DataValidation.InvalidIdError method (2 of 2)

Returns a Invalid ID error

```csharp
public static ValidationError InvalidIdError(IRow row, Field field, ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| row | Row instance |
| field | Field |
| localizer | Text localizer |

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* interface [IRow](../../Serenity.Data/IRow.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [DataValidation](../DataValidation.md)