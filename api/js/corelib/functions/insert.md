[@serenity-is/corelib](../README.md) / insert

# ~~Function: insert()~~

> **insert**(`obj`, `index`, `item`): `void`

Defined in: [src/compat/arrays-compat.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L150)

Inserts an item into an array at the given index.

## Parameters

### obj

`any`

Target array or array-like object with an `insert(index, item)` method.

### index

`number`

Zero-based index at which to insert.

### item

`any`

Item to insert.

## Returns

`void`

## Throws

If `obj` is neither an array nor exposes `insert`.

## Remarks

If `obj.insert` exists it is delegated to; otherwise `Array.prototype.splice` is used. No return value.

## Deprecated

Prefer `array.splice(index, 0, item)` directly. Retained as a `Q.insert` compat shim.

## Example

```ts
insert([1, 2, 3], 1, 4); // [1, 4, 2, 3]
```
