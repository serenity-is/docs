[@serenity-is/corelib](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [../domwise/dist/index.d.ts:2313](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2313)

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

Defined in: [../domwise/dist/index.d.ts:2318](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2318)

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

Defined in: [../domwise/dist/index.d.ts:2325](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2325)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [../domwise/dist/index.d.ts:2331](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2331)

Optional display name used in devtools / error messages.

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [../domwise/dist/index.d.ts:2327](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2327)

Props passed to the instance, including optional `children`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2323](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2323)

Renders the component.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The rendered `JSXElement` or `null`.
