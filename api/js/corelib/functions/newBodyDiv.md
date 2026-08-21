[@serenity-is/corelib](../README.md) / newBodyDiv

# Function: newBodyDiv()

> **newBodyDiv**(): `HTMLDivElement`

Defined in: [src/compat/html-compat.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L97)

Creates a new `<div>` and appends it to `document.body`.

## Returns

`HTMLDivElement`

The newly created and appended `HTMLDivElement`.

## Remarks

Compat helper from `Q.newBodyDiv`; prefer `document.createElement` + explicit append in new code.
