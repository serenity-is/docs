[@serenity-is/corelib](../README.md) / ToastrOptions

# Type Alias: ToastrOptions

> **ToastrOptions** = [`ToastContainerOptions`](ToastContainerOptions.md) & `object`

Defined in: [src/base/toastr2.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L21)

Full option set for a toast notification. Extends [ToastContainerOptions](ToastContainerOptions.md)
with display, timing, styling, and lifecycle callbacks.

## Type Declaration

### closeButton?

> `optional` **closeButton**: `boolean` \| `HTMLElement`

Show a close button, default is false. Pass an HTMLElement for a custom button element.

### closeClass?

> `optional` **closeClass**: `string`

CSS class for the close button. Defaults to `"toast-close-button"`.

### closeOnHover?

> `optional` **closeOnHover**: `boolean`

If `true` (default) the toast stays open while hovered and closes after ToastrOptions.extendedTimeOut when the mouse leaves.

### ~~escapeHtml?~~

> `optional` **escapeHtml**: `boolean`

#### Deprecated

Escape message html, default is true. Pass an HTML element to message instead.

### extendedTimeOut?

> `optional` **extendedTimeOut**: `number`

Timeout in ms after mouse-leave before the toast closes when ToastrOptions.closeOnHover is enabled. Defaults to `1000`.

### iconClass?

> `optional` **iconClass**: `string`

CSS class for the toast icon (e.g. `"toast-info"`, `"toast-error"`).

### messageClass?

> `optional` **messageClass**: `string`

CSS class for the message element. Defaults to `"toast-message"`.

### newestOnTop?

> `optional` **newestOnTop**: `boolean`

When `true` the newest toast is inserted at the top of the container.

### onclick()?

> `optional` **onclick**: (`event`) => `void`

Callback invoked when the toast element is clicked.

#### Parameters

##### event

`MouseEvent`

#### Returns

`void`

### onCloseClick()?

> `optional` **onCloseClick**: (`event`) => `void`

Callback invoked when the close button is clicked.

#### Parameters

##### event

`Event`

#### Returns

`void`

### onHidden()?

> `optional` **onHidden**: () => `void`

Callback invoked after the toast is hidden and removed.

#### Returns

`void`

### onShown()?

> `optional` **onShown**: () => `void`

Callback invoked after the toast is shown.

#### Returns

`void`

### positionClass?

> `optional` **positionClass**: `string`

CSS class for toast positioning (also on container). Defaults to `"toast-top-right"`.

### preventDuplicates?

> `optional` **preventDuplicates**: `boolean`

When `true` suppresses consecutive toasts with identical messages. Defaults to `false`.

### preWrap?

> `optional` **preWrap**: `boolean`

When `true` the toast message element is styled with `white-space: pre-wrap`.

### rtl?

> `optional` **rtl**: `boolean`

Enables right-to-left layout for the toast.

### tapToDismiss?

> `optional` **tapToDismiss**: `boolean`

When `true` (default) clicking the toast dismisses it.

### target?

> `optional` **target**: `string`

CSS selector for the parent element that hosts the container. Defaults to `"body"`.

### timeOut?

> `optional` **timeOut**: `number`

Duration in ms the toast stays visible. Set to `0` for sticky or `-1` to disable auto-hide (extended timeout is then ignored). Defaults to `5000`.

### titleClass?

> `optional` **titleClass**: `string`

CSS class for the title element. Defaults to `"toast-title"`.

### toastClass?

> `optional` **toastClass**: `string`

CSS class for the toast element itself. Defaults to `"toast"`.
