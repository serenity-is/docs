[@serenity-is/corelib](../README.md) / getServiceOptions

# Function: getServiceOptions()

> **getServiceOptions**\<`TResponse`\>(`options`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

Defined in: [src/base/services.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L76)

Normalizes and enriches a [ServiceOptions](../interfaces/ServiceOptions.md) object with defaults and derived values.
Applies default `method` (`POST`), `allowRedirect`/`async`/`blockUI` flags, resolves `service`/`url`,
and injects `Accept`, `Content-Type` and same-origin `X-CSRF-TOKEN` headers.

## Type Parameters

### TResponse

`TResponse` *extends* [`ServiceResponse`](../interfaces/ServiceResponse.md)

Expected service response type.

## Parameters

### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

Raw service options supplied by the caller.

## Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<`TResponse`\>

The normalized options object with `url` resolved and `headers` populated.
