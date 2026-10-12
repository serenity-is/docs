[@serenity-is/domwise](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [types/components.d.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L29)

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

Defined in: [types/components.d.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L34)

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

Defined in: [types/components.d.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L36)

Optional default prop values merged in by the JSX factory before construction.

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [types/components.d.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L38)

Optional display name used in devtools / error messages.
