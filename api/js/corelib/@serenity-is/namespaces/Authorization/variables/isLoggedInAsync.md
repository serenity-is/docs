[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isLoggedInAsync

# Variable: isLoggedInAsync

> **isLoggedInAsync**: `Promise`\<`boolean`\>

Defined in: [src/base/authorization.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L221)

Whether the current user is logged in (asynchronous).

## Remarks

Awaits [Authorization.userDefinitionAsync](userDefinitionAsync.md) so it never blocks the UI thread.

## Example

```ts
if (await Authorization.isLoggedInAsync) {
    // user is authenticated
}
```
