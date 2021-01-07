# Sql.Sum method (1 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a SUM() expression

```csharp
public static string Sum(IField field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty |

## See Also

* interface [IField](../IField.md)
* class [Sql](../Sql.md)

---

# Sql.Sum method (2 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a SUM() expression

```csharp
public static string Sum(string field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Sum method (3 of 3)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a SUM() expression.

```csharp
public static string Sum(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)