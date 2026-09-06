# Sql.Max method (1 of 3)

Creates a MAX() expression.

```csharp
public static string Max(IField field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The MAX() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null. |

## See Also

* interface [IField](../IField.md)
* class [Sql](../Sql.md)

---

# Sql.Max method (2 of 3)

Creates a MAX() expression.

```csharp
public static string Max(string field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The MAX() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Max method (3 of 3)

Creates a MAX() expression.

```csharp
public static string Max(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Return Value

The MAX() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)