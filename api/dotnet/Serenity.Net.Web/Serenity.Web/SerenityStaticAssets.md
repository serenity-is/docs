# SerenityStaticAssets class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Serves static assets of packages that don't use the static web assets SDK (e.g. Serenity.Corelib) while running from the build output. The build writes a manifest named "[ApplicationName].serenitystaticassets.json" next to the application assembly, which lists the asset folders (project wwwroot or package staticwebassets folders) and their base paths. A published application has these files under its wwwroot, and no manifest.

```csharp
public static class SerenityStaticAssets
```

## Public Members

| name | description |
| --- | --- |
| const [ManifestFileSuffix](SerenityStaticAssets/ManifestFileSuffix.md) | Suffix of the manifest file name, which is prefixed with the application name. |
| static [Apply](SerenityStaticAssets/Apply.md)(…) | Adds the asset folders in the manifest to the web root file provider of the environment. Also enables the static web assets of other projects / packages when not running in development environment, as it is only done automatically for development. Does nothing if there is no manifest, e.g. for a published application. |
| static [CreateFileProvider](SerenityStaticAssets/CreateFileProvider.md)(…) | Creates the file provider for a manifest entry, which serves the files of the folder that match its patterns under its base path. |
| static [GetManifestPath](SerenityStaticAssets/GetManifestPath.md)(…) | Gets the manifest file path for the application. |
| static [ReadManifest](SerenityStaticAssets/ReadManifest.md)(…) | Reads the asset folder entries from a manifest file. |
| static [UseSerenityStaticAssets](SerenityStaticAssets/UseSerenityStaticAssets.md)(…) | Serves static assets of the packages listed in the build output manifest, see [`SerenityStaticAssets`](./SerenityStaticAssets.md). Use this instead of UseStaticWebAssets(), it also enables static web assets outside the development environment. |
| class [ManifestEntry](SerenityStaticAssets.ManifestEntry.md) | An asset folder in the manifest, with its patterns resolved from the manifest's pattern sets. Patterns are ; separated, relative to [`Root`](./SerenityStaticAssets.ManifestEntry/Root.md), and the same ones used to select the files to publish / pack. |

## See Also

* **Source:** *[SerenityStaticAssets.cs](https://github.com/serenity-is/Serenity/blob/4454657c2d936efdadbb406a7a7e589bd4371521/src/web/Mvc/StaticAssets/SerenityStaticAssets.cs)*