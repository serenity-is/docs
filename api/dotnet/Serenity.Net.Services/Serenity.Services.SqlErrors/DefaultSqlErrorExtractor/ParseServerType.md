# DefaultSqlErrorExtractor.ParseServerType method

Parses a server type name, e.g. from [`ServerType`](../../Serenity.Data/ISqlDialect/ServerType.md), returning `null` if it is not a known [`ServerType`](../../Serenity.Data/ServerType.md).

```csharp
protected static ServerType? ParseServerType(string? serverType)
```

| parameter | description |
| --- | --- |
| serverType | Server type name. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)