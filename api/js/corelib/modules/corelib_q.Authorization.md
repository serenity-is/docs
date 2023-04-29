[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / Authorization

# Namespace: Authorization

[corelib/q](corelib_q.md).Authorization

Contains permission related functions.

## Note
We use a namespace here both for compatibility and for allowing users to override
these functions easily in ES modules environment, which is normally hard to do.

## Table of contents

### Variables

- [isLoggedIn](corelib_q.Authorization.md#isloggedin)
- [isLoggedInAsync](corelib_q.Authorization.md#isloggedinasync)
- [userDefinition](corelib_q.Authorization.md#userdefinition)
- [userDefinitionAsync](corelib_q.Authorization.md#userdefinitionasync)
- [username](corelib_q.Authorization.md#username)
- [usernameAsync](corelib_q.Authorization.md#usernameasync)

### Functions

- [hasPermission](corelib_q.Authorization.md#haspermission)
- [hasPermissionAsync](corelib_q.Authorization.md#haspermissionasync)
- [isPermissionInSet](corelib_q.Authorization.md#ispermissioninset)
- [validatePermission](corelib_q.Authorization.md#validatepermission)
- [validatePermissionAsync](corelib_q.Authorization.md#validatepermissionasync)

## Variables

### isLoggedIn

• **isLoggedIn**: `boolean`

#### Defined in

[src/q/authorization.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;131)

___

### isLoggedInAsync

• **isLoggedInAsync**: `Promise`<`boolean`\>

#### Defined in

[src/q/authorization.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;132)

___

### userDefinition

• **userDefinition**: [`UserDefinition`](../interfaces/corelib_q.UserDefinition.md)

#### Defined in

[src/q/authorization.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;135)

___

### userDefinitionAsync

• **userDefinitionAsync**: `Promise`<[`UserDefinition`](../interfaces/corelib_q.UserDefinition.md)\>

#### Defined in

[src/q/authorization.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;136)

___

### username

• **username**: `string`

#### Defined in

[src/q/authorization.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;133)

___

### usernameAsync

• **usernameAsync**: `Promise`<`string`\>

#### Defined in

[src/q/authorization.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;134)

## Functions

### hasPermission

▸ **hasPermission**(`permission`): `boolean`

Checks if the current user has the permission specified.
This should only be used for UI purposes and it is strongly recommended to check permissions server side.

> Please prefer the `hasPermissionAsync` variant as this may block the UI thread if the `UserData` script is not already loaded.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `permission` | `string` | Permission key. It may contain logical operators like A&B\|C. |

#### Returns

`boolean`

`false` for "null or undefined", true for "*", `IsLoggedIn` for "?". For other permissions, 
if the user has the permission or if the user has the `IsAdmin` flag (super admin) `true`, otherwise `false`.

#### Defined in

[src/q/authorization.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;26)

___

### hasPermissionAsync

▸ **hasPermissionAsync**(`permission`): `Promise`<`boolean`\>

Checks if the current user has the permission specified.
This should only be used for UI purposes and it is strongly recommended to check permissions server side.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `permission` | `string` | Permission key. It may contain logical operators like A&B\|C. |

#### Returns

`Promise`<`boolean`\>

`false` for "null or undefined", true for "*", `IsLoggedIn` for "?". For other permissions, 
if the user has the permission or if the user has the `IsAdmin` flag (super admin) `true`, otherwise `false`.

#### Defined in

[src/q/authorization.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;57)

___

### isPermissionInSet

▸ **isPermissionInSet**(`permissionSet`, `permission`): `boolean`

Checks if the hashset contains the specified permission, also handling logical "|" and "&" operators

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `permissionSet` | `Object` | Set of permissions |
| `permission` | `string` | Permission key or a permission expression containing & \| operators |

#### Returns

`boolean`

true if set contains permission

#### Defined in

[src/q/authorization.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;83)

___

### validatePermission

▸ **validatePermission**(`permission`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `permission` | `string` |

#### Returns

`void`

#### Defined in

[src/q/authorization.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;115)

___

### validatePermissionAsync

▸ **validatePermissionAsync**(`permission`): `Promise`<`void`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `permission` | `string` |

#### Returns

`Promise`<`void`\>

#### Defined in

[src/q/authorization.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#line&#x3D;122)
