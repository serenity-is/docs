[@serenity-is/corelib](../README.md) / inNamespaceURI

# Function: inNamespaceURI()

> **inNamespaceURI**(`namespaceURI`, `children`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [../domwise/dist/index.d.ts:2381](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2381)

Executes a children factory within a specific namespace URI context.
The namespace is temporarily set for the duration of the call and restored afterwards.

## Parameters

### namespaceURI

`string`

The namespace URI to use, or `null` for HTML namespace.

### children

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

A factory function that returns children to be created in the given namespace.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children produced by the factory.
