# TableNameAttribute constructor (1 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`TableNameAttribute`](../TableNameAttribute.md) class.

```csharp
public TableNameAttribute(string name)
```

| parameter | description |
| --- | --- |
| name | The name. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name |

## See Also

* class [TableNameAttribute](../TableNameAttribute.md)

---

# TableNameAttribute constructor (2 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`TableNameAttribute`](../TableNameAttribute.md) class.

```csharp
public TableNameAttribute(string name, params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| name | The name. |
| serverTypes | Dialects like MySql, Sqlite. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [TableNameAttribute](../TableNameAttribute.md)