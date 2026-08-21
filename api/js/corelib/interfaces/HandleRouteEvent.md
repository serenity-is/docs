[@serenity-is/corelib](../README.md) / HandleRouteEvent

# Interface: HandleRouteEvent

Defined in: [src/compat/router.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L8)

Event payload for the `handleroute` event dispatched by [ClassicRouter](../classes/ClassicRouter.md).
Extends the native Event with parsed hash-route information.

## Extends

- `Event`

## Properties

### index

> **index**: `number`

Defined in: [src/compat/router.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L14)

Zero-based index of [route](#route) within [parts](#parts).

***

### isInitial

> **isInitial**: `boolean`

Defined in: [src/compat/router.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L16)

`true` during the initial few resolves after page load; may affect handler behavior.

***

### parts

> **parts**: `string`[]

Defined in: [src/compat/router.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L12)

All route parts split by `"/+/"` from the full hash.

***

### route

> **route**: `string`

Defined in: [src/compat/router.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/router.ts#L10)

The route segment being handled for the current index (e.g., `"new"` or `"edit/5"`).
