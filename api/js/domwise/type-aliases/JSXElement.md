[@serenity-is/domwise](../README.md) / JSXElement

# Type Alias: JSXElement

> **JSXElement** = `HTMLElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"svg"`\] *extends* `false` ? `never` : `SVGElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"mathml"`\] *extends* `false` ? `never` : `MathMLElement`

Defined in: [types/jsx-namespace.d.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-namespace.d.ts#L13)

The DOM node type returned by JSX expressions.

Union of `HTMLElement` plus `SVGElement`/`MathMLElement` when those
namespaces are enabled in [JSX.ConfigureElement](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md). Technically this
could also include `DocumentFragment`, but many DOM APIs expect `Element`,
so fragments are typed separately where needed.
