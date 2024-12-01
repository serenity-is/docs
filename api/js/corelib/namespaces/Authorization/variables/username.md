[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / username

# Variable: username

> **username**: `string`

Returns the username for currently logged user. Prefer `usernameAsync` as this one might block the UI if the `UserData`
is not already loaded.

## Returns

Username for currently logged user.

## Example

```ts
if (Authorization.username) {
    // do something
}
```

## Defined in

[src/q/authorization.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L171)
