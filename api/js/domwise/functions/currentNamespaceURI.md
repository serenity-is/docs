[@serenity-is/domwise](../README.md) / currentNamespaceURI

# Function: currentNamespaceURI()

> **currentNamespaceURI**(`value?`): `string` \| `null` \| `undefined`

Defined in: [src/in-namespace-uri.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L20)

Gets or sets the ambient JSX namespace URI used for `createElement`/`jsx`.

Stored on `globalThis` under `Serenity.jsxNamespaceURI`. When the active
namespace is `"http://www.w3.org/2000/svg"` (or MathML), elements created
without an explicit `namespaceURI` prop are created via `createElementNS`.

## Parameters

### value?

When arguments are supplied, the namespace is set to this
value (use `null` to reset to the HTML namespace). When called with no
arguments the current value is simply returned.

`string` | `null`

## Returns

`string` \| `null` \| `undefined`

The current namespace URI (no-arg call), or the previous value
(setter call). May be `null`/`undefined` when no override is active.
