[@serenity-is/corelib](../README.md) / UserDefinition

# Interface: UserDefinition

Defined in: [src/base/userdefinition.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L5)

Describes the currently authenticated user as resolved on the client.
Typically populated from the server's user definition script.

## Properties

### DisplayName?

> `optional` **DisplayName**: `string`

Defined in: [src/base/userdefinition.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L9)

Human-readable display name of the current user.

***

### IsAdmin?

> `optional` **IsAdmin**: `boolean`

Defined in: [src/base/userdefinition.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L15)

Whether the user is a super-admin with implicit access to all permissions.
This is distinct from membership in an Administrators role, which may not
grant every permission individually.

***

### Permissions?

> `optional` **Permissions**: `object`

Defined in: [src/base/userdefinition.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L21)

Map of permission keys granted to the user (explicitly or via roles).
Client-side checks should only drive UI enable/disable; always re-validate
permissions on the server.

#### Index Signature

\[`key`: `string`\]: `boolean`

***

### Username?

> `optional` **Username**: `string`

Defined in: [src/base/userdefinition.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/userdefinition.ts#L7)

Username / login name of the current user.
