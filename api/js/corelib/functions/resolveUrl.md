[@serenity-is/corelib](../README.md) / resolveUrl

# Function: resolveUrl()

> **resolveUrl**(`url`): `string`

Defined in: [src/base/services.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L13)

Resolves a `~/`-prefixed application-relative URL against [Config.applicationPath](../variables/Config.md#applicationpath).
Non-tilde URLs are returned unchanged.

## Parameters

### url

`string`

URL to resolve; may be `null`/`undefined` or already absolute.

## Returns

`string`

The resolved absolute / root-relative URL.
