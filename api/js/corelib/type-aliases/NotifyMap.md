[@serenity-is/corelib](../README.md) / NotifyMap

# Type Alias: NotifyMap

> **NotifyMap** = `object`

Defined in: [src/base/toastr2.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L70)

Internal descriptor for a toast notification passed to Toastr.notify.

## Properties

### iconClass

> **iconClass**: `string`

Defined in: [src/base/toastr2.tsx:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L74)

CSS class for the toast icon corresponding to the type.

***

### message?

> `optional` **message**: [`RenderableContent`](RenderableContent.md)

Defined in: [src/base/toastr2.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L78)

Optional message content for the toast.

***

### title?

> `optional` **title**: [`RenderableContent`](RenderableContent.md)

Defined in: [src/base/toastr2.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L76)

Optional title content for the toast.

***

### type

> **type**: `string`

Defined in: [src/base/toastr2.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/toastr2.tsx#L72)

Toast type key (`"success"` | `"info"` | `"warning"` | `"error"`).
