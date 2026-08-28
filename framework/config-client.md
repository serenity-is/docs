# Config and Global Settings

The `Config` object in `@serenity-is/corelib` holds global runtime configuration for the client framework. Values are typically set once during application startup (e.g. in `ScriptInit.ts`) and read throughout the app.

## Config Properties

| Property | Description |
| --- | --- |
| `applicationPath` | Root path of the application (e.g. `"/mysite/"`). Initialized from `<link id="ApplicationPath">`. |
| `cspNonce` | Content Security Policy nonce for dynamically created `<script>`/`<style>` tags. |
| `rootNamespaces` | Root namespaces probed when resolving short type names. Defaults to `["Serenity"]`. |
| `defaultReturnUrl` | Fallback URL to redirect to when no explicit return URL is provided. |
| `emailAllowOnlyAscii` | Whether e-mail validation allows only ASCII characters (default `true`). |
| `lazyTypeLoader` | Callback to lazily resolve a type not yet in the type registry (for code-splitting). |
| `notLoggedInHandler` | Handler invoked when a service call returns `NotAuthorized`/session expired. |

## Setting Values in ScriptInit.ts

The most common configuration is adding your application namespace to `rootNamespaces` so short type names resolve:

```ts
import { Config } from "@serenity-is/corelib";

Config.rootNamespaces.push("MyApp");
```

Other examples:

```ts
Config.emailAllowOnlyAscii = false;
Config.defaultReturnUrl = (purpose) => purpose === "logout" ? "/Goodbye" : Config.applicationPath;
Config.notLoggedInHandler = () => window.location.href = "/Account/Login";
```

## applicationPath

`Config.applicationPath` is the root path of the application, always starting and ending with `/`. It is initialized from `<link id="ApplicationPath" href="/mysite/">` in `_LayoutHead.cshtml`, falling back to `"/"`.

It is used by `resolveUrl` to resolve `~/`-prefixed URLs:

```ts
import { resolveUrl } from "@serenity-is/corelib";

resolveUrl("~/upload/xyz.png"); // "/mysite/upload/xyz.png"
```

If you change the link element at runtime, call `resetApplicationPath()` to re-read it:

```ts
document.getElementById("ApplicationPath").href = "/newPath/";
resetApplicationPath();
```

## cspNonce

`Config.cspNonce` is the Content Security Policy nonce applied to dynamically created `<script>`/`<style>` tags. It is initialized from `<meta name="csp-nonce">` or the `nonce` attribute of existing script/style elements. Helpers that inject markup copy this value to the `nonce` attribute.

## lazyTypeLoader

`Config.lazyTypeLoader` lets you lazily load types (e.g. with code-splitting) when they are requested but not yet registered:

```ts
Config.lazyTypeLoader = async (typeKey) => await import(`./editors/${typeKey}`);
```

## See Also

- [Config (API reference)](../api/js/corelib/variables/Config.md) — the full `Config` object.
- [resetApplicationPath (API reference)](../api/js/corelib/functions/resetApplicationPath.md) — re-read the application path.
- [resetCspNonce (API reference)](../api/js/corelib/functions/resetCspNonce.md) — re-read the CSP nonce.
- [resolveUrl (API reference)](../api/js/corelib/functions/resolveUrl.md) — resolve `~/` URLs.
- [Type Registration](ui/type-registration.md) — how `rootNamespaces` is used.
- [Frontend Framework Overview](ui/readme.md) — the three client-side packages and how they fit together.