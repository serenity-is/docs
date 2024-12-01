[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / isLoggedInAsync

# Variable: isLoggedInAsync

> **isLoggedInAsync**: `Promise`\<`boolean`\>

Checks if the current user is logged in.

## Returns

`true` if the user is logged in, `false` otherwise.

## Example

```ts
if (await Authorization.isLoggedInAsync) {
    // do something
}
```

## Defined in

[src/q/authorization.ts:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L161)
