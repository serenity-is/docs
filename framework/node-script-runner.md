# Node Script Runner (Development Build & Watch)

In development, Serenity can automatically run the TypeScript build and **watch** for changes, so you don't have to rebuild manually every time you modify a `.ts` file while the app is running.

## How it works

`app.UseNodeScriptRunner()` in `Startup.Configure` reads the `StartNodeScripts` configuration key and starts each entry as a Node script (from `package.json`) in the background, attaching its output to the application logger:

```cs
public void Configure(WebApplication app, IWebHostEnvironment env)
{
    RowFieldsProvider.SetDefaultFrom(app.Services);
    app.InitializeLocalTexts();
    app.UseNodeScriptRunner();
    // ...
}
```

The `StartNodeScripts` key is a semicolon-separated list of `scriptName [arguments]` entries. In `appsettings.Development.json`:

```json
{
  "StartNodeScripts": "build --watch"
}
```

This runs the `build` script from the project's `package.json` with the `--watch` argument:

```json
{
  "scripts": {
    "build": "node ./tsbuild.js"
  }
}
```

The `tsbuild.js` file calls the `@serenity-is/tsbuild` build, and `--watch` keeps it running and rebuilds when a TypeScript file changes:

```js
import { build } from "@serenity-is/tsbuild";

await build({
    buildGlobalBundles: true
});
```

Because the key is only in `appsettings.Development.json`, the watch build runs only in the **Development** environment. In production you build once (e.g. via `pnpm install` / `dotnet publish`) and the app serves the pre-built bundles.

## NodeScriptRunner

[NodeScriptRunner](../api/dotnet/Serenity.Net.Web/Serenity.Web/NodeScriptRunner.md) is the class that executes a `package.json` script, capturing its stdout/stderr. It:

- Runs `node --run <script> -- <arguments>` (or `npm run <script> -- <arguments>` when a different package manager command is configured).
- On Windows, invokes `.cmd` package managers through `cmd /c` so their output can still be captured.
- Is disposed when the application stops (via the `IHostApplicationLifetime.ApplicationStopping` token), killing the whole process tree.

## NodeScriptRunnerExtensions

[NodeScriptRunnerExtensions](../api/dotnet/Serenity.Net.Web/Serenity.Extensions.DependencyInjection/NodeScriptRunnerExtensions.md) provides the extension methods:

- `UseNodeScriptRunner(workingDirectory, envVars, pkgManagerCommand)` — reads `StartNodeScripts` from configuration and starts each entry.
- `StartNodeScript(scriptName, arguments, workingDirectory, envVars, pkgManagerCommand)` — starts a single script.

Both default the working directory to the content root and the package manager command to `node`. The runner's output is forwarded to the `Serenity.Web.NodeScriptRunner` logger category (ANSI colors are stripped, and esbuild errors/warnings are mapped to the corresponding log levels).

> **Note:** The Node script runner is a development convenience only — it is not used in production.

## See Also

- [Initialization and Startup](initialization.md) — the `Startup.Configure` flow and `UseNodeScriptRunner()`
- [Script & CSS Bundling](script-bundling.md) — how the built bundles are served and versioned