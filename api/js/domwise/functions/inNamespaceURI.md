[@serenity-is/domwise](../README.md) / inNamespaceURI

# Function: inNamespaceURI()

> **inNamespaceURI**(`namespaceURI`, `children`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [src/in-namespace-uri.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L45)

Executes a children factory within a scoped namespace URI.

Temporarily sets [currentNamespaceURI](currentNamespaceURI.md) to `namespaceURI` for the
duration of `children()`, then restores the previous value (even if the
factory throws). This lets you create SVG/MathML subtrees imperatively
without setting `namespaceURI` on every element.

## Parameters

### namespaceURI

Namespace URI to activate, or `null` for the HTML namespace.

`string` | `null`

### children

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Factory that produces the children to render in the given namespace.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children returned by the factory.

## Example

```tsx
const icon = inNamespaceURI(SVGNamespace, () => <><circle r={10} /><path d="M0 0" /></>);
```
