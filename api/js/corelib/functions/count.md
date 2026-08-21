[@serenity-is/corelib](../README.md) / count

# ~~Function: count()~~

> **count**\<`TItem`\>(`array`, `predicate`): `number`

Defined in: [src/compat/arrays-compat.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L23)

Counts elements that satisfy the predicate.

## Type Parameters

### TItem

`TItem`

## Parameters

### array

`TItem`[]

Array to count over.

### predicate

(`x`) => `boolean`

Function invoked per element; return `true` to count the element.

## Returns

`number`

Number of matching elements.

## Deprecated

Prefer `array.filter(predicate).length` or a manual loop. Retained as a `Q.count` compat shim.

## Example

```ts
count([1, 2, 3], x => x % 2 === 1); // 2
```
