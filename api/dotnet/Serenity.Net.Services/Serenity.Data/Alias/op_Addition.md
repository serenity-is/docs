# Alias Addition operator (1 of 2)

Gets a criteria containing prefixed field. Only here for backward compatibility.

```csharp
public static string operator +(Alias alias, IField field)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| field | The field. |

## Return Value

String containing prefixed field.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null. |

## See Also

* interface [IField](../IField.md)
* class [Alias](../Alias.md)

---

# Alias Addition operator (2 of 2)

Gets a criteria containing prefixed field. Only here for backward compatibility.

```csharp
public static string operator +(Alias alias, string fieldName)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| fieldName | Name of the field. |

## Return Value

String containing prefixed field.

## See Also

* class [Alias](../Alias.md)