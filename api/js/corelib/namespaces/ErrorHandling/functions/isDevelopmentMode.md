[@serenity-is/corelib](../../../README.md) / [ErrorHandling](../README.md) / isDevelopmentMode

# Function: isDevelopmentMode()

> **isDevelopmentMode**(): `boolean`

Determines if the current environment is development mode.
The runtimeErrorHandler (window.onerror) shows error notifications only
when this function returns true. The default implementation considers 
the environment as development mode if the host is localhost, 127.0.0.1, ::1,
or a domain name that ends with .local/.localhost.

## Returns

`boolean`

true if the current environment is development mode, false otherwise.

## Defined in

[src/base/errorhandling.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.ts#L84)
