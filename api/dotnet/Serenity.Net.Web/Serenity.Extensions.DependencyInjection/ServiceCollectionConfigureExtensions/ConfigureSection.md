# ServiceCollectionConfigureExtensions.ConfigureSection&lt;TOptions&gt; method

Calls `Configure<TOptions>` with the section key determined from DefaultSectionKeyAttribute on *TOptions*.

```csharp
public static IServiceCollection ConfigureSection<TOptions>(this IServiceCollection services, 
    IConfiguration config)
    where TOptions : class
```

| parameter | description |
| --- | --- |
| TOptions | The type of options being configured. |
| services | The IServiceCollection to add the services to. |
| config | The configuration being bound. |

## Return Value

The IServiceCollection so that additional calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *config* is `null`. |
| ArgumentOutOfRangeException | *TOptions* has no DefaultSectionKeyAttribute. |

## See Also

* class [ServiceCollectionConfigureExtensions](../ServiceCollectionConfigureExtensions.md)