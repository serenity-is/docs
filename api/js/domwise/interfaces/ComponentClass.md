[@serenity-is/domwise](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [types/components.d.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L4)

## Type Parameters

### P

`P` = \{ \}

### T

`T` *extends* `Node` = [`JSXElement`](../type-aliases/JSXElement.md)

## Constructors

### Constructor

> **new ComponentClass**(`props`): `ComponentClass`\<`P`, `T`\>

Defined in: [types/components.d.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L5)

#### Parameters

##### props

`P`

#### Returns

`ComponentClass`\<`P`, `T`\>

## Properties

### defaultProps?

> `optional` **defaultProps**: `Partial`\<`P`\>

Defined in: [types/components.d.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L7)

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [types/components.d.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L9)

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [types/components.d.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L8)

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md) \| `null`

Defined in: [types/components.d.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L6)

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md) \| `null`
