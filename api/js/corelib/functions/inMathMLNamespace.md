[@serenity-is/corelib](../README.md) / inMathMLNamespace

# Function: inMathMLNamespace()

> **inMathMLNamespace**(`fn`): [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [../domwise/dist/index.d.ts:2711](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2711)

Executes a children factory within the MathML namespace (`http://www.w3.org/1998/Math/MathML`).
Sugar over [inNamespaceURI](inNamespaceURI.md) with [MathMLNamespace](../variables/MathMLNamespace.md).

## Parameters

### fn

() => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Factory that returns children to create as MathML elements.

## Returns

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

The children produced by the factory.
