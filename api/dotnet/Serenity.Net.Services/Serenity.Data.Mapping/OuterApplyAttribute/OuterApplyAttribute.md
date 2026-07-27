# OuterApplyAttribute constructor (1 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds a OUTER APPLY to the row

```csharp
public OuterApplyAttribute(string alias, string innerQuery)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| innerQuery | The inner query. |

## Remarks

Initializes a new instance of the [`OuterApplyAttribute`](../OuterApplyAttribute.md) class.

## See Also

* interface [ISqlJoin](../ISqlJoin.md)
* class [OuterApplyAttribute](../OuterApplyAttribute.md)

---

# OuterApplyAttribute constructor (2 of 2)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the [`OuterApplyAttribute`](../OuterApplyAttribute.md) class.

```csharp
public OuterApplyAttribute(string alias, string innerQuery, params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| innerQuery | The inner query. |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [OuterApplyAttribute](../OuterApplyAttribute.md)