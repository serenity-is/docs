# Sql.Count method (1 of 4)

Returns COUNT(*).

```csharp
public static string Count()
```

## Return Value

COUNT(*).

## See Also

* class [Sql](../Sql.md)

---

# Sql.Count method (2 of 4)

Creates a COUNT() expression.

```csharp
public static string Count(IField field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The COUNT() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null. |

## See Also

* interface [IField](../IField.md)
* class [Sql](../Sql.md)

---

# Sql.Count method (3 of 4)

Creates a COUNT() expression.

```csharp
public static string Count(string field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

The COUNT() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)

---

# Sql.Count method (4 of 4)

Creates a COUNT() expression.

```csharp
public static string Count(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Return Value

The COUNT() expression.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty. |

## See Also

* class [Sql](../Sql.md)