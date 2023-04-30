[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / UserDefinition

# Interface: UserDefinition

[corelib/q](../modules/corelib_q.md).UserDefinition

## Table of contents

### Properties

- [DisplayName](corelib_q.UserDefinition.md#displayname)
- [IsAdmin](corelib_q.UserDefinition.md#isadmin)
- [Permissions](corelib_q.UserDefinition.md#permissions)
- [Username](corelib_q.UserDefinition.md#username)

## Properties

### DisplayName

• `Optional` **DisplayName**: `string`

Display name of the logged user

#### Defined in

[src/q/userdefinition.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/userdefinition.ts#L9)

___

### IsAdmin

• `Optional` **IsAdmin**: `boolean`

This indicates that the user is a super "admin", e.g. assumed to have all the permissions available. 
It does not mean a member of Administrators, who might not have some of the permissions

#### Defined in

[src/q/userdefinition.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/userdefinition.ts#L13)

___

### Permissions

• `Optional` **Permissions**: `Object`

A hashset of permission keys that the current user have, explicitly assigned or via its
roles. Note that client side permission checks should only be used for UI enable/disable etc.
You should not rely on client side permission checks and always re-check permissions server side.

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/q/userdefinition.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/userdefinition.ts#L19)

___

### Username

• `Optional` **Username**: `string`

Username of the logged user

#### Defined in

[src/q/userdefinition.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/userdefinition.ts#L5)
