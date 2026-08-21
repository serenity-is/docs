[@serenity-is/corelib](../README.md) / notifySuccess

# Function: notifySuccess()

> **notifySuccess**(`message`, `title?`, `options?`): `void`

Defined in: [src/base/notify.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/notify.ts#L100)

Shows a success toast notification.

## Parameters

### message

[`RenderableContent`](../type-aliases/RenderableContent.md)

Main content of the toast.

### title?

[`RenderableContent`](../type-aliases/RenderableContent.md)

Optional title displayed above the message.

### options?

[`ToastrOptions`](../type-aliases/ToastrOptions.md)

Per-call toastr overrides merged over [defaultNotifyOptions](../variables/defaultNotifyOptions.md).

## Returns

`void`

## Example

```ts
notifySuccess("Record created successfully.", "Done");
```
