[@serenity-is/corelib](../README.md) / IClassicRouter

# ~~Interface: IClassicRouter~~

Defined in: [src/compat/router.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L25)

Contract for the legacy hash-based router.
Compat shim for the old `Q.Router` / `Serenity.Router` singleton. The router synchronizes dialog open/close state
with the URL hash using `"/+/"` delimited segments and fires `handleroute` events on designated handlers.

## Deprecated

Hash-based dialog routing is legacy. Prefer explicit client-side routing or modern dialog state management. Kept for backward compatibility.

## Properties

### ~~enabled~~

> **enabled**: `boolean`

Defined in: [src/compat/router.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L27)

When `false`, all routing operations become no-ops.

***

### ~~mightBeRouteRegex~~

> **mightBeRouteRegex**: `RegExp`

Defined in: [src/compat/router.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L55)

Regex used to heuristically detect whether a single hash segment might represent a dialog route (e.g., `new`, `edit/…`, `!…`).

## Methods

### ~~destroy()~~

> **destroy**(): `void`

Defined in: [src/compat/router.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L68)

Removes all event listeners registered by the router and releases resources.

#### Returns

`void`

***

### ~~dialog()~~

> **dialog**(`owner`, `element`, `dialogHash`): `void`

Defined in: [src/compat/router.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L53)

Registers a dialog open for hash tracking. The actual hash mutation is deferred until the dialog is confirmed open.

#### Parameters

##### owner

Owner element that triggered the dialog (array-like collections use the first element).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### element

Dialog content element whose `data-qroute` / `data-qprhash` attributes will be managed.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### dialogHash

() => `string`

Factory returning the hash segment for this dialog (e.g., `"!a1"`).

#### Returns

`void`

***

### ~~ignoreHashChange()~~

> **ignoreHashChange**(`expiration?`): `void`

Defined in: [src/compat/router.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L66)

Temporarily ignores the next `hashchange` event(s).

#### Parameters

##### expiration?

`number`

Duration in milliseconds to ignore hash changes. Defaults to `1000`.

#### Returns

`void`

***

### ~~navigate()~~

> **navigate**(`newHash`, `tryBack?`, `silent?`): `void`

Defined in: [src/compat/router.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L34)

Navigates to a new hash, optionally attempting `history.back()` when the URL matches the previous one.

#### Parameters

##### newHash

`string`

Hash string with or without leading `#`. Empty string clears the hash.

##### tryBack?

`boolean`

When `true`, uses `history.back()` if the target matches ClassicRouter.oldURL.

##### silent?

`boolean`

When `true`, suppresses the subsequent `hashchange` handling via [ignoreHashChange](#ignorehashchange).

#### Returns

`void`

***

### ~~replace()~~

> **replace**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L40)

Replaces the current hash without adding a history entry (silent navigation).

#### Parameters

##### newHash

`string`

Target hash (with or without `#`).

##### tryBack?

`boolean`

When `true`, prefers `history.back()` if applicable.

#### Returns

`void`

***

### ~~replaceLast()~~

> **replaceLast**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L46)

Replaces only the last `"/+/"` segment of the current hash.

#### Parameters

##### newHash

`string`

Replacement for the last segment; when empty/falsy the last segment is removed.

##### tryBack?

`boolean`

When `true`, prefers `history.back()` if applicable.

#### Returns

`void`

***

### ~~resolve()~~

> **resolve**(`newHash?`): `"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

Defined in: [src/compat/router.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L61)

Resolves the current (or provided) hash by closing/opening dialogs and dispatching `handleroute`.

#### Parameters

##### newHash?

`string`

Hash to resolve; defaults to `window.location.hash` when omitted.

#### Returns

`"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

A status string: `"disabled"` if the router is disabled, `"skipped"` if a recent anchor click looks like a non-route hash, `"shebang"` for `!` prefixed routes, `"missinghandler"` when a handler element cannot be found, or `"calledhandler"` when a `handleroute` event was dispatched.
