# Alias indexer (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets the prefixed expression with the specified field.

```csharp
public string this[IField field] { get; }
```

| parameter | description |
| --- | --- |
| field | The field. |

## Return Value

Expression like t0.fieldName

## Property Value

The String.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | field |

## See Also

* interface [IField](../IField.md)
* class [Alias](../Alias.md)

---

# Alias indexer (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Gets the prefixed expression with the specified field name.

```csharp
public string this[string fieldName] { get; }
```

| parameter | description |
| --- | --- |
| fieldName | Name of the field. |

## Return Value

Expression like t0.fieldName

## Property Value

The String.

## See Also

* class [Alias](../Alias.md)