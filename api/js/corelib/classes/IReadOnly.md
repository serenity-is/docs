[@serenity-is/corelib](../README.md) / IReadOnly

# Abstract Class: IReadOnly

Defined in: [src/interfaces/ireadonly.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ireadonly.ts#L6)

Type token for widgets that support read-only mode.

## Constructors

### Constructor

> **new IReadOnly**(): `IReadOnly`

#### Returns

`IReadOnly`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/interfaces/ireadonly.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ireadonly.ts#L7)

## Methods

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/interfaces/ireadonly.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ireadonly.ts#L12)

Gets whether the widget is read-only.

#### Returns

`boolean`

True if read-only.

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/interfaces/ireadonly.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/interfaces/ireadonly.ts#L14)

Sets read-only state.

#### Parameters

##### value

`boolean`

True to make read-only, false to make editable.

#### Returns

`void`
