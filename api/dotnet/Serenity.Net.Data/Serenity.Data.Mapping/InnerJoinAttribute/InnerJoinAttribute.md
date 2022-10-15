# InnerJoinAttribute constructor (1 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a inner join on foreign key. Use this version only on properties with ForeignKey attribute.

```csharp
public InnerJoinAttribute(string alias)
```

| parameter | description |
| --- | --- |
| alias | Foreign join alias |

## See Also

* class [InnerJoinAttribute](../InnerJoinAttribute.md)

---

# InnerJoinAttribute constructor (2 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a inner join on foreign key. Use this version only on properties with ForeignKey attribute.

```csharp
public InnerJoinAttribute(string alias, params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| alias | Foreign join alias |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [InnerJoinAttribute](../InnerJoinAttribute.md)

---

# InnerJoinAttribute constructor (3 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a inner join

```csharp
public InnerJoinAttribute(string alias, string toTable, string onCriteria)
```

| parameter | description |
| --- | --- |
| alias | Join alias |
| toTable | Join table |
| onCriteria | If the attribute is used on a property, this parameter is a field name, if used on a class, this parameter is the ON criteria of the inner join statement. |

## See Also

* class [InnerJoinAttribute](../InnerJoinAttribute.md)

---

# InnerJoinAttribute constructor (4 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a inner join

```csharp
public InnerJoinAttribute(string alias, string toTable, string onCriteria, 
    params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| alias | Join alias |
| toTable | Join table |
| onCriteria | If the attribute is used on a property, this parameter is a field name, if used on a class, this parameter is the ON criteria of the inner join statement. |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [InnerJoinAttribute](../InnerJoinAttribute.md)