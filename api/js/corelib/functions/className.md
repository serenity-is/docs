[@serenity-is/corelib](../README.md) / className

# Function: className()

> **className**(`value`): `string`

Defined in: [../domwise/dist/index.d.ts:2417](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2417)

Converts a heterogeneous class value to a normalized space-separated class string.

Handles strings, nested arrays (recursively flattened), any iterable (e.g. `Set`),
and dictionary objects where only keys with truthy values are included.
Falsy primitives, `true`/`false`, `null` and `undefined` produce an empty string.

## Parameters

### value

`any`

The class value to normalize. May be a string, array, iterable,
dictionary (`Record<string, boolean>`), primitive, or nested combination thereof.

## Returns

`string`

A space-separated class name string, or `""` when the input yields no classes.

## Example

```ts
className("foo bar") // => "foo bar"
className(["foo", ["bar", { baz: true, qux: false }]]) // => "foo bar baz"
className(new Set(["a", "b"])) // => "a b"
```
