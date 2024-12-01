[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / isPermissionInSet

# Function: isPermissionInSet()

> **isPermissionInSet**(`permissionSet`, `permission`): `boolean`

Checks if the hashset contains the specified permission, also handling logical "|" and "&" operators

## Parameters

### permissionSet

Set of permissions

### permission

`string`

Permission key or a permission expression containing & | operators

## Returns

`boolean`

true if set contains permission

## Defined in

[src/q/authorization.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L82)
