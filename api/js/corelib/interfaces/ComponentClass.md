[@serenity-is/corelib](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [../domwise/dist/index.d.ts:2652](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2652)

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

> **new ComponentClass**(`props`): [`ComponentInstance`](ComponentInstance.md)\<`P`, `T`\>

Defined in: [../domwise/dist/index.d.ts:2657](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2657)

Constructs the component with the given props.

#### Parameters

##### props

`P`

Props including optional `children`.

#### Returns

[`ComponentInstance`](ComponentInstance.md)\<`P`, `T`\>

## Properties

### defaultProps?

> `optional` **defaultProps**: `Partial`\<`P`\>

Defined in: [../domwise/dist/index.d.ts:2659](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2659)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [../domwise/dist/index.d.ts:2661](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2661)

Optional display name used in devtools / error messages.
