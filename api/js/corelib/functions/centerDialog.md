[@serenity-is/corelib](../README.md) / centerDialog

# ~~Function: centerDialog()~~

> **centerDialog**(`el`): `void`

Defined in: [src/compat/layout.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L223)

Centers a jQuery UI dialog containing the given element within the viewport.
Compat shim for `Q.centerDialog`. Requires jQuery and jQuery UI `position`; clamps negative `left` / `top` to `0`.

## Parameters

### el

An element inside the dialog (e.g., `.ui-dialog-content`) or the dialog element itself; array-like collections use the first element.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`

## Deprecated

Prefer native dialog centering or Bootstrap modal positioning. Kept for legacy jQuery UI dialogs.
