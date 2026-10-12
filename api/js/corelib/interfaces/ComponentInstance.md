[@serenity-is/corelib](../README.md) / ComponentInstance

# Interface: ComponentInstance\<P, T\>

Defined in: [../domwise/dist/index.d.ts:2324](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2324)

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

Defined in: [../domwise/dist/index.d.ts:2331](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2331)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [../domwise/dist/index.d.ts:2337](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2337)

Optional display name used in devtools / error messages.

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [../domwise/dist/index.d.ts:2333](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2333)

Props passed to the instance, including optional `children`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2329](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2329)

Renders the component.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The rendered `JSXElement` or `null`.
