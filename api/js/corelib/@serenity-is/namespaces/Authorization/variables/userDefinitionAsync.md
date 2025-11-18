[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / userDefinitionAsync

# Variable: userDefinitionAsync

> **userDefinitionAsync**: `Promise`\<[`UserDefinition`](../../../../interfaces/UserDefinition.md)\>

Defined in: [src/base/authorization.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L200)

Returns the user data for currently logged user.

## Returns

User data for currently logged user.

## Example

```ts
if ((await Authorization.userDefinitionAsync).IsAdmin) {
    // do something
}
```
