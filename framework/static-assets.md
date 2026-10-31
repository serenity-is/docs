# Static Assets

Serenity packages (e.g. `Serenity.Corelib`, `Serenity.Assets`) and feature libraries (e.g. `Serenity.Extensions`,
`Serenity.Demo.Northwind`, `Serenity.Pro.Extensions`) contain client side files under a `wwwroot` folder: compiled `esm`
scripts, styles, fonts, images and so on.

Your application exposes those files under a path based on the library name:

- `/Serenity.Corelib/index.global.js`
- `/Serenity.Extensions/esm/Modules/...`
- `/Serenity.Assets/bootstrap/css/bootstrap.css`

They are not handled by the ASP.NET Core *static web assets* system, but by a much simpler one that ships with the
`Serenity.Net.Web` package. This page explains how to enable and use it, how it works, and how it differs from static web
assets.

> The current StartSharp and Serene templates are already set up this way. If you are upgrading an older project, see
> [Updating StartSharp](../startsharp/README.md) for the steps.

## Enabling It in Your Application

**1. Turn it on in `Program.cs`**, right after creating the builder:

```cs
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseSerenityStaticAssets();
```

That single call replaces the static web assets setup a typical Serene / StartSharp application had before:

```cs
// remove this
if (!builder.Environment.IsDevelopment() && !IsPublishedApp(builder.Environment))
    builder.WebHost.UseStaticWebAssets();
```

**2. Disable the static web assets pipeline** in your web project, so its work is not done twice:

```xml
<!-- Serenity packages / features use Serenity static assets, set to true if another package needs static web assets -->
<StaticWebAssetsEnabled>false</StaticWebAssetsEnabled>
```

**3. That's it.** Nothing else is needed in the application: the assets of every referenced Serenity package and feature
library are served in development and copied to `wwwroot` on publish. You can verify it by running the application and
requesting a known file, e.g. `/Serenity.Corelib/index.global.js`.

If a third-party package, or one of your own Razor class libraries, still depends on static web assets, the build tells you:

| Warning | Meaning |
|---|---|
| `SERSA001` | A package contains static web assets. |
| `SERSA002` | A referenced project uses static web assets. |

In that case set `StaticWebAssetsEnabled` back to `true` (or remove the property): static web assets keep working for
everything, as before, and both systems serve files side by side. Once you are aware of the warnings, you can silence them
with `<SerenityStaticWebAssetsCheck>false</SerenityStaticWebAssetsCheck>`.

## Enabling It in Your Own Feature Library

