[@serenity-is/corelib](../README.md) / Config

# Variable: Config

> `const` **Config**: `object`

Defined in: [src/base/config.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/config.ts#L13)

Global runtime configuration for the Serenity client framework.

## Type Declaration

### applicationPath

> **applicationPath**: `string` = `'/'`

Root path of the application, always starting and ending with `/` when read from DOM.

#### Remarks

Initialized from `<link id="ApplicationPath" href="/mysite/">` in `_LayoutHead.cshtml`;
falls back to `"/"` if the element is absent or on the server. Change it at runtime
or call [resetApplicationPath](../functions/resetApplicationPath.md) after dynamically updating the link element.

#### Example

```ts
// app hosted at http://localhost/mysite/
Config.applicationPath; // "/mysite/"
```

### cspNonce

> **cspNonce**: `string`

Content Security Policy nonce to apply to dynamically created `<script>` / `<style>` tags.

#### Remarks

Initialized from `<meta name="csp-nonce">` or the `nonce` attribute of existing
`<script>`/`<style>` elements via [resetCspNonce](../functions/resetCspNonce.md); `null` when no nonce is present
or on the server. Helpers that inject markup should copy this value to the `nonce` attribute.

### defaultReturnUrl()

> **defaultReturnUrl**: (`purpose?`) => `string`

Returns a fallback URL to redirect to when no explicit return URL is provided.

#### Parameters

##### purpose?

`string`

Optional hint such as `"login"` or `"logout"`.

#### Returns

`string`

The URL to use as a return target.

#### Remarks

Default implementation returns [Config.applicationPath](#applicationpath) regardless of purpose.
Override to provide per-purpose defaults (e.g. different landing pages after login vs. logout).

#### Example

```ts
Config.defaultReturnUrl = (purpose) => purpose === "logout" ? "/Goodbye" : Config.applicationPath;
```

### emailAllowOnlyAscii

> **emailAllowOnlyAscii**: `boolean` = `true`

Whether e-mail validation should allow only ASCII characters.

#### Remarks

`true` (default) rejects non-ASCII characters in the local/domain parts;
set to `false` to allow Unicode/IDN addresses.

### lazyTypeLoader()

> **lazyTypeLoader**: (`typeKey`, `kind`) => `any`

Optional callback to lazily resolve a type that is not yet in the type registry.

#### Parameters

##### typeKey

`string`

Full type name being requested, e.g. `"MyApp.MyEditor"`.

##### kind

`string`

Category of the type, used to narrow search/loading.

#### Returns

`any`

The resolved type, a promise for it, or `null` if unavailable.

#### Remarks

Useful with code-splitting / lazy chunk loading. Called with the requested type key
and a `kind` hint (`"dialog"`, `"editor"`, `"enum"`, `"formatter"`, `"filtering"`, …).
May return the type synchronously or a `Promise` resolving to it; returning `null`/`undefined`
signals "not found".

#### Example

```ts
Config.lazyTypeLoader = async (typeKey) => await import(`./editors/${typeKey}`);
```

### notLoggedInHandler

> **notLoggedInHandler**: `Function`

Optional handler invoked when a service call returns `NotAuthorized` / session expired.

#### Remarks

If set, Serenity delegates the "not logged in" flow to this callback so you can
prompt the user, redirect to login, or refresh a token. When `null` (default),
the framework falls back to its built-in handling.

#### Example

```ts
Config.notLoggedInHandler = () => window.location.href = "/Account/Login";
```

### rootNamespaces

> **rootNamespaces**: `string`[]

Root namespaces probed when resolving short type names.

#### Remarks

When a type is requested as `"MyEditor"`, the registry first tries `"MyEditor"`,
then `"Serenity.MyEditor"`, then `"<each rootNamespace>.MyEditor"`.
Add your application namespace (e.g. `"MyApp"`) in `ScriptInit.ts` so short names resolve.
Defaults to `["Serenity"]`.

#### Example

```ts
Config.rootNamespaces.push("MyApp");
```

## Remarks

Implemented as a mutable singleton object. Values are typically set once during
application startup (e.g. in `ScriptInit.ts`) and read throughout the app.
[resetApplicationPath](../functions/resetApplicationPath.md) and [resetCspNonce](../functions/resetCspNonce.md) re-read values from the DOM
and are called automatically on module load.

## Example

```ts
Config.rootNamespaces.push("MyApp");
Config.emailAllowOnlyAscii = false;
```
