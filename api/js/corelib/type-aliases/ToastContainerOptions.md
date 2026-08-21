[@serenity-is/corelib](../README.md) / ToastContainerOptions

# Type Alias: ToastContainerOptions

> **ToastContainerOptions** = `object`

Defined in: [src/base/toastr2.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L8)

Options that control the toast container element.
Shared by individual toast calls and the global [Toastr](../classes/Toastr.md) defaults.

## Properties

### containerId?

> `optional` **containerId**: `string`

Defined in: [src/base/toastr2.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L10)

DOM id for the container that holds toasts. Defaults to `"toast-container"`.

***

### positionClass?

> `optional` **positionClass**: `string`

Defined in: [src/base/toastr2.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L12)

CSS class applied to the container for positioning (e.g. `"toast-top-right"`).

***

### target?

> `optional` **target**: `string`

Defined in: [src/base/toastr2.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L14)

CSS selector for the parent element the container is appended to. Defaults to `"body"`.
