[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / ErrorHandling

# Namespace: ErrorHandling

[corelib/q](corelib_q.md).ErrorHandling

## Table of contents

### Functions

- [isDevelopmentMode](corelib_q.ErrorHandling.md#isdevelopmentmode)
- [runtimeErrorHandler](corelib_q.ErrorHandling.md#runtimeerrorhandler)
- [showServiceError](corelib_q.ErrorHandling.md#showserviceerror)

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

[src/q/errorhandling.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/errorhandling.ts#L59)

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

[src/q/errorhandling.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/errorhandling.ts#L23)

___

### showServiceError

▸ **showServiceError**(`error`): `void`

Shows a service error as an alert dialog. If the error
is null, has no message or code, it shows "??ERROR??".

#### Parameters

| Name | Type |
| :------ | :------ |
| `error` | [`ServiceError`](../interfaces/corelib_q.ServiceError.md) |

#### Returns

`void`

#### Defined in

[src/q/errorhandling.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/errorhandling.ts#L12)
