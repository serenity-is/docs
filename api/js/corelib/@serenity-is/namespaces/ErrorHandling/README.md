[@serenity-is/corelib](../../../README.md) / ErrorHandling

# ErrorHandling

Centralized error handling helpers for service and runtime errors.

## Remarks

`showServiceError` is the default handler for failed service calls;
`runtimeErrorHandler` / `unhandledRejectionHandler` surface uncaught
script errors during development only (see [ErrorHandling.isDevelopmentMode](functions/isDevelopmentMode.md)).

## Functions

- [isDevelopmentMode](functions/isDevelopmentMode.md)
- [runtimeErrorHandler](functions/runtimeErrorHandler.md)
- [showServiceError](functions/showServiceError.md)
- [unhandledRejectionHandler](functions/unhandledRejectionHandler.md)
