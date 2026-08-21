[@serenity-is/corelib](../README.md) / setRegisteredScripts

# Function: setRegisteredScripts()

> **setRegisteredScripts**(`scripts`): `void`

Defined in: [src/base/scriptdata.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L337)

Seeds or updates the known script hashes (normally populated from the `RegisteredScripts` script tag).
Useful in tests or when bootstrapping hashes manually.

## Parameters

### scripts

`Record`\<`string`, `string`\>

Map of script name to hash string. Falsy hash values are replaced with the current timestamp.

## Returns

`void`
