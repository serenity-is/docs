[@serenity-is/domwise](../README.md) / className

# Function: className()

> **className**(`value`): `string`

Defined in: [src/class-name.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/class-name.ts#L10)

Converts a value to a className string.
Supports strings, arrays (flattened), iterables, and `Dictionary<boolean>` objects
where truthy keys are included.

## Parameters

### value

`any`

The value to convert. Can be a string, array, iterable, or dictionary.

## Returns

`string`

A space-separated className string.
