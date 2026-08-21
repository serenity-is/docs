[@serenity-is/corelib](../README.md) / JSXElement

# Type Alias: JSXElement

> **JSXElement** = `HTMLElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"svg"`\] *extends* `false` ? `never` : `SVGElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"mathml"`\] *extends* `false` ? `never` : `MathMLElement`

Defined in: [../domwise/dist/index.d.ts:2261](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2261)

The DOM node type returned by JSX expressions.

Union of `HTMLElement` plus `SVGElement`/`MathMLElement` when those
namespaces are enabled in [JSX.ConfigureElement](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md). Technically this
could also include `DocumentFragment`, but many DOM APIs expect `Element`,
so fragments are typed separately where needed.
