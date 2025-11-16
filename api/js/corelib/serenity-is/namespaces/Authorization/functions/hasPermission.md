[serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / hasPermission

# Function: hasPermission()

> **hasPermission**(`permission`): `boolean`

Defined in: [src/base/authorization.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L26)

Checks if the current user has the permission specified.
This should only be used for UI purposes and it is strongly recommended to check permissions server side.

> Please prefer the `hasPermissionAsync` variant as this may block the UI thread if the `UserData` script is not already loaded.

## Parameters

### permission

`string`

Permission key. It may contain logical operators like A&B|C.

## Returns

`boolean`

`false` for "null or undefined", true for "*", `IsLoggedIn` for "?". For other permissions, 
if the user has the permission or if the user has the `IsAdmin` flag (super admin) `true`, otherwise `false`.
