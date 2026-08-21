[@serenity-is/domwise](../README.md) / inHTMLNamespace

# Function: inHTMLNamespace()

> **inHTMLNamespace**(`fn`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [src/in-namespace-uri.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L83)

Executes a children factory within the HTML namespace (clears any active SVG/MathML override).
Sugar over [inNamespaceURI](inNamespaceURI.md) with `null`.

## Parameters

### fn

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Factory that returns children to create as HTML elements.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children produced by the factory.
