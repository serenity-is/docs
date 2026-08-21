[@serenity-is/corelib](../README.md) / ISetEditValue

# Abstract Class: ISetEditValue

Defined in: [src/interfaces/iseteditvalue.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/iseteditvalue.ts#L6)

Type token for editors that can be populated from a source object.

## Constructors

### Constructor

> **new ISetEditValue**(): `ISetEditValue`

#### Returns

`ISetEditValue`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/iseteditvalue.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/iseteditvalue.ts#L7)

## Methods

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/interfaces/iseteditvalue.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/iseteditvalue.ts#L16)

Populates the editor from a source object.

#### Parameters

##### source

`any`

Object containing property values.

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

Property metadata for the field.

#### Returns

`void`
