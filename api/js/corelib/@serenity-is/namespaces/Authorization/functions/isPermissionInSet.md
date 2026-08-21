[@serenity-is/corelib](../../../../README.md) / [Authorization](../README.md) / isPermissionInSet

# Function: isPermissionInSet()

> **isPermissionInSet**(`permissionSet`, `permission`): `boolean`

Defined in: [src/base/authorization.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/authorization.ts#L125)

Tests whether a permission hash-set contains the specified permission or expression.

## Parameters

### permissionSet

Dictionary of granted permissions (key → `true`). `null`/`undefined` yields `false`.

### permission

`string`

Permission key or expression with `&`/`|` operators. `null` returns `false`.

## Returns

`boolean`

`true` if the permission is implied by the set, otherwise `false`.

## Remarks

Handles logical operators: `"A&B"` requires all listed permissions, `"A|B"`
requires at least one. `&` binds tighter than `|`, so `"A&B|C"` is
`(A AND B) OR C`. An exact key match is checked first before parsing operators.

## Examples

```ts
Authorization.isPermissionInSet({ "A": true, "B": true }, "A&B"); // true
```

```ts
Authorization.isPermissionInSet({ "A": true }, "A|C"); // true
```

```ts
Authorization.isPermissionInSet({ "A": true }, "A&B"); // false
```
