[@serenity-is/corelib](../README.md) / IDoubleValue

# Abstract Class: IDoubleValue

Defined in: [src/interfaces/idoublevalue.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idoublevalue.ts#L6)

Type token for editors that expose a numeric (double) value.

## Constructors

### Constructor

> **new IDoubleValue**(): `IDoubleValue`

#### Returns

`IDoubleValue`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/idoublevalue.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idoublevalue.ts#L7)

## Methods

### get\_value()

> **get\_value**(): `any`

Defined in: [src/interfaces/idoublevalue.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idoublevalue.ts#L12)

Gets the current numeric value.

#### Returns

`any`

Current value (number or null/undefined).

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/interfaces/idoublevalue.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/idoublevalue.ts#L14)

Sets the numeric value.

#### Parameters

##### value

`any`

New value to assign.

#### Returns

`void`
