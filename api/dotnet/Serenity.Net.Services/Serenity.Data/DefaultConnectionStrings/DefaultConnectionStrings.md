# DefaultConnectionStrings constructor

The default connection string source.

```csharp
public DefaultConnectionStrings(IOptions<ConnectionStringOptions> options, 
    ISqlDialectMapper sqlDialectMapper = null, ITypeSource typeSource = null)
```

| parameter | description |
| --- | --- |
| options | The connection string options. |
| sqlDialectMapper | The SQL dialect mapper. |
| typeSource | The type source used to discover connection key fallbacks. |

## Remarks

Creates a new instance of [`DefaultConnectionStrings`](../DefaultConnectionStrings.md).

## See Also

* class [ConnectionStringOptions](../ConnectionStringOptions.md)
* interface [ISqlDialectMapper](../ISqlDialectMapper.md)
* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [DefaultConnectionStrings](../DefaultConnectionStrings.md)