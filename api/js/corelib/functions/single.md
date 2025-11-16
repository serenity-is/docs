[corelib](../README.md) / single

# Function: single()

> **single**\<`TItem`\>(`array`, `predicate`): `TItem`

Defined in: [src/compat/arrays-compat.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L150)

Gets first element in an array that matches given predicate.
Throws an error if no matches is found, or there are multiple matches.

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to test.

### predicate

(`x`) => `boolean`

Predicate to test elements.

## Returns

`TItem`

First element that matches.

## Example

```ts
first([1, 2, 3], x => x == 2); // 2
first([1, 2, 3], x => x == 4); // throws error.
```
