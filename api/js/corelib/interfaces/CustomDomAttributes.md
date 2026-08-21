[@serenity-is/corelib](../README.md) / CustomDomAttributes

# Interface: CustomDomAttributes\<T\>

Defined in: [../domwise/dist/index.d.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L146)

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

Defined in: [../domwise/dist/index.d.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L148)

Child nodes / JSX children for the element.

***

### dangerouslySetInnerHTML?

> `optional` **dangerouslySetInnerHTML**: `object`

Defined in: [../domwise/dist/index.d.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L150)

Raw HTML to assign via `innerHTML`. Use with caution — content is not escaped.

#### \_\_html

> **\_\_html**: `string`

***

### on?

> `optional` **on**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L156)

Compatibility event map for `on*` handlers (jsx-dom / React style).

***

### onCapture?

> `optional` **onCapture**: `Record`\<`string`, `Function`\>

Defined in: [../domwise/dist/index.d.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L158)

Compatibility event map for capture-phase handlers.

***

### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L154)

Ref object or callback that receives the created DOM node.
