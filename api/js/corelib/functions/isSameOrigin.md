[@serenity-is/corelib](../README.md) / isSameOrigin

# Function: isSameOrigin()

> **isSameOrigin**(`url`): `boolean`

Defined in: [src/base/services.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L56)

Checks whether a URL is same-origin with the current page.
Used to decide whether to attach the `X-CSRF-TOKEN` header.

## Parameters

### url

`string`

URL to test (absolute or relative; relative URLs are resolved against `window.location.origin`).

## Returns

`boolean`

`true` if the URL shares hostname, port and protocol with `window.location`.
