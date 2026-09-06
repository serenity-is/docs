# SqlUpdate.Dialect method

Sets the dialect (SQL server type / version) for query.

```csharp
public SqlUpdate Dialect(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | The dialect to use. |

## Return Value

The SqlUpdate object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect is null. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlUpdate](../SqlUpdate.md)