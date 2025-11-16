[serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / validatePermissionAsync

# Function: validatePermissionAsync()

> **validatePermissionAsync**(`permission`): `Promise`\<`void`\>

Defined in: [src/base/authorization.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L134)

Throws an error if the current user does not have the specified permission.

## Parameters

### permission

`string`

Permission key. It may contain logical operators like A&B|C.

## Returns

`Promise`\<`void`\>

## Example

```ts
await Authorization.validatePermissionAsync("A&B|C");
```
