# SerenityStaticAssets.Apply method

Adds the asset folders in the manifest to the web root file provider of the environment. Also enables the static web assets of other projects / packages when not running in development environment, as it is only done automatically for development. Does nothing if there is no manifest, e.g. for a published application.

```csharp
public static bool Apply(IWebHostEnvironment environment, IConfiguration configuration)
```

| parameter | description |
| --- | --- |
| environment | Host environment |
| configuration | Configuration |

## Return Value

True if a manifest is found and applied

## See Also

* class [SerenityStaticAssets](../SerenityStaticAssets.md)