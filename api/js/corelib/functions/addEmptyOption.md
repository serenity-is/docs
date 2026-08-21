[@serenity-is/corelib](../README.md) / addEmptyOption

# Function: addEmptyOption()

> **addEmptyOption**(`select`): `void`

Defined in: [src/compat/html-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L8)

Appends an empty (placeholder) option to a `<select>` element.

## Parameters

### select

Target `<select>` or array-like/jQuery-like wrapper containing it.

`HTMLSelectElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`

## Remarks

Uses SelectEditorTexts.EmptyItemText as the display text and `""` as the value; delegates to [addOption](addOption.md). Compat helper from `Q.addEmptyOption`.
