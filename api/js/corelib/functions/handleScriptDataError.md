[@serenity-is/corelib](../README.md) / handleScriptDataError

# Function: handleScriptDataError()

> **handleScriptDataError**(`name`, `status?`, `statusText?`, `shouldThrow?`): `string`

Defined in: [src/base/scriptdata.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/scriptdata.ts#L265)

Shows a suitable error message for errors occurred during loading of a dynamic script data.

## Parameters

### name

`string`

Name of the dynamic script.

### status?

`number`

HTTP status returned if available.

### statusText?

`string`

HTTP status text returned if available.

### shouldThrow?

`boolean` = `true`

When `true` (default) throws the error message after notifying; when `false` only notifies and returns.

## Returns

`string`

The error message string.
