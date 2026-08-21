[@serenity-is/corelib](../README.md) / requestFinished

# Function: requestFinished()

> **requestFinished**(): `void`

Defined in: [src/base/services.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L119)

Signals that an AJAX / service request has finished.
Decrements the active-request counter and triggers `ajaxStop` when the count reaches zero.

## Returns

`void`
