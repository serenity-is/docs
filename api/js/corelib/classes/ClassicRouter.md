[@serenity-is/corelib](../README.md) / ClassicRouter

# ~~Class: ClassicRouter~~

Defined in: [src/compat/router.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L78)

Legacy hash-based router that maps dialog stack to `"/+/"` delimited hash segments.
Compat shim for the old `Q.Router` implementation. Listens to `hashchange`, dialog open/close, and anchor clicks to keep the URL in sync with visible dialogs and to dispatch `handleroute` events.

## Deprecated

Use explicit routing or state-driven dialog management. Kept solely for backward compatibility with legacy Serenity pages.

## Implements

- [`IClassicRouter`](../interfaces/IClassicRouter.md)

## Constructors

### Constructor

> **new ClassicRouter**(): `ClassicRouter`

Defined in: [src/compat/router.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L443)

#### Returns

`ClassicRouter`

## Properties

### ~~enabled~~

> **enabled**: `boolean` = `true`

Defined in: [src/compat/router.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L86)

When `false`, all routing operations become no-ops.

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`enabled`](../interfaces/IClassicRouter.md#enabled)

***

### ~~mightBeRouteRegex~~

> **mightBeRouteRegex**: `RegExp`

Defined in: [src/compat/router.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L243)

Regex used to heuristically detect whether a single hash segment might represent a dialog route (e.g., `new`, `edit/…`, `!…`).

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`mightBeRouteRegex`](../interfaces/IClassicRouter.md#mightberouteregex)

## Methods

### ~~destroy()~~

> **destroy**(): `void`

Defined in: [src/compat/router.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L462)

Removes all event listeners registered by the router and releases resources.

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`destroy`](../interfaces/IClassicRouter.md#destroy)

***

### ~~dialog()~~

> **dialog**(`owner`, `element`, `dialogHash`): `void`

Defined in: [src/compat/router.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L228)

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

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`dialog`](../interfaces/IClassicRouter.md#dialog)

***

### ~~ignoreHashChange()~~

> **ignoreHashChange**(`expiration?`): `void`

Defined in: [src/compat/router.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L369)

Temporarily ignores the next `hashchange` event(s).

#### Parameters

##### expiration?

`number`

Duration in milliseconds to ignore hash changes. Defaults to `1000`.

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`ignoreHashChange`](../interfaces/IClassicRouter.md#ignorehashchange)

***

### ~~navigate()~~

> **navigate**(`newHash`, `tryBack?`, `silent?`): `void`

Defined in: [src/compat/router.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L93)

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

When `true`, suppresses the subsequent `hashchange` handling via [ignoreHashChange](../interfaces/IClassicRouter.md#ignorehashchange).

#### Returns

`void`

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`navigate`](../interfaces/IClassicRouter.md#navigate)

***

### ~~replace()~~

> **replace**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L121)

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

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`replace`](../interfaces/IClassicRouter.md#replace)

***

### ~~replaceLast()~~

> **replaceLast**(`newHash`, `tryBack?`): `void`

Defined in: [src/compat/router.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L126)

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

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`replaceLast`](../interfaces/IClassicRouter.md#replacelast)

***

### ~~resolve()~~

> **resolve**(`newHash?`): `"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

Defined in: [src/compat/router.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L246)

Resolves the current (or provided) hash by closing/opening dialogs and dispatching `handleroute`.

#### Parameters

##### newHash?

`string`

Hash to resolve; defaults to `window.location.hash` when omitted.

#### Returns

`"disabled"` \| `"skipped"` \| `"shebang"` \| `"missinghandler"` \| `"calledhandler"`

A status string: `"disabled"` if the router is disabled, `"skipped"` if a recent anchor click looks like a non-route hash, `"shebang"` for `!` prefixed routes, `"missinghandler"` when a handler element cannot be found, or `"calledhandler"` when a `handleroute` event was dispatched.

#### Implementation of

[`IClassicRouter`](../interfaces/IClassicRouter.md).[`resolve`](../interfaces/IClassicRouter.md#resolve)
