[serenity-is/corelib](../../../../README.md) / [ErrorHandling](../README.md) / unhandledRejectionHandler

# Function: unhandledRejectionHandler()

> **unhandledRejectionHandler**(`err`): `void`

Defined in: [src/base/errorhandling.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L100)

Unhandled promise rejection error handler. It's purpose is to
ignore logging serviceCall / serviceFetch errors as they have built-in
error handling but browser logs it in the console, while Node crashes.
Include below code in script-init/errorhandling.ts to enable:
window.addEventListener("unhandledrejection", ErrorHandling.unhandledRejectionHandler);

## Parameters

### err

`PromiseRejectionEvent`

## Returns

`void`
