[@serenity-is/corelib](../README.md) / UserDefinition

# Interface: UserDefinition

Defined in: [src/base/userdefinition.ts:1](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L1)

## Properties

### DisplayName?

> `optional` **DisplayName**: `string`

Defined in: [src/base/userdefinition.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L9)

Display name of the logged user

***

### IsAdmin?

> `optional` **IsAdmin**: `boolean`

Defined in: [src/base/userdefinition.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L13)

This indicates that the user is a super "admin", e.g. assumed to have all the permissions available. 
It does not mean a member of Administrators, who might not have some of the permissions

***

### Permissions?

> `optional` **Permissions**: `object`

Defined in: [src/base/userdefinition.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L19)

A hashset of permission keys that the current user have, explicitly assigned or via its
roles. Note that client side permission checks should only be used for UI enable/disable etc.
You should not rely on client side permission checks and always re-check permissions server side.

#### Index Signature

\[`key`: `string`\]: `boolean`

***

### Username?

> `optional` **Username**: `string`

Defined in: [src/base/userdefinition.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L5)

Username of the logged user
