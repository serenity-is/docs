[@serenity-is/corelib](../README.md) / IBooleanValue

# Abstract Class: IBooleanValue

Defined in: [src/interfaces/ibooleanvalue.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ibooleanvalue.ts#L7)

Type token for widgets/editors that expose a boolean value.
Implement [IBooleanValue.get\_value](#get_value) / [IBooleanValue.set\_value](#set_value) and register with the interface type system.

## Constructors

### Constructor

> **new IBooleanValue**(): `IBooleanValue`

#### Returns

`IBooleanValue`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/ibooleanvalue.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ibooleanvalue.ts#L8)

## Methods

### get\_value()

> **get\_value**(): `boolean`

Defined in: [src/interfaces/ibooleanvalue.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ibooleanvalue.ts#L13)

Gets the current boolean value.

#### Returns

`boolean`

Current value.

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/interfaces/ibooleanvalue.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ibooleanvalue.ts#L15)

Sets the boolean value.

#### Parameters

##### value

`boolean`

New value to assign.

#### Returns

`void`
