[@serenity-is/domwise](../README.md) / inSVGNamespace

# Function: inSVGNamespace()

> **inSVGNamespace**(`fn`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [src/in-namespace-uri.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/in-namespace-uri.ts#L63)

Executes a children factory within the SVG namespace (`http://www.w3.org/2000/svg`).
Sugar over [inNamespaceURI](inNamespaceURI.md) with [SVGNamespace](../variables/SVGNamespace.md).

## Parameters

### fn

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Factory that returns children to create as SVG elements.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children produced by the factory.
