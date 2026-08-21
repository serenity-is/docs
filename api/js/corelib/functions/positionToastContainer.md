[@serenity-is/corelib](../README.md) / positionToastContainer

# Function: positionToastContainer()

> **positionToastContainer**(`options?`, `create?`): `void`

Defined in: [src/base/notify.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L27)

Positions the toast container relative to the topmost visible dialog, if any.
When a `.ui-dialog` / `.modal.in` / `.modal.show` element is found, the container is absolutely positioned just below it; otherwise any previous absolute positioning is cleared.

## Parameters

### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Toastr options used to locate the container (forwarded to `toastr.getContainer`).

### create?

`boolean` = `true`

Whether to create the container if it does not yet exist. Defaults to `true`.

## Returns

`void`

## Remarks

No-ops if the container has no `position-toast` class, or if `document`/`document.body` is unavailable (e.g. SSR).
