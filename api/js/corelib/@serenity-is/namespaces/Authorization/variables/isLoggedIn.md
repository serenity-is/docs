[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isLoggedIn

# Variable: isLoggedIn

> **isLoggedIn**: `boolean`

Defined in: [src/base/authorization.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L209)

Whether the current user is logged in (synchronous).

## Remarks

Implemented as a getter over [Authorization.userDefinition](userDefinition.md). Prefer
[Authorization.isLoggedInAsync](isLoggedInAsync.md) to avoid blocking on `UserData` load.
Returns `true` when `UserDefinition.Username` is truthy.

## Example

```ts
if (Authorization.isLoggedIn) {
    // user is authenticated
}
```
