[@serenity-is/corelib](../README.md) / IQuickFiltering

# Abstract Class: IQuickFiltering

Defined in: [src/ui/filtering/iquickfiltering.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/iquickfiltering.ts#L8)

Interface for filtering handlers that can initialize a quick filter.

## Constructors

### Constructor

> **new IQuickFiltering**(): `IQuickFiltering`

#### Returns

`IQuickFiltering`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/iquickfiltering.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/iquickfiltering.ts#L9)

## Methods

### initQuickFilter()

> **initQuickFilter**(`filter`): `void`

Defined in: [src/ui/filtering/iquickfiltering.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/iquickfiltering.ts#L17)

Initializes a quick filter for this field.

#### Parameters

##### filter

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`Widget`](Widget.md)\<`any`\>, `any`\>

#### Returns

`void`
