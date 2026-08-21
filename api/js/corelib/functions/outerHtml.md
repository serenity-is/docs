[@serenity-is/corelib](../README.md) / outerHtml

# Function: outerHtml()

> **outerHtml**(`element`): `string`

Defined in: [src/compat/html-compat.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L109)

Returns the outer HTML markup of an element (including the element itself).

## Parameters

### element

Target element, `Element`, or array-like/jQuery-like wrapper containing it.

`Element` | `ArrayLike`\<`HTMLElement`\>

## Returns

`string`

Outer HTML string. For non-Elements, clones the node into a temporary `<i>` wrapper and returns `innerHTML`; yields `""` for falsy targets.

## Remarks

Compat helper from `Q.outerHtml`; for new code prefer `element.outerHTML` directly.
