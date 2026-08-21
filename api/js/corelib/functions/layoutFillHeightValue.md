[@serenity-is/corelib](../README.md) / layoutFillHeightValue

# ~~Function: layoutFillHeightValue()~~

> **layoutFillHeightValue**(`element`): `number`

Defined in: [src/compat/layout.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L156)

Calculates the available height for an element to fill its parent.
Compat shim for `Q.layoutFillHeightValue`. Sums the outer heights of visible siblings and subtracts from the parent height, adjusting for `box-sizing`.

## Parameters

### element

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`number`

The computed fill height in pixels (rounded from computed styles). Returns `0` if the element is not found.

## Deprecated

Use CSS flexbox or `calc()` based layouts. Kept for legacy height calculations that depend on jQuery.
