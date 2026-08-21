[@serenity-is/corelib](../../../../README.md) / [ErrorHandling](../README.md) / unhandledRejectionHandler

# Function: unhandledRejectionHandler()

> **unhandledRejectionHandler**(`err`): `void`

Defined in: [src/base/errorhandling.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/errorhandling.tsx#L143)

Handler for `unhandledrejection` events that filters expected service errors and surfaces real bugs during development.

## Parameters

### err

`PromiseRejectionEvent`

The `PromiseRejectionEvent` fired by the browser.

## Returns

`void`

## Remarks

- When `err.reason.origin === "serviceCall"` (Serenity service layer), the rejection is suppressed via `preventDefault()` and, unless `silent` or `kind !== "exception"`, logged to the console. This avoids noisy console errors for handled service failures.
- For all other rejections, a notification is shown only when [ErrorHandling.isDevelopmentMode](isDevelopmentMode.md) returns `true`.

## Example

```ts
window.addEventListener("unhandledrejection", ErrorHandling.unhandledRejectionHandler);
```
