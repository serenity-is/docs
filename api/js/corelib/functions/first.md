[@serenity-is/corelib](../README.md) / first

# ~~Function: first()~~

> **first**\<`TItem`\>(`array`, `predicate`): `TItem`

Defined in: [src/compat/arrays-compat.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L42)

Returns the first element that satisfies the predicate (LINQ `First` semantics).

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

The first matching element.

## Throws

If no element satisfies the predicate (`"first:No element satisfies the condition."`).

## Deprecated

Prefer `array.find(predicate)` with explicit not-found handling. Retained as a `Q.first` compat shim.

## Example

```ts
first([1, 2, 3], x => x > 1); // 2
```
