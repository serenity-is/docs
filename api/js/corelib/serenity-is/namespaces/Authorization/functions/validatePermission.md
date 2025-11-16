[serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / validatePermission

# Function: validatePermission()

> **validatePermission**(`permission`): `void`

Defined in: [src/base/authorization.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L121)

Throws an error if the current user does not have the specified permission. 
Prefer `await validatePermissionAsync()` as this one might block the UI if the `UserData`
is not already loaded.

## Parameters

### permission

`string`

Permission key. It may contain logical operators like A&B|C.

## Returns

`void`
