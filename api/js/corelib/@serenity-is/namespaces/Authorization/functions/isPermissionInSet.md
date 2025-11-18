[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isPermissionInSet

# Function: isPermissionInSet()

> **isPermissionInSet**(`permissionSet`, `permission`): `boolean`

Defined in: [src/base/authorization.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L83)

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
