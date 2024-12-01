[@serenity-is/corelib](../README.md) / single

# Function: single()

> **single**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate.
Throws an error if no matches is found, or there are multiple matches.

## Type Parameters

• **TItem**

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

## Defined in

[src/q/arrays-compat.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L151)
