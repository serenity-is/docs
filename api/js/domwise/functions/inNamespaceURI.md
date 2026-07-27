[@serenity-is/domwise](../README.md) / inNamespaceURI

# Function: inNamespaceURI()

> **inNamespaceURI**(`namespaceURI`, `children`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [src/in-namespace-uri.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L30)

Executes a children factory within a specific namespace URI context.
The namespace is temporarily set for the duration of the call and restored afterwards.

## Parameters

### namespaceURI

The namespace URI to use, or `null` for HTML namespace.

`string` | `null`

### children

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

A factory function that returns children to be created in the given namespace.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children produced by the factory.
