[@serenity-is/corelib](../README.md) / IGetEditValue

# Abstract Class: IGetEditValue

Defined in: [src/interfaces/igeteditvalue.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/igeteditvalue.ts#L6)

Type token for editors that can write their value into a target object.

## Constructors

### Constructor

> **new IGetEditValue**(): `IGetEditValue`

#### Returns

`IGetEditValue`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/igeteditvalue.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/igeteditvalue.ts#L7)

## Methods

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/interfaces/igeteditvalue.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/igeteditvalue.ts#L16)

Writes the editor value into the target object.

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

Property metadata for the field.

##### target

`any`

Object to populate.

#### Returns

`void`
