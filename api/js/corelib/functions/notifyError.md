[@serenity-is/corelib](../README.md) / notifyError

# Function: notifyError()

> **notifyError**(`message`, `title?`, `options?`): `void`

Defined in: [src/base/notify.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L72)

Shows an error toast notification.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Main content of the toast. Accepts a plain string or [RenderableContent](../type-aliases/RenderableContent.md) (DOM nodes/fragments are handled by the underlying toastr renderer).

### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title/header displayed above the message.

### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-call toastr overrides merged over [defaultNotifyOptions](../variables/defaultNotifyOptions.md). Use to customize timeout, position, or `escapeHtml` for this toast only.

## Returns

`void`

## Example

```ts
notifyError("Failed to save record.", "Error");
```
