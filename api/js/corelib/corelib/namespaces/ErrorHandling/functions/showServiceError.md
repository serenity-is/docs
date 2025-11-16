[corelib](../../../../README.md) / [ErrorHandling](../README.md) / showServiceError

# Function: showServiceError()

> **showServiceError**(`error`, `errorInfo?`, `errorMode?`): `void`

Defined in: [src/base/errorhandling.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L14)

Shows a service error as an alert dialog / notification. If the error
is null, has no message or code, it shows a generic error message.

## Parameters

### error

[`ServiceError`](../../../../interfaces/ServiceError.md)

### errorInfo?

[`RequestErrorInfo`](../../../../interfaces/RequestErrorInfo.md)

### errorMode?

`"alert"` | `"notification"`

## Returns

`void`
