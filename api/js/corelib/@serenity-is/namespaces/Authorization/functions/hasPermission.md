[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / hasPermission

# Function: hasPermission()

> **hasPermission**(`permission`): `boolean`

Defined in: [src/base/authorization.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L48)

Synchronously checks whether the current user has the specified permission.

## Parameters

### permission

`string`

Permission key or expression. May contain `&` (AND) and `|` (OR)
operators, e.g. `"A&B|C"`. `null`/`undefined` returns `false`; `"*"` returns `true`;
`""` or `"?"` returns whether the user is logged in.

## Returns

`boolean`

`true` if the user has the permission (or is an admin), otherwise `false`.

## Remarks

Prefer [Authorization.hasPermissionAsync](hasPermissionAsync.md) in new code — this synchronous
variant may block the UI thread if the `UserData` script has not been loaded yet
(it falls back to [getRemoteData](../../../../functions/getRemoteData.md) which can issue a synchronous request).
Use only for UI gating; always enforce permissions server-side as well.

## Examples

```ts
Authorization.hasPermission("Administration:General"); // true if admin or granted
```

```ts
Authorization.hasPermission("A&B|C"); // true if (A and B) or C
```
