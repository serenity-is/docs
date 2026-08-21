[@serenity-is/corelib](../README.md) / peekScriptData

# Function: peekScriptData()

> **peekScriptData**(`name`): `any`

Defined in: [src/base/scriptdata.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L317)

Returns cached script data without triggering a fetch.

## Parameters

### name

`string`

Dynamic script name.

## Returns

`any`

The cached value or `undefined` if not loaded yet.
