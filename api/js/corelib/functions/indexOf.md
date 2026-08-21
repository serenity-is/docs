[@serenity-is/corelib](../README.md) / indexOf

# ~~Function: indexOf()~~

> **indexOf**\<`TItem`\>(`array`, `predicate`): `number`

Defined in: [src/compat/arrays-compat.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L131)

Returns the index of the first element satisfying the predicate.

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to search.

### predicate

(`x`) => `boolean`

Function invoked per element; return `true` for the target element.

## Returns

`number`

Zero-based index of the first match, or `-1` if none matches.

## Deprecated

Prefer `Array.prototype.findIndex` — `array.findIndex(predicate)`. Retained as a `Q.indexOf` compat shim (note the predicate overload differs from `Array.indexOf`).

## Example

```ts
indexOf([1, 2, 3], x => x === 2); // 1
```
