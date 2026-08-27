# Script & CSS Bundling

Serenity can combine your JavaScript and CSS files into **bundles**, **minify** them, and append a **content hash** to the URLs so browsers always fetch the latest version after a deploy. This page covers the server-side infrastructure behind that: the bundle managers, the options you configure in `appsettings.bundles.json`, minification, content hashing/versioning, and the HTML helpers you use in your Razor layouts.

> Bundles are implemented as *dynamic scripts*: each bundle is registered with the dynamic script manager as a `ConcatenatedScript` and served through `~/DynJS.axd/`. See [Dynamic Scripts](dynamic-scripts/readme.md) for the dynamic script system itself.

## How It Fits Together

At a high level:

1. You define bundles in the `ScriptBundling` and `CssBundling` sections of `appsettings.bundles.json` (each bundle is a named list of source files).
2. At startup, `AddCssAndScriptBundling()` registers the bundle managers, minifiers, and content hash cache.
3. The bundle managers read the options, expand each bundle into a `ConcatenatedScript`, and register it with the dynamic script manager under a name like `Bundle.<key>` or `CssBundle.<key>`.
4. In your layout, `@Html.ScriptBundle("Base")` / `@Html.StyleBundle("Base")` render a single `<script>` / `<link>` pointing at the bundle when bundling is enabled, or individual tags for each file when it is disabled.
5. Every URL is passed through the content hash cache, which appends `?v=<hash>` so the browser cache is invalidated when a file changes.

## Configuration

Bundling options are bound from configuration by `[DefaultSectionKey]` (see [Initialization and Startup](initialization.md)):

- `ScriptBundlingOptions` — section key `ScriptBundling`.
- `CssBundlingOptions` — section key `CssBundling`.

The templates keep these in a separate `appsettings.bundles.json` file, loaded in `Program.cs`:

```cs
builder.Configuration.AddJsonFile("appsettings.bundles.json");
```

A typical file looks like this:

```json
{
  "CssBundling": {
    "Bundles": {
      "Base": [
        "~/esm/bundles/style.bundle{.rtl}.css"
      ]
    }
  },
  "ScriptBundling": {
    "Bundles": {
      "Base": [
        "~/esm/bundles/script.bundle.js",
        "dynamic://ColumnAndFormBundle"
      ]
    }
  }
}
```

### Options reference

Both option classes share the same shape:

| Option | Type | Meaning |
| --- | --- | --- |
| `Bundles` | `Dictionary<string, string[]>` | The named bundles and their source files. |
| `Enabled` | `bool?` | Whether bundling is enabled. When `false` (the default), the layout renders individual `<script>`/`<link>` tags instead of a bundle. |
| `Minimize` | `bool?` | Whether files are minified when included in a bundle. Defaults to `true`. |
| `NoMinimize` | `string[]` | Relative paths to exclude from minification. |
| `UseMinJS` / `UseMinCSS` | `bool?` | Whether an existing `.min.js` / `.min.css` file on disk is used instead of minifying in memory. Defaults to `true`. |
| `Replacements` | `Dictionary<string, object>` | Placeholder replacements in bundle entries, e.g. `{Development}`. |

### Bundle entries

Each entry in a `Bundles` list can be:

- An **app-relative file path**, e.g. `~/esm/bundles/script.bundle.js`. The file is read from the web root, optionally minified, and included.
- A **dynamic script reference**, e.g. `dynamic://ColumnAndFormBundle`. The named dynamic script's output is included in the bundle (and its permission is checked).
- A **bundle include**, e.g. `dynamic://Bundle.OtherBundle` (for scripts) or `dynamic://CssBundle.OtherBundle` (for CSS) — includes another bundle's contents inline.

Two special placeholders are supported in entries:

- `{version}` — expanded to the latest versioned file matching the pattern in the same folder (e.g. `~/Scripts/serenity.core.{version}.js` picks the highest version number).
- `{.rtl}` — used by CSS bundles for right-to-left variants. The CSS bundle manager automatically creates a `<key>.rtl` bundle from any bundle whose entries contain `{.rtl}`, replacing the placeholder with `.rtl` for the RTL variant and removing it for the LTR variant.

## Registration

In `Startup.cs`, bundling is enabled alongside dynamic scripts:

```cs
services.AddDynamicScripts()
    .AddCssAndScriptBundling();
```

The registration extensions (from `DynamicScriptServiceCollectionExtensions`) are:

- `AddCssAndScriptBundling()` — registers both CSS and script bundling.
- `AddCssBundling()` — registers `ICssBundleManager` (plus the dynamic script manager, content hash cache, and CSS minifier).
- `AddScriptBundling()` — registers `IScriptBundleManager` (plus the dynamic script manager, content hash cache, and script minifier).
- `AddContentHashCache()` — registers `IContentHashCache` and the file watcher factory.

