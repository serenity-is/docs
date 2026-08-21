[@serenity-is/domwise](../README.md) / CustomDomAttributes

# Interface: CustomDomAttributes\<T\>

Defined in: [types/custom-attributes.d.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L10)

Custom DOM attributes supported by DomWise on all elements.
Includes `children`, `ref`, `dangerouslySetInnerHTML`, and jsx-dom/react-compatible
`on` / `onCapture` event maps.

## Extended by

- [`ElementAttributes`](ElementAttributes.md)

## Type Parameters

### T

`T`

The type of the DOM element.

## Properties

### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Defined in: [types/custom-attributes.d.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L12)

Child nodes / JSX children for the element.

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [types/custom-attributes.d.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L14)

Raw HTML to assign via `innerHTML`. Use with caution — content is not escaped.

#### \_\_html

> **\_\_html**: `string`

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [types/custom-attributes.d.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L19)

Compatibility event map for `on*` handlers (jsx-dom / React style).

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [types/custom-attributes.d.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L21)

Compatibility event map for capture-phase handlers.

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [types/custom-attributes.d.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/custom-attributes.d.ts#L16)

Ref object or callback that receives the created DOM node.
