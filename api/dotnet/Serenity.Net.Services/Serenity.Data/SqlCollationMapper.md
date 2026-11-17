# SqlCollationMapper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Maps an engine independent [`SqlCollationSpec`](./SqlCollationSpec.md) to the name of a collation of a database engine.

```csharp
public static class SqlCollationMapper
```

## Public Members

| name | description |
| --- | --- |
| const [AutoMap](SqlCollationMapper/AutoMap.md) | Maps the comparer of the connection, throws if there is no exact match. |
| const [AutoMapTolerant](SqlCollationMapper/AutoMapTolerant.md) | Maps the comparer of the connection, throws only if the culture can't be mapped. |
| const [TryAutoMap](SqlCollationMapper/TryAutoMap.md) | Maps the comparer of the connection, uses no collation if there is no exact match. |
| const [TryAutoMapTolerant](SqlCollationMapper/TryAutoMapTolerant.md) | Maps the comparer of the connection, uses no collation only if the culture can't be mapped. |
| static [IsAutoMap](SqlCollationMapper/IsAutoMap.md)(…) | Returns true if the value is one of the automap keywords, which can be used as a collation setting of a connection. |
| static [Map](SqlCollationMapper/Map.md)(…) | Maps the specified comparison to a collation name. |
| static [ResolveAutoMap](SqlCollationMapper/ResolveAutoMap.md)(…) | Maps the specified comparer specification according to an automap keyword. |
| static [TryMap](SqlCollationMapper/TryMap.md)(…) | Tries to map the specified comparison to a collation name. |

## Remarks

A culture without a collation never has a fallback. With tolerant mapping, a collation that only differs in case or accent sensitivity can be used, when the engine has no exact match. Names are returned as is, so callers should quote them where the engine requires it, e.g. for Postgres.

## See Also

* **Source:** *[SqlCollationMapper.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Collations/SqlCollationMapper.cs)*