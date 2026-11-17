# StringEnum.GetText method (1 of 2)

Gets the display text of the member with the given value, using the `Enums.<EnumKey>.<Name>` local text key, like a numeric enum.

```csharp
public static string GetText(Type stringEnumType, string? value, ITextLocalizer? localizer = null)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |
| value | The string value. |
| localizer | The text localizer. |

## Return Value

The display text of the member, or the value itself if it is not in the set.

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)
* class [StringEnum](../StringEnum.md)

---

# StringEnum.GetText&lt;TStringEnum&gt; method (2 of 2)

Gets the display text of the member with the given value, using the `Enums.<EnumKey>.<Name>` local text key, like a numeric enum.

```csharp
public static string GetText<TStringEnum>(string? value, ITextLocalizer? localizer = null)
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |
| value | The string value. |
| localizer | The text localizer. |

## Return Value

The display text of the member, or the value itself if it is not in the set.

## See Also

* interface [ITextLocalizer](../ITextLocalizer.md)
* class [StringEnum](../StringEnum.md)