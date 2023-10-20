[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FilterStore

# Class: FilterStore

[corelib](../modules/corelib.md).FilterStore

## Table of contents

### Constructors

- [constructor](corelib.FilterStore.md#constructor)

### Properties

- [changed](corelib.FilterStore.md#changed)
- [displayText](corelib.FilterStore.md#displaytext)
- [fieldByName](corelib.FilterStore.md#fieldbyname)
- [fields](corelib.FilterStore.md#fields)
- [items](corelib.FilterStore.md#items)

### Methods

- [add\_changed](corelib.FilterStore.md#add_changed)
- [get\_activeCriteria](corelib.FilterStore.md#get_activecriteria)
- [get\_displayText](corelib.FilterStore.md#get_displaytext)
- [get\_fieldByName](corelib.FilterStore.md#get_fieldbyname)
- [get\_fields](corelib.FilterStore.md#get_fields)
- [get\_items](corelib.FilterStore.md#get_items)
- [raiseChanged](corelib.FilterStore.md#raisechanged)
- [remove\_changed](corelib.FilterStore.md#remove_changed)
- [getCriteriaFor](corelib.FilterStore.md#getcriteriafor)
- [getDisplayTextFor](corelib.FilterStore.md#getdisplaytextfor)

## Constructors

### constructor

• **new FilterStore**(`fields`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `fields` | [`PropertyItem`](../interfaces/q.PropertyItem.md)[] |

#### Defined in

[src/ui/filtering/filterstore.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L8)

## Properties

### changed

• `Private` **changed**: `any`

#### Defined in

[src/ui/filtering/filterstore.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L131)

___

### displayText

• `Private` **displayText**: `string`

#### Defined in

[src/ui/filtering/filterstore.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L132)

___

### fieldByName

• `Private` **fieldByName**: `Object`

#### Index signature

▪ [key: `string`]: [`PropertyItem`](../interfaces/q.PropertyItem.md)

#### Defined in

[src/ui/filtering/filterstore.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L134)

___

### fields

• `Private` **fields**: [`PropertyItem`](../interfaces/q.PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L133)

___

### items

• `Private` **items**: [`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L135)

## Methods

### add\_changed

▸ **add_changed**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | (`e`: `JQueryEventObject`, `a`: `any`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L154)

___

### get\_activeCriteria

▸ **get_activeCriteria**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L162)

___

### get\_displayText

▸ **get_displayText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L166)

___

### get\_fieldByName

▸ **get_fieldByName**(): `Object`

#### Returns

`Object`

#### Defined in

[src/ui/filtering/filterstore.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L141)

___

### get\_fields

▸ **get_fields**(): [`PropertyItem`](../interfaces/q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/q.PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L137)

___

### get\_items

▸ **get_items**(): [`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Returns

[`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L145)

___

### raiseChanged

▸ **raiseChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L149)

___

### remove\_changed

▸ **remove_changed**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | (`e`: `JQueryEventObject`, `a`: `any`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L158)

___

### getCriteriaFor

▸ `Static` **getCriteriaFor**(`items`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`FilterLine`](../interfaces/corelib.FilterLine.md)[] |

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L43)

___

### getDisplayTextFor

▸ `Static` **getDisplayTextFor**(`items`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | [`FilterLine`](../interfaces/corelib.FilterLine.md)[] |

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#L95)
