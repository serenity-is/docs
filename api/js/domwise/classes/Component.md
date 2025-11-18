[@serenity-is/domwise](../README.md) / Component

# Class: Component\<T\>

Defined in: [src/component.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L4)

## Type Parameters

### T

`T` = `any`

## Constructors

### Constructor

> **new Component**\<`T`\>(`props`): `Component`\<`T`\>

Defined in: [src/component.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L7)

#### Parameters

##### props

`T` & `object`

#### Returns

`Component`\<`T`\>

## Properties

### props

> `readonly` **props**: `T` & `object`

Defined in: [src/component.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L11)

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

##### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`any`\>

***

### isComponent

> `static` **isComponent**: `boolean` = `true`

Defined in: [src/component.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L5)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md) \| `null`

Defined in: [src/component.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L13)

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md) \| `null`
