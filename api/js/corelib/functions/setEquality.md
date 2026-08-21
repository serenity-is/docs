[@serenity-is/corelib](../README.md) / setEquality

# ~~Function: setEquality()~~

> **setEquality**(`request`, `field`, `value`): `void`

Defined in: [src/compat/services-compat.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/services-compat.tsx#L11)

Sets an equality filter value on a list request.
Compat shim for the legacy `Q.setEquality` helper. Lazily initializes `request.EqualityFilter` if needed.

## Parameters

### request

[`ListRequest`](../interfaces/ListRequest.md)

The [ListRequest](../interfaces/ListRequest.md) whose `EqualityFilter` map will be mutated.

### field

`string`

Field name to set in the equality filter.

### value

`any`

Value to assign for the field (any JSON-serializable value, or `null` to clear).

## Returns

`void`

## Deprecated

Prefer setting `request.equalityFilter` / `EqualityFilter` directly or using modern list request builders. Kept for legacy compatibility.