Each also has an overload taking an `Action<TOptions>` if you want to configure options in code instead of (or in addition to) `appsettings.json`.

## Bundle Managers

### IScriptBundleManager / ScriptBundleManager

[`IScriptBundleManager`](../api/dotnet/Serenity.Net.Web/Serenity.Web/IScriptBundleManager.md) is implemented by [`ScriptBundleManager`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptBundleManager.md). It:

- Reads `ScriptBundlingOptions`, expands each bundle into a `ConcatenatedScript`, and registers it with the dynamic script manager as `Bundle.<key>`.
- `IsEnabled` — whether bundling is enabled.
- `GetScriptBundle(scriptUrl)` — given a source script URL, returns the bundle URL that contains it (or the original URL if it isn't bundled). This is what `@Html.Script(...)` uses.
- `GetBundleIncludes(bundleKey)` — the flattened list of files/dynamic scripts in a bundle (used when bundling is disabled to render individual tags).
- `Reset()` — rebuilds the bundles from options.
- `ScriptsChanged()` — clears the version cache and marks all bundles as changed (called when a watched file changes).

The manager subscribes to the dynamic script manager's `ScriptChanged` event, so when a dynamic script that is part of a bundle changes, the containing bundle is invalidated too.

### ICssBundleManager / CssBundleManager

[`ICssBundleManager`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ICssBundleManager.md) is implemented by [`CssBundleManager`](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssBundleManager.md). It mirrors the script manager (`GetCssBundle`, `GetBundleIncludes`, `Reset`, `CssChanged`) and additionally:

- Handles the `{.rtl}` placeholder to produce RTL/LTR bundle variants.
- Rewrites relative `url(...)` references inside CSS so they stay correct after bundling (files from different folders are combined into one bundle served from `~/DynJS.axd/`).
- Strips source-map comments from the CSS.

## Minification

Minification is abstracted behind two interfaces:

- [`IScriptMinifier`](../api/dotnet/Serenity.Net.Web/Serenity.Web/IScriptMinifier.md) — `MinifyScript(source, options)` returns a [`ScriptMinifyResult`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptMinifyResult.md).
- [`ICssMinifier`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ICssMinifier.md) — `MinifyCss(source, options)` returns a [`CssMinifyResult`](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssMinifyResult.md).

The options ([`ScriptMinifyOptions`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ScriptMinifyOptions.md) / [`CssMinifyOptions`](../api/dotnet/Serenity.Net.Web/Serenity.Web/CssMinifyOptions.md)) currently expose a single `LineBreakThreshold`. The results expose `Code` (the minified output) and `HasErrors` (whether minification failed; on failure the original code is used).

Two implementations ship with the framework:

- [`NuglifyMinifier`](../api/dotnet/Serenity.Net.Web/Serenity.Web/NuglifyMinifier.md) — uses the NUglify library (a .NET port of UglifyJS/CleanCSS).
- `EsBuildMinifier` — uses the esbuild CLI (downloaded on demand). This is the default registered by `AddCssBundling()` / `AddScriptBundling()` in current templates.

Because the minifiers are registered through `TryAddSingleton`, you can replace them by registering your own `IScriptMinifier` / `ICssMinifier` before calling the bundling extensions.

## Content Hashing & Versioning (Cache-Busting)

[`IContentHashCache`](../api/dotnet/Serenity.Net.Web/Serenity.Web/IContentHashCache.md) is implemented by [`ContentHashCache`](../api/dotnet/Serenity.Net.Web/Serenity.Web/ContentHashCache.md). It computes a hash of each web-servable file and appends it as a `?v=` query string:

- `ResolveWithHash(pathBase, contentUrl)` — returns the URL with `?v=<hash>` appended. The hash is an MD5 of the file content (or its last-write time if the file can't be read), base64-url-encoded.
- `ResolvePath(pathBase, contentPath)` — resolves a path, optionally rewriting it to a CDN URL.
- `ScriptsChanged()` — clears the hash cache.

This is what makes the browser fetch the new file after you deploy a change: the URL changes because the hash changes, so the old cached copy is not reused.

### CDN support

`ContentHashCache` also reads a `CDNSettings` options class (section key `CDN`). When enabled, it rewrites matching content URLs to a CDN root (`Url` for HTTP, `HttpsUrl` for HTTPS), with `Include` / `Exclude` glob patterns controlling which files go to the CDN.

## HTML Helpers for Layouts

The Razor helpers live in [`HtmlScriptExtensions`](../api/dotnet/Serenity.Net.Web/Serenity.Web/HtmlScriptExtensions.md). They are used in `_LayoutHead.cshtml` and similar views:

```cshtml
@Html.StyleBundle("Base" + rtl)
@Html.ScriptBundle("Base")
```

- `Script(url)` / `Stylesheet(url)` — render a single `<script>` / `<link>` for a file. If the file is part of a bundle, the bundle URL is used instead; if the bundle (or file) was already rendered in this request, an empty string is returned to avoid duplicates.
- `ScriptBundle(key)` / `StyleBundle(key)` — render a single tag for the whole bundle when bundling is enabled, or one tag per include when it is disabled.
- `ResolveWithHash(url)` — returns the URL with its content hash appended.
- `LocalTextScript(package)` — renders the local text script for a package (see [Localization](localization.md)).
- `ModulePageInit(module, options)` — renders a `<script type="module">` that imports a module's default export (usually `pageInit`) and calls it with the given options, including the module's CSS if present.
- `AutoIncludeModuleCss(module)` — includes the `.css` file next to a `.js` ES module if it exists.

The real `_LayoutHead.cshtml` in the templates shows the full picture:

```cshtml
@{
    var rtl = CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft ? ".rtl" : "";
    var nonce = Html.CspNonce();
}
<partial name="@MVC.Views.Shared._ImportMap" />
<partial name="@MVC.Views.Shared._ContentSecurityPolicy" />
@Html.StyleBundle("Base" + rtl)
<script type="application/json" id="ScriptCulture">@Html.Raw(JSON.Stringify(new ScriptCulture()))</script>
@Html.LocalTextScript("Site")
@Html.ScriptBundle("Base")
<script type="module" src=@Html.ResolveWithHash(ESM.ScriptInit) nonce="@nonce"></script>
```

### Content Security Policy helpers

[`HtmlCspExtensions`](../api/dotnet/Serenity.Net.Web/Serenity.Web/HtmlCspExtensions.md) helps you build a Content Security Policy header/meta tag that works with the nonces Serenity generates:

- `CspNonce()` — generates (once per request) a nonce, stores it in the HTTP context items, and adds it to the `script-src` / `style-src` directives.
- `AddCspDirective(name, values)` — adds values to a CSP directive for the current request (on an `IHtmlHelper`, `HttpContext`, or `ControllerBase`). Values that look like keywords are auto-quoted.
- `GetCspDirective(name, manualValues)` — renders a directive (with trailing semicolon) merging manual values with those added via `AddCspDirective`.
- `AddCspScriptUrl(url)` — adds a URL to `script-src` and returns it.

The template's `_ContentSecurityPolicy.cshtml` renders the meta tag:

```cshtml
<meta http-equiv="Content-Security-Policy" content="
    @Html.GetCspDirective("base-uri", "self")
    @Html.GetCspDirective("connect-src", "self", "http:", "ws:", "wss:")
    @Html.GetCspDirective("default-src", "self")
    @Html.GetCspDirective("font-src", "self", "https://fonts.gstatic.com")
    @Html.GetCspDirective("script-src", "self", "https://www.google.com/recaptcha/")
    @Html.GetCspDirective("style-src", "self")
"/>
```

### Import map helpers

[`HtmlImportMapExtensions`](../api/dotnet/Serenity.Net.Web/Serenity.Web/HtmlImportMapExtensions.md) supports ES module import maps:

- `AddImportMapEntry(specifier, address, integrity, csp, overwrite)` — adds an entry mapping a module specifier to its address (on an `HttpContext`). Local addresses are resolved with their content hash; external addresses can be added to the CSP `script-src` directive.
- `AddSerenityAssetsImportMapEntries()` — adds the built-in entries for `jspdf`, `jspdf-autotable`, and `@serenity-is/tiptap`.
- `RenderImportMap()` — renders the `<script type="importmap">` element for the current view.

The template's `_ImportMap.cshtml` is simply:

```cshtml
@{
    Context.AddSerenityAssetsImportMapEntries();
}
@Html.RenderImportMap()
```

## TemplateHelper

[`TemplateHelper`](../api/dotnet/Serenity.Net.Web/Serenity.Web/TemplateHelper.md) provides `RenderViewToString(serviceProvider, viewName, model, beforeRender)` — it renders a CSHTML view to a string outside of a normal request (for example, to produce HTML for an email or a PDF report). It resolves the view through the Razor view engine, builds a `ViewContext` with the given model, and returns the rendered markup.

## See Also

- [Dynamic Scripts](dynamic-scripts/readme.md) — the dynamic script system that bundles are built on (`ConcatenatedScript`, `~/DynJS.axd/`)
- [Initialization and Startup](initialization.md) — `AddCssAndScriptBundling()`, `ConfigureSections()`, and the type source
- [Localization](localization.md) — `LocalTextScript` and local text packages
- [Reporting](../services/reporting.md) — using `TemplateHelper.RenderViewToString` for HTML/PDF output