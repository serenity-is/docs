# StringEnum.GetValue method (1 of 2)

Gets the string value of the member with the given name.

```csharp
public static string? GetValue(Type stringEnumType, string? name)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |
| name | The member name. |

## Return Value

The value of the member, or null if there is no such member.

## See Also

* class [StringEnum](../StringEnum.md)

---

# StringEnum.GetValue&lt;TStringEnum&gt; method (2 of 2)

Gets the string value of the member with the given name.

```csharp
public static string? GetValue<TStringEnum>(string? name)
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |
| name | The member name. |

## Return Value

The value of the member, or null if there is no such member.

## See Also

* class [StringEnum](../StringEnum.md)