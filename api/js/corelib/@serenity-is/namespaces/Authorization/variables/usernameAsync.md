[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / usernameAsync

# Variable: usernameAsync

> **usernameAsync**: `Promise`\<`string`\>

Defined in: [src/base/authorization.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L243)

Username of the currently logged-in user (asynchronous).

## Remarks

Awaits [Authorization.userDefinitionAsync](userDefinitionAsync.md).

## Example

```ts
const name = await Authorization.usernameAsync;
```
