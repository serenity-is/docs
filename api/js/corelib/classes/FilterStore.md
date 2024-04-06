[@serenity-is/corelib](../README.md) / FilterStore

# Class: FilterStore

## Table of contents

### Constructors

- [constructor](FilterStore.md#constructor)

### Properties

- [changed](FilterStore.md#changed)
- [displayText](FilterStore.md#displaytext)
- [fieldByName](FilterStore.md#fieldbyname)
- [fields](FilterStore.md#fields)
- [items](FilterStore.md#items)

### Methods

- [add\_changed](FilterStore.md#add_changed)
- [get\_activeCriteria](FilterStore.md#get_activecriteria)
- [get\_displayText](FilterStore.md#get_displaytext)
- [get\_fieldByName](FilterStore.md#get_fieldbyname)
- [get\_fields](FilterStore.md#get_fields)
- [get\_items](FilterStore.md#get_items)
- [raiseChanged](FilterStore.md#raisechanged)
- [remove\_changed](FilterStore.md#remove_changed)
- [getCriteriaFor](FilterStore.md#getcriteriafor)
- [getDisplayTextFor](FilterStore.md#getdisplaytextfor)

## Constructors

### constructor

• **new FilterStore**(`fields`): [`FilterStore`](FilterStore.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `fields` | [`PropertyItem`](../interfaces/PropertyItem.md)[] |

#### Returns

[`FilterStore`](FilterStore.md)

#### Defined in

[src/ui/filtering/filterstore.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L9)

## Properties

### changed

• `Private` **changed**: `any`

#### Defined in

[src/ui/filtering/filterstore.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L132)

___

### displayText

• `Private` **displayText**: `string`

#### Defined in

[src/ui/filtering/filterstore.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L133)

___

### fieldByName

• `Private` **fieldByName**: `Object`

#### Index signature

▪ [key: `string`]: [`PropertyItem`](../interfaces/PropertyItem.md)

#### Defined in

[src/ui/filtering/filterstore.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L135)

___

### fields

• `Private` **fields**: [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L134)

___

### items

• `Private` **items**: [`FilterLine`](../interfaces/FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L136)

## Methods

### add\_changed

▸ **add_changed**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | (`e`: `Event`, `a`: `any`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L155)

___

### get\_activeCriteria

▸ **get_activeCriteria**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L163)

___

### get\_displayText

▸ **get_displayText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L167)

___

### get\_fieldByName

▸ **get_fieldByName**(): `Object`

#### Returns

`Object`

#### Defined in

[src/ui/filtering/filterstore.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L142)

___

### get\_fields

▸ **get_fields**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L138)

___

### get\_items

▸ **get_items**(): [`FilterLine`](../interfaces/FilterLine.md)[]

#### Returns

[`FilterLine`](../interfaces/FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L146)

___

### raiseChanged

▸ **raiseChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L150)

___

### remove\_changed

▸ **remove_changed**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | (`e`: `Event`, `a`: `any`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L159)

___

### getCriteriaFor

▸ **getCriteriaFor**(`items`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`FilterLine`](../interfaces/FilterLine.md)[] |

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L44)

___

### getDisplayTextFor

▸ **getDisplayTextFor**(`items`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`FilterLine`](../interfaces/FilterLine.md)[] |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L96)
