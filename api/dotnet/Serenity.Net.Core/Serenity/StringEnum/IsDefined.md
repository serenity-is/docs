# StringEnum.IsDefined method (1 of 2)

Gets whether the given value is one of the members of the string enumeration.

```csharp
public static bool IsDefined(Type stringEnumType, string? value)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |
| value | The string value. |

## Return Value

True if the value is in the set.

## See Also

* class [StringEnum](../StringEnum.md)

---

# StringEnum.IsDefined&lt;TStringEnum&gt; method (2 of 2)

Gets whether the given value is one of the members of the string enumeration.

```csharp
public static bool IsDefined<TStringEnum>(string? value)
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |
| value | The string value. |

## Return Value

True if the value is in the set.

## See Also

* class [StringEnum](../StringEnum.md)