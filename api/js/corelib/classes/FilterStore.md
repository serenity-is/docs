[corelib](../README.md) / FilterStore

# Class: FilterStore

Defined in: [src/ui/filtering/filterstore.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L4)

## Constructors

### Constructor

> **new FilterStore**(`fields`): `FilterStore`

Defined in: [src/ui/filtering/filterstore.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L7)

#### Parameters

##### fields

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

`FilterStore`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/filterstore.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L5)

## Methods

### add\_changed()

> **add\_changed**(`value`): `void`

Defined in: [src/ui/filtering/filterstore.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L151)

#### Parameters

##### value

(`e`, `a`) => `void`

#### Returns

`void`

***

### get\_activeCriteria()

> **get\_activeCriteria**(): `any`[]

Defined in: [src/ui/filtering/filterstore.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L159)

#### Returns

`any`[]

***

### get\_displayText()

> **get\_displayText**(): `string`

Defined in: [src/ui/filtering/filterstore.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L163)

#### Returns

`string`

***

### get\_fieldByName()

> **get\_fieldByName**(): `object`

Defined in: [src/ui/filtering/filterstore.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L138)

#### Returns

`object`

***

### get\_fields()

> **get\_fields**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/filtering/filterstore.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L134)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

***

### get\_items()

> **get\_items**(): [`FilterLine`](../interfaces/FilterLine.md)[]

Defined in: [src/ui/filtering/filterstore.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L142)

#### Returns

[`FilterLine`](../interfaces/FilterLine.md)[]

***

### raiseChanged()

> **raiseChanged**(): `void`

Defined in: [src/ui/filtering/filterstore.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L146)

#### Returns

`void`

***

### remove\_changed()

> **remove\_changed**(`value`): `void`

Defined in: [src/ui/filtering/filterstore.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L155)

#### Parameters

##### value

(`e`, `a`) => `void`

#### Returns

`void`

***

### getCriteriaFor()

> `static` **getCriteriaFor**(`items`): `any`[]

Defined in: [src/ui/filtering/filterstore.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L41)

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

`any`[]

***

### getDisplayTextFor()

> `static` **getDisplayTextFor**(`items`): `string`

Defined in: [src/ui/filtering/filterstore.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L93)

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

`string`
