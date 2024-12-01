[@serenity-is/corelib](../../../README.md) / [ErrorHandling](../README.md) / runtimeErrorHandler

# Function: runtimeErrorHandler()

> **runtimeErrorHandler**(`message`, `filename`?, `lineno`?, `colno`?, `error`?): `void`

Runtime error handler that shows a runtime error as a notification
by default only in development mode (@see isDevelopmentMode)
This function is assigned as window.onerror handler in 
ScriptInit.ts for Serenity applications so that developers
can notice an error without having to check the browser console.

## Parameters

### message

`string`

### filename?

`string`

### lineno?

`number`

### colno?

`number`

### error?

`Error`

## Returns

`void`

## Defined in

[src/base/errorhandling.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L48)
