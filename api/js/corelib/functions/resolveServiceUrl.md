[@serenity-is/corelib](../README.md) / resolveServiceUrl

# Function: resolveServiceUrl()

> **resolveServiceUrl**(`url`): `string`

Defined in: [src/base/services.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L26)

Resolves a Serenity service endpoint to a full URL.
Bare service keys like `"Administration/User/List"` are prefixed with `~/Services/`;
already rooted (`~/`, `/`) or absolute (`://`) URLs are resolved via [resolveUrl](resolveUrl.md) unchanged.

## Parameters

### url

`string`

Service key or URL.

## Returns

`string`

The resolved service URL.
