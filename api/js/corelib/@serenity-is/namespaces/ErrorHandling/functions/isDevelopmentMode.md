[@serenity-is/corelib](../../../../README.md) / [ErrorHandling](../README.md) / isDevelopmentMode

# Function: isDevelopmentMode()

> **isDevelopmentMode**(): `boolean`

Defined in: [src/base/errorhandling.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L123)

Determines whether the current host should be treated as a development environment.

## Returns

`boolean`

`true` when `window.location.hostname` is `localhost`, `127.0.0.1`, `[::1]`, or ends with `.local` / `.localhost`; `false` otherwise.

## Remarks

Both [ErrorHandling.runtimeErrorHandler](runtimeErrorHandler.md) and [ErrorHandling.unhandledRejectionHandler](unhandledRejectionHandler.md) gate their notifications on this check.
Override by replacing `ErrorHandling.isDevelopmentMode` at startup if a different heuristic is needed.
