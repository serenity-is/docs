[@serenity-is/corelib](../README.md) / setScriptData

# Function: setScriptData()

> **setScriptData**(`name`, `value`): `void`

Defined in: [src/base/scriptdata.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L352)

Stores a script data value in the in-memory cache and dispatches a `scriptdatachange.<name>` DOM event.

## Parameters

### name

`string`

Dynamic script name.

### value

`any`

Value to cache (use `undefined` to clear).

## Returns

`void`
