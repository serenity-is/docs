[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / validatePermission

# Function: validatePermission()

> **validatePermission**(`permission`): `void`

Defined in: [src/base/authorization.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L169)

Synchronously validates that the current user has the specified permission.

## Parameters

### permission

`string`

Permission key or expression with `&`/`|` operators.

## Returns

`void`

## Remarks

Shows a localized "Access Denied" notification and throws if the check fails.
Prefer [Authorization.validatePermissionAsync](validatePermissionAsync.md) to avoid potentially
blocking on `UserData` loading. Use only for UI gating.

## Throws

Error with localized "Authorization.AccessDenied" message if the user lacks the permission.

## Example

```ts
Authorization.validatePermission("Administration:General");
```
