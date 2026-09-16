[@serenity-is/corelib](../README.md) / layoutFillHeight

# Function: layoutFillHeight()

> **layoutFillHeight**(`element`): `void`

Defined in: [src/compat/layout.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L180)

Sets an element's height to fill the remaining vertical space in its parent.
Compat shim for `layoutFillHeight`. Computes the value via [layoutFillHeightValue](layoutFillHeightValue.md) and applies it as an inline `height` style.

## Parameters

### element

Target element or array-like collection (first element is used).
[DEPRECATED] Prefer CSS flex / grid layouts. Kept for legacy full-height grid pages.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`
