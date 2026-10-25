[@serenity-is/corelib](../README.md) / ComponentInstance

# Interface: ComponentInstance\<P, T\>

Defined in: [../domwise/dist/index.d.ts:2633](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2633)

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

Defined in: [../domwise/dist/index.d.ts:2640](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2640)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [../domwise/dist/index.d.ts:2644](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2644)

Optional display name used in devtools / error messages.

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [../domwise/dist/index.d.ts:2642](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2642)

Props passed to the instance, including optional `children`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2638](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2638)

Renders the component.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The rendered `JSXElement` or `null`.
