[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / toClassName

# Function: toClassName()

> **toClassName**(`value`): `string`

Defined in: [src/base/fluent.ts:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L764)

Normalizes a class value (string, boolean flag, or nested array) to a space-separated class string.

## Parameters

### value

Value to normalize. Non-string primitives are stringified; booleans and `null` / `undefined` yield `""`; arrays are recursively flattened and falsy entries dropped.

`string` | `boolean` | (`string` \| `boolean`)[]

## Returns

`string`

The concatenated class string (may be empty).
