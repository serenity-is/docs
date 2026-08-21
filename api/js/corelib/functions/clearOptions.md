[@serenity-is/corelib](../README.md) / clearOptions

# Function: clearOptions()

> **clearOptions**(`select`): `void`

Defined in: [src/compat/html-compat.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L38)

Removes all child options/content from a `<select>` element.

## Parameters

### select

Target element or array-like/jQuery-like wrapper containing it.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`

## Remarks

Resolves array-like wrappers via `isArrayLike` and clears with `innerHTML = ''`. No-op if the resolved element is falsy. Compat helper from `Q.clearOptions`.