A library with a `wwwroot` folder opts in with two properties and an item change. This is what Serenity's own feature
libraries do, and what the
[my-features sample](https://github.com/serenity-is/StartSharp/tree/master/docs/samples/my-features) demonstrates:

```xml
<!-- Directory.Build.props -->
<StaticWebAssetBasePath>/$(MSBuildProjectName)</StaticWebAssetBasePath>
<StaticWebAssetsEnabled>false</StaticWebAssetsEnabled>
```

```xml
<!-- Directory.Build.targets -->
<Content Remove="$(MSBuildProjectDirectory)\wwwroot\**" />
<None Include="$(MSBuildProjectDirectory)\wwwroot\**" Exclude="@(None)" />
```

The library's `wwwroot` is then served and published under `/<ProjectName>/`, and packed into its NuGet package when the
project is packable. You don't need to reference any target file — they come with the `Serenity.Net.Web` package.

`StaticWebAssetBasePath` is used on purpose, because it is the same property the static web assets system uses, so URLs
don't change if you switch a library between the two systems. If the library uses the Razor SDK for its views (as
Serenity's features do), keep it; only the static web assets part is turned off.

## How It Works

Nothing changes from the browser's point of view: files are served under the same URLs as before, and they are still real
files on disk that `UseStaticFiles` serves.

**At build time** the web project asks each referenced project, and each NuGet package that ships assets, where its folder
is and which files it contains. It writes a small manifest next to the application assembly,
`<YourApp>.serenitystaticassets.json`. The manifest is copied to the output directory, but is *not* published.

Each entry has the base path (e.g. `Serenity.Extensions`), the folder, and the include / exclude patterns that decide which
files are used. Pattern lists shared by many libraries are written once and referenced by index, so the file stays small
(a few KB) even with dozens of libraries.

**While running from the build output** (development), `UseSerenityStaticAssets()` reads the manifest and adds the folders
to the web root file provider. Files are then served directly from the project folders, or from the NuGet cache for files
coming from packages — nothing is copied around while you are developing, and a change to a `.ts` file picked up by
[Node Script Runner](node-script-runner.md) is visible immediately.

The same include / exclude patterns are used at runtime, so a file that would not be published (a `.tmp` file, a
`node_modules` folder, dot files) also returns 404 in development. What you see while developing is what you get after
publishing.

**On publish** the files are copied into `wwwroot/<BasePath>/...` of the publish output. A published application has no
manifest; the files are simply part of `wwwroot` and are served by the regular static file middleware.

**In NuGet packages** the files are stored under `staticwebassets/`, and a generated `buildTransitive/<PackageId>.props`
declares that folder, so any application referencing the package picks it up automatically — including transitively, e.g.
`Serenity.SleekGrid` files arrive through `Serenity.Corelib`.

## Which Files Are Included

By default every file under `wwwroot` is included, except files that should never be published:

- `bin`, `obj`, output and publish folders,
- `node_modules`, `jspm_packages`, `bower_components`, `packages.lock.json`,
- `*.user`, project / solution files, `.DS_Store`,
- dot files and dot folders — with the exception of `wwwroot/.well-known`, which is kept like the static web assets system
  does,
- temp files: `*.tmp`, `*~`, `Thumbs.db`, `desktop.ini`.

You can narrow this down in the library:

```xml
<!-- only these files (a whitelist), all files when not set. this replaces, it does not extend -->
<SerenityStaticAssetIncludes>wwwroot\esm\**;wwwroot\*.css</SerenityStaticAssetIncludes>

<!-- extra exclusions on top of the defaults, no need to repeat the defaults -->
<SerenityStaticAssetExcludes>$(SerenityStaticAssetExcludes);wwwroot\**\*.map</SerenityStaticAssetExcludes>

<!-- opt out of the system completely -->
<SerenityStaticAssetsEnabled>false</SerenityStaticAssetsEnabled>
```

`SerenityStaticAssetExcludes` is appended to the built-in defaults, so you only list what you want to exclude *in addition*.
Start the value with `$(SerenityStaticAssetExcludes)` like above when a parent `Directory.Build.props` may already set it,
so the lists are combined instead of the parent value being replaced.

## Compression

Client files are compressed **only on publish**, never during builds, so build times are not affected. Both `gzip` (`.gz`)
and `brotli` (`.br`) versions are created next to the originals and cached in the `obj` folder, so a republish only
compresses the files that changed.

At runtime `PreCompressedFileProvider` picks the best variant the browser accepts — `.br` when it supports brotli, otherwise
`.gz` — and falls back to the original file when no variant exists (e.g. a Visual Studio publish, see below). It also sends
`Vary: Accept-Encoding` so proxies and CDNs don't mix the variants up.

> **Note**
>
> Brotli is not available in the .NET Framework version of MSBuild that Visual Studio uses, so *publishing from Visual
> Studio creates only `.gz` files* and logs a message about it. If you need `.br` files, publish with `dotnet publish` from
> the command line. Your site works either way: browsers that accept gzip get the `.gz` file.

Compression uses the same properties as the static web assets system, with the same defaults:

| Property | Default | Description |
|---|---|---|
| `PublishCompressionFormats` | `gzip;brotli` | Formats created on publish |
| `EnableDefaultCompressionFormats` | `true` | When `false`, `PublishCompressionFormats` is not set automatically |
| `CompressionIncludePatterns` | SDK list (js, css, html, json, svg, ...) | Files to compress |
| `CompressionExcludePatterns` | SDK list (jpg, png, gif, woff2, mp4, ...) | Files not to compress |
| `EnableDefaultCompressedItems` | `true` | When `false`, the default include / exclude lists are not added |

A library can also exclude its own files, e.g. Serenity features set
`<CompressionExcludePatterns>**\*.map;**\*.txt</CompressionExcludePatterns>`, since source maps and text files are usually
not needed in production.

## Differences From Static Web Assets

What you get is the same files at the same URLs, with less build overhead, and without the static web assets manifests,
endpoint descriptions and compression bookkeeping in the build output. A few features of the SDK system are intentionally
not implemented:

- **Fingerprinted endpoints and `MapStaticAssets()`**: Serenity uses `UseStaticFiles` together with its content hash cache
  (`?v=...`) for cache busting. If your application relies on `MapStaticAssets` for fingerprinted URLs, keep static web
  assets enabled for the app.
- **Scoped CSS (`*.razor.css` / `*.cshtml.css`) and JS initializer modules (`*.lib.module.js`)**: these are Razor SDK
  features. They keep working for projects that still use static web assets.
- **Third-party Razor class libraries** are unaffected: they keep using static web assets, and both systems serve files
  side by side. The `SERSA001` / `SERSA002` warnings exist so you notice when a package needs them.

## Troubleshooting

**Files return 404 in development.** Check the manifest in your output directory
(`<YourApp>.serenitystaticassets.json`). If a library is missing from it, make sure the project is referenced by the web
project and that its targets are imported (via the `Serenity.Net.Web` package or project reference).

**Files are missing after publish.** Look under `wwwroot/<LibraryName>/` in the publish output. If a file is there in
development but not after publish, it is most likely excluded by the include / exclude patterns — see
[Which Files Are Included](#which-files-are-included).

**A third-party library stopped working.** Look for `SERSA001` / `SERSA002` warnings in the build output and set
`StaticWebAssetsEnabled` to `true` if you see one.

**No `.br` files after publishing.** You published from Visual Studio; use `dotnet publish` instead (see
[Compression](#compression)).
