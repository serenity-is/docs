[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / hasPermissionAsync

# Function: hasPermissionAsync()

> **hasPermissionAsync**(`permission`): `Promise`\<`boolean`\>

Defined in: [src/base/authorization.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L88)

Asynchronously checks whether the current user has the specified permission.

## Parameters

### permission

`string`

Permission key or expression with `&`/`|` operators,
e.g. `"A&B|C"`. `null`/`undefined` returns `false`; `"*"` returns `true`;
`""` or `"?"` returns whether the user is logged in.

## Returns

`Promise`\<`boolean`\>

Promise that resolves to `true` if the user has the permission
(or is an admin), otherwise `false`.

## Remarks

Preferred over [Authorization.hasPermission](hasPermission.md) because it awaits
`UserData` via [getRemoteDataAsync](../../../../functions/getRemoteDataAsync.md) instead of potentially blocking
the UI thread. Still UI-only — enforce permissions server-side as well.

## Examples

```ts
if (await Authorization.hasPermissionAsync("Administration:General")) { ... }
```

```ts
await Authorization.hasPermissionAsync("A&B|C"); // true if (A and B) or C
```
