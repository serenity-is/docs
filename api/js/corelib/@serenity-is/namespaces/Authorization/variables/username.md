[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / username

# Variable: username

> **username**: `string`

Defined in: [src/base/authorization.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L233)

Username of the currently logged-in user (synchronous).

## Remarks

Getter over [Authorization.userDefinition](userDefinition.md)`.Username`. Prefer
[Authorization.usernameAsync](usernameAsync.md) if `UserData` may not be loaded yet.
Returns `undefined` when no user is logged in.

## Example

```ts
const name = Authorization.username;
```
