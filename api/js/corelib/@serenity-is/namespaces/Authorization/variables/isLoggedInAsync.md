[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isLoggedInAsync

# Variable: isLoggedInAsync

> **isLoggedInAsync**: `Promise`\<`boolean`\>

Defined in: [src/base/authorization.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L162)

Checks if the current user is logged in.

## Returns

`true` if the user is logged in, `false` otherwise.

## Example

```ts
if (await Authorization.isLoggedInAsync) {
    // do something
}
```
