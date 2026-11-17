# StringEnum.GetNames method (1 of 2)

Gets the names of all the members in their declaration order, including the members hidden from the client.

```csharp
public static IReadOnlyList<string> GetNames(Type stringEnumType)
```

| parameter | description |
| --- | --- |
| stringEnumType | The string enumeration type. |

## Return Value

The names of the members.

## See Also

* class [StringEnum](../StringEnum.md)

---

# StringEnum.GetNames&lt;TStringEnum&gt; method (2 of 2)

Gets the names of all the members in their declaration order, including the members hidden from the client.

```csharp
public static IReadOnlyList<string> GetNames<TStringEnum>()
    where TStringEnum : StringEnum
```

| parameter | description |
| --- | --- |
| TStringEnum | The string enumeration type. |

## Return Value

The names of the members.

## See Also

* class [StringEnum](../StringEnum.md)