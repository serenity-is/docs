[@serenity-is/corelib](../README.md) / any

# ~~Function: any()~~

> **any**\<`TItem`\>(`array`, `predicate`): `boolean`

Defined in: [src/compat/arrays-compat.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L10)

Tests whether any element in the array satisfies the predicate.

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to test.

### predicate

(`x`) => `boolean`

Function invoked per element; should return `true` for a match.

## Returns

`boolean`

`true` if at least one element matches, otherwise `false`.

## Deprecated

Prefer native `Array.prototype.some` — e.g. `array.some(predicate)`. Retained as a `Q.any` compat shim.

## Example

```ts
any([1, 2, 3], x => x > 2); // true
```
