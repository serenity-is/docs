[@serenity-is/corelib](../README.md) / first

# Function: first()

> **first**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate similar to LINQ's First.
Throws an error if no match is found.

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

## Defined in

[src/q/arrays-compat.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L32)
