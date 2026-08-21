[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / userDefinition

# Variable: userDefinition

> **userDefinition**: [`UserDefinition`](../../../../interfaces/UserDefinition.md)

Defined in: [src/base/authorization.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L257)

User definition for the currently logged-in user (synchronous).

## Remarks

Retrieved via [getRemoteData](../../../../functions/getRemoteData.md)`("UserData")`. This may trigger a
synchronous load if not cached — prefer [Authorization.userDefinitionAsync](userDefinitionAsync.md).
Returns `undefined`/`null` when not logged in.

## Example

```ts
if (Authorization.userDefinition?.IsAdmin) {
    // super-admin branch
}
```
