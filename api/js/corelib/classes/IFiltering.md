[@serenity-is/corelib](../README.md) / IFiltering

# Abstract Class: IFiltering

Defined in: [src/ui/filtering/ifiltering.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L5)

## Constructors

### Constructor

> **new IFiltering**(): `IFiltering`

#### Returns

`IFiltering`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/ifiltering.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L6)

## Methods

### createEditor()

> **createEditor**(): `void`

Defined in: [src/ui/filtering/ifiltering.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L10)

#### Returns

`void`

***

### get\_container()

> **get\_container**(): `HTMLElement`

Defined in: [src/ui/filtering/ifiltering.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L17)

#### Returns

`HTMLElement`

***

### get\_field()

> **get\_field**(): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/ifiltering.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L15)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

***

### get\_operator()

> **get\_operator**(): [`FilterOperator`](../interfaces/FilterOperator.md)

Defined in: [src/ui/filtering/ifiltering.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L19)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)

***

### getCriteria()

> **getCriteria**(): `CriteriaWithText`

Defined in: [src/ui/filtering/ifiltering.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L11)

#### Returns

`CriteriaWithText`

***

### getOperators()

> **getOperators**(): [`FilterOperator`](../interfaces/FilterOperator.md)[]

Defined in: [src/ui/filtering/ifiltering.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L12)

#### Returns

[`FilterOperator`](../interfaces/FilterOperator.md)[]

***

### loadState()

> **loadState**(`state`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L13)

#### Parameters

##### state

`any`

#### Returns

`void`

***

### saveState()

> **saveState**(): `any`

Defined in: [src/ui/filtering/ifiltering.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L14)

#### Returns

`any`

***

### set\_container()

> **set\_container**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L18)

#### Parameters

##### value

`HTMLElement`

#### Returns

`void`

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L16)

#### Parameters

##### value

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

***

### set\_operator()

> **set\_operator**(`value`): `void`

Defined in: [src/ui/filtering/ifiltering.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/ifiltering.ts#L20)

#### Parameters

##### value

[`FilterOperator`](../interfaces/FilterOperator.md)

#### Returns

`void`
