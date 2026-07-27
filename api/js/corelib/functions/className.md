[@serenity-is/corelib](../README.md) / className

# Function: className()

> **className**(`value`): `string`

Defined in: [../domwise/dist/index.d.ts:2225](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2225)

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
