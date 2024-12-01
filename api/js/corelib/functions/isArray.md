[@serenity-is/corelib](../README.md) / isArray

# Function: isArray()

> **isArray**(`arg`): `arg is any[]`

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

## Defined in

[src/q/arrays-compat.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/arrays-compat.ts#L139)
