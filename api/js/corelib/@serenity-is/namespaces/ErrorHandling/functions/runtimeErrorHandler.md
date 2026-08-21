[@serenity-is/corelib](../../../../README.md) / [ErrorHandling](../README.md) / runtimeErrorHandler

# Function: runtimeErrorHandler()

> **runtimeErrorHandler**(`messageOrEvent`, `filename?`, `lineno?`, `colno?`, `error?`): `void`

Defined in: [src/base/errorhandling.tsx:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L67)

Global runtime error handler suitable for `window.onerror`.

## Parameters

### messageOrEvent

Error message string, or the `ErrorEvent` dispatched by the browser.

`string` | `ErrorEvent`

### filename?

`string`

Source file URL when the handler is invoked with discrete arguments (`window.onerror` signature).

### lineno?

`number`

One-based line number of the error.

### colno?

`number`

One-based column number of the error.

### error?

`Error`

The associated `Error` object, when available.

## Returns

`void`

## Remarks

Only surfaces a notification when [ErrorHandling.isDevelopmentMode](isDevelopmentMode.md) returns `true`; otherwise the error is ignored.
The handler is wired as `window.onerror` in `ScriptInit.ts` so developers notice failures without opening the console.
The displayed notification includes file, line/column, message, and stack trace when available.
