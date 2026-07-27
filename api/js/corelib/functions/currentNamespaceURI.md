[@serenity-is/corelib](../README.md) / currentNamespaceURI

# Function: currentNamespaceURI()

> **currentNamespaceURI**(`value?`): `string`

Defined in: [../domwise/dist/index.d.ts:2373](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2373)

Gets or sets the current JSX namespace URI.
When called without arguments, returns the current namespace URI.
When called with a value, sets the namespace and returns the previous value.

## Parameters

### value?

`string`

If provided, sets the namespace URI to this value.

## Returns

`string`

The current (or previous) namespace URI, or `null` / `undefined`.
