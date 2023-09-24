# ServiceCollectionConfigureExtensions.ConfigureSection&lt;TOptions&gt; method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers a configuration instance which TOptions will bind against from a root configuration with the default section key for TOptions

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

## See Also

* class [ServiceCollectionConfigureExtensions](../ServiceCollectionConfigureExtensions.md)