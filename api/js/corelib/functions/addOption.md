[@serenity-is/corelib](../README.md) / addOption

# Function: addOption()

> **addOption**(`select`, `key`, `text`): `void`

Defined in: [src/compat/html-compat.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L19)

Appends an `<option>` to a `<select>` element.

## Parameters

### select

Target `<select>` or array-like/jQuery-like wrapper containing it.

`HTMLSelectElement` | `ArrayLike`\<`HTMLElement`\>

### key

`string`

Value attribute for the option (`null`/`undefined` → `""`).

### text

`string`

Display text for the option (`null`/`undefined` → `""`).

## Returns

`void`

## Remarks

Creates an `HTMLOptionElement` via `document.createElement("option")`. No-op if the resolved select element is falsy. Compat helper from `Q.addOption`.
