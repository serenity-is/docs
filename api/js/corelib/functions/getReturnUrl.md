[@serenity-is/corelib](../README.md) / getReturnUrl

# Function: getReturnUrl()

> **getReturnUrl**(`opt?`): `string`

Defined in: [src/base/html.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L219)

Gets the return URL from the query string.

## Parameters

### opt?

Options for getting the return URL.

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
