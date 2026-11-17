# StringEnum.GetName method (1 of 2)

Gets the name of the member with the given value.

```csharp
public static string? GetName(Type stringEnumType, string? value)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |
| value | The string value. |

## Return Value

The name of the member, or null if the value is not in the set.

## See Also

* class [StringEnum](../StringEnum.md)

---

# StringEnum.GetName&lt;TStringEnum&gt; method (2 of 2)

Gets the name of the member with the given value.

```csharp
public static string? GetName<TStringEnum>(string? value)
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |
| value | The string value. |

## Return Value

The name of the member, or null if the value is not in the set.

## See Also

* class [StringEnum](../StringEnum.md)