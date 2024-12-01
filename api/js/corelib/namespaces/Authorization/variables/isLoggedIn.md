[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / isLoggedIn

# Variable: isLoggedIn

> **isLoggedIn**: `boolean`

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

## Defined in

[src/q/authorization.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L151)
