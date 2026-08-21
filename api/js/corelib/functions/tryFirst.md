[@serenity-is/corelib](../README.md) / tryFirst

# ~~Function: tryFirst()~~

> **tryFirst**\<`TItem`\>(`array`, `predicate`): `TItem`

Defined in: [src/compat/arrays-compat.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L238)

Returns the first element satisfying the predicate, or `undefined` if none matches (LINQ `FirstOrDefault`).

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to search.

### predicate

(`x`) => `boolean`

Function invoked per element; return `true` for the desired element.

## Returns

`TItem`

The first matching element, or `undefined` when no match is found.

## Deprecated

Prefer `Array.prototype.find` — `array.find(predicate)`. Retained as a `Q.tryFirst` compat shim.

## Example

```ts
tryFirst([1, 2, 3], x => x == 2); // 2
tryFirst([1, 2, 3], x => x == 4); // undefined
```
