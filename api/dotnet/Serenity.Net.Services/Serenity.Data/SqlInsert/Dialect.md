# SqlInsert.Dialect method

Sets the dialect (SQL server type / version) for query.

```csharp
public SqlInsert Dialect(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | The dialect to use. |

## Return Value

The SqlInsert object itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect is null. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlInsert](../SqlInsert.md)