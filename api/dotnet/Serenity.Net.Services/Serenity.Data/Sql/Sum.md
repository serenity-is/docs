# Sql.Sum method (1 of 3)

Creates a SUM() expression.

```csharp
public static string Sum(IField field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The SUM() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null. |

## See Also

* interface [IField](../IField.md)
* class [Sql](../Sql.md)

---

# Sql.Sum method (2 of 3)

Creates a SUM() expression.

```csharp
public static string Sum(string field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The SUM() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Sum method (3 of 3)

Creates a SUM() expression.

```csharp
public static string Sum(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Return Value

The SUM() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)