[@serenity-is/corelib](../../../../README.md) / [ErrorHandling](../README.md) / showServiceError

# Function: showServiceError()

> **showServiceError**(`error`, `errorInfo?`, `errorMode?`): `void`

Defined in: [src/base/errorhandling.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L28)

Shows a service error to the user as an alert dialog or toast notification.

## Parameters

### error

[`ServiceError`](../../../../interfaces/ServiceError.md)

Structured service error returned by the server (`ServiceError`). May be `null` when the failure is transport-level.

### errorInfo?

[`RequestErrorInfo`](../../../../interfaces/RequestErrorInfo.md)

Low-level request metadata (HTTP status, `responseText`, etc.). When `error` is falsy, this determines the fallback message.

### errorMode?

Presentation mode. `"notification"` uses [notifyError](../../../../functions/notifyError.md); any other value (or omitted) uses [alertDialog](../../../../functions/alertDialog.md) / [iframeDialog](../../../../functions/iframeDialog.md).

`"alert"` | `"notification"`

## Returns

`void`

## Remarks

- When `error` has a `Message` or `Code`, that text is shown directly.
- When `error` is `null` and `errorInfo.statusText === "abort"`, the error is silently ignored.
- When `responseText` is HTML and `errorMode` is `"alert"`, it is rendered in an [iframeDialog](../../../../functions/iframeDialog.md); otherwise it is shown as a notification.
- In production, a "See browser console (F12)" hint is appended to generic HTTP errors.
