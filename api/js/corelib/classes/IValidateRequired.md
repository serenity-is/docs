[@serenity-is/corelib](../README.md) / IValidateRequired

# Abstract Class: IValidateRequired

Defined in: [src/interfaces/ivalidaterequired.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ivalidaterequired.ts#L6)

Type token for editors that support a required-field flag.

## Constructors

### Constructor

> **new IValidateRequired**(): `IValidateRequired`

#### Returns

`IValidateRequired`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/ivalidaterequired.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ivalidaterequired.ts#L7)

## Methods

### get\_required()

> **get\_required**(): `boolean`

Defined in: [src/interfaces/ivalidaterequired.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ivalidaterequired.ts#L12)

Gets whether a value is required.

#### Returns

`boolean`

True if required.

***

### set\_required()

> **set\_required**(`value`): `void`

Defined in: [src/interfaces/ivalidaterequired.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ivalidaterequired.ts#L14)

Sets whether a value is required.

#### Parameters

##### value

`boolean`

True to require a value.

#### Returns

`void`
