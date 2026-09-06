# ConnectionStringInfo constructor

Contains a connection string, its key, and provider name.

```csharp
public ConnectionStringInfo(string connectionKey, string connectionString, string providerName, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |
| connectionString | The connection string. |
| providerName | The name of the provider. |
| dialect | The SQL dialect. |

## Remarks

Initializes a new instance of the [`ConnectionStringInfo`](../ConnectionStringInfo.md) class.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [ConnectionStringInfo](../ConnectionStringInfo.md)