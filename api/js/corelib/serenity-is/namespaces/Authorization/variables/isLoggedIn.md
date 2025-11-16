[serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isLoggedIn

# Variable: isLoggedIn

> **isLoggedIn**: `boolean`

Defined in: [src/base/authorization.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L152)

Checks if the current user is logged in. Prefer `isLoggedInAsync` as this one might block the UI if the `UserData`
is not already loaded.

## Returns

`true` if the user is logged in, `false` otherwise.

## Example

```ts
if (Authorization.isLoggedIn) {
    // do something
}
```
