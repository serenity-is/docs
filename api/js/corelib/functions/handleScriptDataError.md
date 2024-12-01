[@serenity-is/corelib](../README.md) / handleScriptDataError

# Function: handleScriptDataError()

> **handleScriptDataError**(`name`, `status`?, `statusText`?, `shouldThrow`?): `string`

Shows a suitable error message for errors occured during loading of
a dynamic script data.

## Parameters

### name

`string`

Name of the dynamic script

### status?

`number`

HTTP status returned if available

### statusText?

`string`

HTTP status text returned if available

### shouldThrow?

`boolean` = `true`

## Returns

`string`

## Defined in

[src/base/scriptdata.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L190)
