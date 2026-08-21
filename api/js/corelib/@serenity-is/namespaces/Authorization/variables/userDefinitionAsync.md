[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / userDefinitionAsync

# Variable: userDefinitionAsync

> **userDefinitionAsync**: `Promise`\<[`UserDefinition`](../../../../interfaces/UserDefinition.md)\>

Defined in: [src/base/authorization.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L269)

User definition for the currently logged-in user (asynchronous).

## Remarks

Retrieved via [getRemoteDataAsync](../../../../functions/getRemoteDataAsync.md)`("UserData")`.

## Example

```ts
if ((await Authorization.userDefinitionAsync)?.IsAdmin) {
    // super-admin branch
}
```
