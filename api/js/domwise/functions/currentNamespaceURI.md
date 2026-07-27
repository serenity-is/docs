[@serenity-is/domwise](../README.md) / currentNamespaceURI

# Function: currentNamespaceURI()

> **currentNamespaceURI**(`value?`): `string` \| `null` \| `undefined`

Defined in: [src/in-namespace-uri.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L14)

Gets or sets the current JSX namespace URI.
When called without arguments, returns the current namespace URI.
When called with a value, sets the namespace and returns the previous value.

## Parameters

### value?

If provided, sets the namespace URI to this value.

`string` | `null`

## Returns

`string` \| `null` \| `undefined`

The current (or previous) namespace URI, or `null` / `undefined`.
