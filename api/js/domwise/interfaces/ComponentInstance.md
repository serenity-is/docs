[@serenity-is/domwise](../README.md) / ComponentInstance

# Interface: ComponentInstance\<P, T\>

Defined in: [types/components.d.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L9)

An instance of a class-based JSX component created by the JSX factory.

## Type Parameters

### P

`P` = \{ \}

The type of the component's props.

### T

`T` *extends* `Node` = [`JSXElement`](../type-aliases/JSXElement.md)

The type of the DOM node the component renders.

## Properties

### defaultProps?

> `optional` **defaultProps**: `Partial`\<`P`\>

Defined in: [types/components.d.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L16)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [types/components.d.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L20)

Optional display name used in devtools / error messages.

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [types/components.d.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L18)

Props passed to the instance, including optional `children`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md) \| `null`

Defined in: [types/components.d.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L14)

Renders the component.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md) \| `null`

The rendered `JSXElement` or `null`.
