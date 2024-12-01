[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / userDefinitionAsync

# Variable: userDefinitionAsync

> **userDefinitionAsync**: `Promise`\<[`UserDefinition`](../../../interfaces/UserDefinition.md)\>

Returns the user data for currently logged user.

## Returns

User data for currently logged user.

## Example

```ts
if ((await Authorization.userDefinitionAsync).IsAdmin) {
    // do something
}
```

## Defined in

[src/q/authorization.ts:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L199)
