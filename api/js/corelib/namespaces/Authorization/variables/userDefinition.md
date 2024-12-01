[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / userDefinition

# Variable: userDefinition

> **userDefinition**: [`UserDefinition`](../../../interfaces/UserDefinition.md)

Returns the user data for currently logged user. Prefer `userDefinitionAsync` as this one might block the UI if the `UserData`
is not already loaded.

## Returns

User data for currently logged user.

## Example

```ts
if (Authorization.userDefinition.IsAdmin) {
    // do something
}
```

## Defined in

[src/q/authorization.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L190)
