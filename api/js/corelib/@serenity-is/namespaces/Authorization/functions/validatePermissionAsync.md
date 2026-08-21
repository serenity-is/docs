[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / validatePermissionAsync

# Function: validatePermissionAsync()

> **validatePermissionAsync**(`permission`): `Promise`\<`void`\>

Defined in: [src/base/authorization.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L188)

Asynchronously validates that the current user has the specified permission.

## Parameters

### permission

`string`

Permission key or expression with `&`/`|` operators.

## Returns

`Promise`\<`void`\>

Promise that resolves if authorized, or rejects/throws if not.

## Remarks

Awaits [Authorization.hasPermissionAsync](hasPermissionAsync.md) and, on failure, shows a
localized "Access Denied" notification before throwing.

## Throws

Error with localized "Authorization.AccessDenied" message if the user lacks the permission.

## Example

```ts
await Authorization.validatePermissionAsync("A&B|C");
```
