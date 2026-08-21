[@serenity-is/corelib](../README.md) / isArray

# ~~Variable: isArray()~~

> `const` **isArray**: (`arg`) => `arg is any[]` = `Array.isArray`

Defined in: [src/compat/arrays-compat.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L167)

Tests whether a value is an array.

## Parameters

### arg

`any`

## Returns

`arg is any[]`

## Remarks

Thin re-export of `Array.isArray` for legacy `Q.isArray` call sites.

## Deprecated

Use `Array.isArray` directly.

## Example

```ts
isArray([1, 2, 3]); // true
isArray({}); // false
```
