[@serenity-is/corelib](../README.md) / ErrorHandling

# Namespace: ErrorHandling

## Table of contents

### Functions

- [isDevelopmentMode](ErrorHandling.md#isdevelopmentmode)
- [runtimeErrorHandler](ErrorHandling.md#runtimeerrorhandler)
- [showServiceError](ErrorHandling.md#showserviceerror)
- [unhandledRejectionHandler](ErrorHandling.md#unhandledrejectionhandler)

## Functions

### isDevelopmentMode

▸ **isDevelopmentMode**(): `boolean`

Determines if the current environment is development mode.
The runtimeErrorHandler (window.onerror) shows error notifications only
when this function returns true. The default implementation considers 
the environment as development mode if the host is localhost, 127.0.0.1, ::1,
or a domain name that ends with .local/.localhost.

#### Returns

`boolean`

true if the current environment is development mode, false otherwise.

#### Defined in

[src/base/errorhandling.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L76)

___

### runtimeErrorHandler

▸ **runtimeErrorHandler**(`message`, `filename?`, `lineno?`, `colno?`, `error?`): `void`

Runtime error handler that shows a runtime error as a notification
by default only in development mode (@see isDevelopmentMode)
This function is assigned as window.onerror handler in 
ScriptInit.ts for Serenity applications so that developers
can notice an error without having to check the browser console.

#### Parameters

| Name | Type |
| :------ | :------ |
| `message` | `string` |
| `filename?` | `string` |
| `lineno?` | `number` |
| `colno?` | `number` |
| `error?` | `Error` |

#### Returns

`void`

#### Defined in

[src/base/errorhandling.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L40)

___

### showServiceError

▸ **showServiceError**(`error`, `errorInfo?`): `void`

Shows a service error as an alert dialog. If the error
is null, has no message or code, it shows "??ERROR??".

#### Parameters

| Name | Type |
| :------ | :------ |
| `error` | [`ServiceError`](../interfaces/ServiceError.md) |
| `errorInfo?` | [`RequestErrorInfo`](../interfaces/RequestErrorInfo.md) |

#### Returns

`void`

#### Defined in

[src/base/errorhandling.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L12)

___

### unhandledRejectionHandler

▸ **unhandledRejectionHandler**(`err`): `void`

Unhandled promise rejection error handler. It's purpose is to
ignore logging serviceCall / serviceFetch errors as they have built-in
error handling but browser logs it in the console, while Node crashes.
Include below code in script-init/errorhandling.ts to enable:
window.addEventListener("unhandledrejection", ErrorHandling.unhandledRejectionHandler);

#### Parameters

| Name | Type |
| :------ | :------ |
| `err` | `PromiseRejectionEvent` |

#### Returns

`void`

#### Defined in

[src/base/errorhandling.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L92)
