[serenity-is/corelib](../README.md) / insert

# Function: insert()

> **insert**(`obj`, `index`, `item`): `void`

Defined in: [src/compat/arrays-compat.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L122)

Inserts an item to the array at specified index. Prefer Array.splice unless
you need to support IE.

## Parameters

### obj

`any`

Array or array like object to insert to.

### index

`number`

Index to insert at.

### item

`any`

Item to insert.

## Returns

`void`

## Throws

Error if object does not support insert.

## Example

```ts
insert([1, 2, 3], 1, 4); // [1, 4, 2, 3]
insert({ insert: (index, item) => { this.splice(index, 0, item); } }
```
