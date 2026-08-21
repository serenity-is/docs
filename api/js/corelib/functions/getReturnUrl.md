[@serenity-is/corelib](../README.md) / getReturnUrl

# Function: getReturnUrl()

> **getReturnUrl**(`opt?`): `string`

Defined in: [src/base/html.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L260)

Retrieves the `returnUrl` from the current query string, falling back to application config.

## Parameters

### opt?

Options controlling lookup behavior.

#### ignoreUnsafe?

`boolean`

Whether to ignore unsafe URLs. If false or null (default), the function will only return safe URLs.

#### purpose?

`string`

The purpose of the return URL. This can be used to determine the default return URL if none is found in the query string.

#### queryOnly?

`boolean`

Whether to only consider the query string. If true, the function will not check the default return URL.

## Returns

`string`

The validated return URL, the configured default, or `null`/`undefined` if none is available or the query value is unsafe.
