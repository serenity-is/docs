[@serenity-is/domwise](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [types/components.d.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L10)

A class-based JSX component. Extend `Component` or implement this interface
and override `render` to return a `JSXElement`.

## Type Parameters

### P

`P` = \{ \}

The type of the component's props.

### T

`T` *extends* `Node` = [`JSXElement`](../type-aliases/JSXElement.md)

The type of the DOM node the component renders.

## Constructors

### Constructor

> **new ComponentClass**(`props`): `ComponentClass`\<`P`, `T`\>

Defined in: [types/components.d.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L15)

Constructs the component with the given props.

#### Parameters

##### props

`P`

Props including optional `children`.

#### Returns

`ComponentClass`\<`P`, `T`\>

## Properties

### defaultProps?

> `optional` **defaultProps**: `Partial`\<`P`\>

Defined in: [types/components.d.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L22)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [types/components.d.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L26)

Optional display name used in devtools / error messages.

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [types/components.d.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L24)

Props passed to the instance, including optional `children`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md) \| `null`

Defined in: [types/components.d.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L20)

Renders the component.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md) \| `null`

The rendered `JSXElement` or `null`.
