[@serenity-is/corelib](../README.md) / IStringValue

# Abstract Class: IStringValue

Defined in: [src/interfaces/istringvalue.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/istringvalue.ts#L6)

Type token for editors that expose a string value.

## Constructors

### Constructor

> **new IStringValue**(): `IStringValue`

#### Returns

`IStringValue`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/istringvalue.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/istringvalue.ts#L7)

## Methods

### get\_value()

> **get\_value**(): `string`

Defined in: [src/interfaces/istringvalue.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/istringvalue.ts#L12)

Gets the current string value.

#### Returns

`string`

Current value.

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/interfaces/istringvalue.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/istringvalue.ts#L14)

Sets the string value.

#### Parameters

##### value

`string`

New value to assign.

#### Returns

`void`
