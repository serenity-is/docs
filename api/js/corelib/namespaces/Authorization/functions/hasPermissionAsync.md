[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / hasPermissionAsync

# Function: hasPermissionAsync()

> **hasPermissionAsync**(`permission`): `Promise`\<`boolean`\>

Checks if the current user has the permission specified.
This should only be used for UI purposes and it is strongly recommended to check permissions server side.

## Parameters

### permission

`string`

Permission key. It may contain logical operators like A&B|C.

## Returns

`Promise`\<`boolean`\>

`false` for "null or undefined", true for "*", `IsLoggedIn` for "?". For other permissions, 
if the user has the permission or if the user has the `IsAdmin` flag (super admin) `true`, otherwise `false`.

## Defined in

[src/q/authorization.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L56)
