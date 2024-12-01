[@serenity-is/corelib](../README.md) / FilterStore

# Class: FilterStore

## Constructors

### new FilterStore()

> **new FilterStore**(`fields`): [`FilterStore`](FilterStore.md)

#### Parameters

##### fields

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`FilterStore`](FilterStore.md)

#### Defined in

[src/ui/filtering/filterstore.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L9)

## Methods

### add\_changed()

> **add\_changed**(`value`): `void`

#### Parameters

##### value

(`e`, `a`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L155)

***

### get\_activeCriteria()

> **get\_activeCriteria**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L163)

***

### get\_displayText()

> **get\_displayText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L167)

***

### get\_fieldByName()

> **get\_fieldByName**(): `object`

#### Returns

`object`

#### Defined in

[src/ui/filtering/filterstore.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L142)

***

### get\_fields()

> **get\_fields**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L138)

***

### get\_items()

> **get\_items**(): [`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L146)

***

### raiseChanged()

> **raiseChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L150)

***

### remove\_changed()

> **remove\_changed**(`value`): `void`

#### Parameters

##### value

(`e`, `a`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L159)

***

### getCriteriaFor()

> `static` **getCriteriaFor**(`items`): `any`[]

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L44)

***

### getDisplayTextFor()

> `static` **getDisplayTextFor**(`items`): `string`

#### Parameters

##### items

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L96)
