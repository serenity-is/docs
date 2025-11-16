[corelib](../../../../README.md) / [Authorization](../README.md) / username

# Variable: username

> **username**: `string`

Defined in: [src/base/authorization.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L172)

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
