[@serenity-is/corelib](../../../README.md) / [Authorization](../README.md) / usernameAsync

# Variable: usernameAsync

> **usernameAsync**: `Promise`\<`string`\>

Returns the username for currently logged user.

## Returns

Username for currently logged user.

## Example

```ts
if (await Authorization.usernameAsync) {
    // do something
}
```

## Defined in

[src/q/authorization.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/authorization.ts#L180)
