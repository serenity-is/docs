# Sql.Count method (1 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Returns COUNT(*)

```csharp
public static string Count()
```

## Return Value

COUNT(*)

## See Also

* class [Sql](../Sql.md)

---

# Sql.Count method (2 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a COUNT() expression

```csharp
public static string Count(IField field)
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

# Sql.Count method (3 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a COUNT() expression

```csharp
public static string Count(string field)
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

# Sql.Count method (4 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a COUNT() expression

```csharp
public static string Count(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty |

## See Also

* class [Sql](../Sql.md)