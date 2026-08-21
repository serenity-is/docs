[@serenity-is/corelib](../README.md) / ComponentChild

# Type Alias: ComponentChild

> **ComponentChild** = `string` \| `number` \| `Iterable`\<`ComponentChild`\> \| `ComponentChild`[] \| \{ `peek`: () => `ComponentChild`; `subscribe`: (`cb`) => `void`; `value`: `ComponentChild`; \} \| [`JSXElement`](JSXElement.md) \| `NodeList` \| `ChildNode` \| `HTMLCollection` \| [`ShadowRootContainer`](ShadowRootContainer.md) \| `DocumentFragment` \| `Text` \| `Comment` \| `boolean` \| `null` \| `undefined`

Defined in: [../domwise/dist/index.d.ts:2269](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2269)

A single child that can be rendered inside a JSX element.

Includes primitives (`string`/`number`), DOM nodes, iterables/arrays of
children, signal-like wrappers, shadow root containers, and the ignorable
`boolean`/`null`/`undefined` values (filtered similarly to React).
