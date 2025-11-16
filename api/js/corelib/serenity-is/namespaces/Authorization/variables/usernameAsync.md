[serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / usernameAsync

# Variable: usernameAsync

> **usernameAsync**: `Promise`\<`string`\>

Defined in: [src/base/authorization.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L181)

Returns the username for currently logged user.

## Returns

Username for currently logged user.

## Example

```ts
if (await Authorization.usernameAsync) {
    // do something
}
```
