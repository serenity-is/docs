[@serenity-is/corelib](../README.md) / single

# ~~Function: single()~~

> **single**\<`TItem`\>(`array`, `predicate`): `TItem`

Defined in: [src/compat/arrays-compat.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L179)

Returns the single element satisfying the predicate (LINQ `Single` semantics).

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to search.

### predicate

(`x`) => `boolean`

Function invoked per element; exactly one element must return `true`.

## Returns

`TItem`

The sole matching element.

## Throws

If no element matches (`"single:No element satisfies the condition."`) or more than one matches (`"single:sequence contains more than one element."`).

## Deprecated

Retained as a `Q.single` compat shim; prefer explicit `filter` + length check for clarity.

## Example

```ts
single([1, 2, 3], x => x == 2); // 2
```
