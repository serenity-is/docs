# SerenityStaticAssets.UseSerenityStaticAssets method

Serves static assets of the packages listed in the build output manifest, see [`SerenityStaticAssets`](../SerenityStaticAssets.md). Use this instead of UseStaticWebAssets(), it also enables static web assets outside the development environment.

```csharp
public static IWebHostBuilder UseSerenityStaticAssets(this IWebHostBuilder builder)
```

| parameter | description |
| --- | --- |
| builder | Web host builder |

## See Also

* class [SerenityStaticAssets](../SerenityStaticAssets.md)