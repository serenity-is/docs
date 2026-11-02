# SerenityStaticAssets.ManifestEntry class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

An asset folder in the manifest, with its patterns resolved from the manifest's pattern sets. Patterns are ; separated, relative to [`Root`](./SerenityStaticAssets.ManifestEntry/Root.md), and the same ones used to select the files to publish / pack.

```csharp
public class ManifestEntry
```

## Public Members

| name | description |
| --- | --- |
| [ManifestEntry](SerenityStaticAssets.ManifestEntry/ManifestEntry.md)() | The default constructor. |
| [BasePath](SerenityStaticAssets.ManifestEntry/BasePath.md) { get; set; } | Gets or sets the base path the folder is served under, like "Serenity.Corelib". |
| [Excludes](SerenityStaticAssets.ManifestEntry/Excludes.md) { get; set; } | Gets or sets the exclude patterns, none if null or empty. |
| [Filter](SerenityStaticAssets.ManifestEntry/Filter.md) { get; set; } | Gets or sets if files are filtered by the patterns (default true). False for package folders, which only contain the files selected while packing. |
| [Includes](SerenityStaticAssets.ManifestEntry/Includes.md) { get; set; } | Gets or sets the include patterns, all files if null or empty. |
| [Root](SerenityStaticAssets.ManifestEntry/Root.md) { get; set; } | Gets or sets the physical path of the folder. |
| [WellKnown](SerenityStaticAssets.ManifestEntry/WellKnown.md) { get; set; } | Gets or sets if the .well-known folder is included regardless of [`Excludes`](./SerenityStaticAssets.ManifestEntry/Excludes.md), in which case [`WellKnownExcludes`](./SerenityStaticAssets.ManifestEntry/WellKnownExcludes.md) apply to it instead (default true). |
| [WellKnownExcludes](SerenityStaticAssets.ManifestEntry/WellKnownExcludes.md) { get; set; } | Gets or sets the exclude patterns for the .well-known folder, none if null or empty. |

## See Also

* class [SerenityStaticAssets](./SerenityStaticAssets.md)