# Criteria constructor (1 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new criteria that contains field name of the metafield.

```csharp
public Criteria(IField field)
```

| parameter | description |
| --- | --- |
| field | Field (required). |

## See Also

* interface [IField](../IField.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (2 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing a query's string representation.

```csharp
public Criteria(ISqlQuery query)
```

| parameter | description |
| --- | --- |
| query | The query. |

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (3 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new criteria with given condition. This condition is usually a field name, but it can also be a criteria text pre-generated.

```csharp
public Criteria(string expression)
```

| parameter | description |
| --- | --- |
| expression | A field name or criteria condition (can be null) |

## Remarks

Usually used like: `new Criteria("fieldname") >= 5`.

## See Also

* class [Criteria](../Criteria.md)

---

# Criteria constructor (4 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "alias.field".

```csharp
public Criteria(IAlias alias, IField field)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| field | The field. |

## See Also

* interface [IAlias](../IAlias.md)
* interface [IField](../IField.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (5 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "alias.field".

```csharp
public Criteria(IAlias alias, string field)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| field | The field. |

## See Also

* interface [IAlias](../IAlias.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (6 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "tjoinNumber.field"

```csharp
public Criteria(int joinNumber, IField field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## See Also

* interface [IField](../IField.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (7 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "tjoinnumber.field" (t7.field).

```csharp
public Criteria(int joinNumber, string field)
```

| parameter | description |
| --- | --- |
| joinNumber | The join number. |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field is null or empty |
| ArgumentOutOfRangeException | joinNumber is less than zero |

## See Also

* class [Criteria](../Criteria.md)

---

# Criteria constructor (8 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "join.field".

```csharp
public Criteria(string join, IField field)
```

| parameter | description |
| --- | --- |
| join | The join. |
| field | The field. |

## See Also

* interface [IField](../IField.md)
* class [Criteria](../Criteria.md)

---

# Criteria constructor (9 of 9)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`Criteria`](../Criteria.md) class containing an expression like "alias.field".

```csharp
public Criteria(string alias, string field)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| field | The field. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Field or alias is null or empty string. |

## See Also

* class [Criteria](../Criteria.md)