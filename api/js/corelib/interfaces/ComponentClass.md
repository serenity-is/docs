[@serenity-is/corelib](../README.md) / ComponentClass

# Interface: ComponentClass\<P, T\>

Defined in: [../domwise/dist/index.d.ts:2167](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2167)

## Type Parameters

### P

`P` = \{ \}

### T

`T` *extends* `Node` = [`JSXElement`](../type-aliases/JSXElement.md)

## Constructors

### Constructor

> **new ComponentClass**(`props`): `ComponentClass`\<`P`, `T`\>

Defined in: [../domwise/dist/index.d.ts:2168](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2168)

#### Parameters

##### props

`P`

#### Returns

`ComponentClass`\<`P`, `T`\>

## Properties

### defaultProps?

> `optional` **defaultProps**: `Partial`\<`P`\>

Defined in: [../domwise/dist/index.d.ts:2170](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2170)

***

### displayName?

> `optional` **displayName**: `string`

Defined in: [../domwise/dist/index.d.ts:2174](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2174)

***

### props?

> `readonly` `optional` **props**: `P` & `object`

Defined in: [../domwise/dist/index.d.ts:2171](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2171)

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2169](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2169)

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)
