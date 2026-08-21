[@serenity-is/corelib](../README.md) / layoutFillHeight

# ~~Function: layoutFillHeight()~~

> **layoutFillHeight**(`element`): `void`

Defined in: [src/compat/layout.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L182)

Sets an element's height to fill the remaining vertical space in its parent.
Compat shim for `Q.layoutFillHeight`. Computes the value via [layoutFillHeightValue](layoutFillHeightValue.md) and applies it as an inline `height` style.

## Parameters

### element

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`

## Deprecated

Prefer CSS flex / grid layouts. Kept for legacy full-height grid pages.
