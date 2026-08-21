[@serenity-is/corelib](../README.md) / IInitializeColumn

# Abstract Class: IInitializeColumn

Defined in: [src/ui/formatters/iinitializecolumn.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/iinitializecolumn.ts#L8)

Type token for formatters/editors that need to modify their grid column at setup time
(e.g. to declare `referencedFields`).

## Constructors

### Constructor

> **new IInitializeColumn**(): `IInitializeColumn`

#### Returns

`IInitializeColumn`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/iinitializecolumn.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/iinitializecolumn.ts#L9)

## Methods

### initializeColumn()

> **initializeColumn**(`column`): `void`

Defined in: [src/ui/formatters/iinitializecolumn.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/iinitializecolumn.ts#L17)

Called during column construction to allow the formatter to adjust column metadata.

#### Parameters

##### column

`Column`

Mutable column definition to initialize.

#### Returns

`void`
