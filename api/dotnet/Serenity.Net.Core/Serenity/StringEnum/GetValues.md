# StringEnum.GetValues method (1 of 2)

Gets the string values of all the members in their declaration order, including the members hidden from the client. Like Type), which knows every member of an enum.

```csharp
public static IReadOnlyList<string> GetValues(Type stringEnumType)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |

## Return Value

The values of the members.

## See Also

* class [StringEnum](../StringEnum.md)

---

# StringEnum.GetValues&lt;TStringEnum&gt; method (2 of 2)

Gets the string values of all the members in their declaration order, including the members hidden from the client.

```csharp
public static IReadOnlyList<string> GetValues<TStringEnum>()
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |

## Return Value

The values of the members.

## See Also

* class [StringEnum](../StringEnum.md)