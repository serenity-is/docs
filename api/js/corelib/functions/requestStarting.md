[@serenity-is/corelib](../README.md) / requestStarting

# Function: requestStarting()

> **requestStarting**(): `void`

Defined in: [src/base/services.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L104)

Signals that an AJAX / service request has started.
Increments the internal active-request counter and triggers `ajaxStart` on jQuery (if present) or dispatches an `ajaxStart` DOM event. Used internally by `serviceFetch` / `serviceCall` and script-data loaders.

## Returns

`void`
