[@serenity-is/corelib](../README.md) / blockUI

# Function: blockUI()

> **blockUI**(`options?`): `void`

Defined in: [src/base/blockui.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/blockui.ts#L23)

Blocks user interaction by overlaying the page with a transparent, wait-cursor layer.

## Parameters

### options?

Optional behavior tuning.

#### useTimeout?

`boolean`

When `true`, defers insertion via `setTimeout(…, 0)` and
coalesces multiple synchronous calls so only one overlay is created in the next tick.
When `false`/`undefined`, the overlay is inserted synchronously.

#### zIndex?

`number`

CSS `z-index` for the overlay. Defaults to `2000`.

## Returns

`void`

## Remarks

Maintains an internal reference count so nested `blockUI` / [blockUndo](blockUndo.md) pairs
are balanced — the overlay is only removed when the count returns to zero.
No-ops on the server (when `document` is undefined). The overlay is a fixed-position
`div.blockUI.blockOverlay` appended to `document.body`.

## Examples

```ts
blockUI(); // block immediately
try {\n *   await save();\n * } finally {\n *   blockUndo();\n * }
```

```ts
blockUI({ zIndex: 3000, useTimeout: true }); // coalesced, higher z-index
```
