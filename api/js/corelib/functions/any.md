[@serenity-is/corelib](../README.md) / any

# Function: any()

> **any**\<`TItem`\>(`array`, `predicate`): `boolean`

Tests if any of array elements matches given predicate. Prefer Array.some() over this function (e.g. `[1, 2, 3].some(predicate)`).

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

`boolean`

True if any element matches.

## Defined in

[src/q/arrays-compat.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L7)
