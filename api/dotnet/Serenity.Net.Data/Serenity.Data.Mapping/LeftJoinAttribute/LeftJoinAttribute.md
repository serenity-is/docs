# LeftJoinAttribute constructor (1 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a left join on foreign key. Use this version only on properties with ForeignKey attribute.

```csharp
public LeftJoinAttribute(string alias)
```

| parameter | description |
| --- | --- |
| alias | Foreign join alias |

## See Also

* class [LeftJoinAttribute](../LeftJoinAttribute.md)

---

# LeftJoinAttribute constructor (2 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a left join on foreign key. Use this version only on properties with ForeignKey attribute.

```csharp
public LeftJoinAttribute(string alias, params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| alias | Foreign join alias |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [LeftJoinAttribute](../LeftJoinAttribute.md)

---

# LeftJoinAttribute constructor (3 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a left join

```csharp
public LeftJoinAttribute(string alias, string toTable, string onCriteria)
```

| parameter | description |
| --- | --- |
| alias | Join alias |
| toTable | Join table |
| onCriteria | If the attribute is used on a property, this parameter is a field name, if used on a class, this parameter is the ON criteria of the left join statement. |

## See Also

* class [LeftJoinAttribute](../LeftJoinAttribute.md)

---

# LeftJoinAttribute constructor (4 of 4)
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds a left join

```csharp
public LeftJoinAttribute(string alias, string toTable, string onCriteria, 
    params ServerType[] serverTypes)
```

| parameter | description |
| --- | --- |
| alias | Join alias |
| toTable | Join table |
| onCriteria | If the attribute is used on a property, this parameter is a field name, if used on a class, this parameter is the ON criteria of the left join statement. |
| serverTypes | Dialects like MySql, Sqlite. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [LeftJoinAttribute](../LeftJoinAttribute.md)