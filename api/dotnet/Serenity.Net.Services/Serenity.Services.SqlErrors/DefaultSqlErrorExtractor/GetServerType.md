# DefaultSqlErrorExtractor.GetServerType method

Tries to determine the [`ServerType`](../../Serenity.Data/ServerType.md) from the exception type without referencing provider specific assemblies.

```csharp
protected virtual ServerType? GetServerType(DbException exception)
```

| parameter | description |
| --- | --- |
| exception | The database exception. |

## See Also

* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)