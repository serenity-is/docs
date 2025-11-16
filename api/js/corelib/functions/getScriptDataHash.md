[corelib](../README.md) / getScriptDataHash

# Function: getScriptDataHash()

> **getScriptDataHash**(`name`, `reload?`): `string`

Defined in: [src/base/scriptdata.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L19)

Gets the known hash value for a given dynamic script name. They are usually
registered server-side via dynamic script manager and their latest known
hashes are passed to the client-side via a script element named RegisteredScripts.

## Parameters

### name

`string`

The dynamic script name

### reload?

`boolean`

True to force resetting the script hash client side, e.g. for loading
lookups etc.

## Returns

`string`

The hash or null if no such known registration
