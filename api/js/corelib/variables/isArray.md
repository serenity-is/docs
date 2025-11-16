[corelib](../README.md) / isArray

# Variable: isArray()

> `const` **isArray**: (`arg`) => `arg is any[]` = `Array.isArray`

Defined in: [src/compat/arrays-compat.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/arrays-compat.ts#L138)

Determines if the object is an array. Prefer Array.isArray over this function (e.g. `Array.isArray(obj)`).

## Parameters

### arg

`any`

## Returns

`arg is any[]`

True if the object is an array.

## Example

```ts
isArray([1, 2, 3]); // true
isArray({}); // false
```
