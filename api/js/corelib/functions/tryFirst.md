[@serenity-is/corelib](../README.md) / tryFirst

# Function: tryFirst()

> **tryFirst**\<`TItem`\>(`array`, `predicate`): `TItem`

Gets first element in an array that matches given predicate (similar to LINQ's FirstOrDefault).
Returns null if no match is found.

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
tryFirst([1, 2, 3], x => x == 2); // 2
tryFirst([1, 2, 3], x => x == 4); // null
```

## Defined in

[src/q/arrays-compat.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L204)
