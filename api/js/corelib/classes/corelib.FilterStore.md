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
| `fields` | [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[] |

#### Defined in

[src/ui/filtering/filterstore.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;8)

## Properties

### changed

• `Private` **changed**: `any`

#### Defined in

[src/ui/filtering/filterstore.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;131)

___

### displayText

• `Private` **displayText**: `string`

#### Defined in

[src/ui/filtering/filterstore.ts:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;132)

___

### fieldByName

• `Private` **fieldByName**: `Object`

#### Index signature

▪ [key: `string`]: [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)

#### Defined in

[src/ui/filtering/filterstore.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;134)

___

### fields

• `Private` **fields**: [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;133)

___

### items

• `Private` **items**: [`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;135)

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

[src/ui/filtering/filterstore.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;154)

___

### get\_activeCriteria

▸ **get_activeCriteria**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/filtering/filterstore.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;162)

___

### get\_displayText

▸ **get_displayText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/filtering/filterstore.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;166)

___

### get\_fieldByName

▸ **get_fieldByName**(): `Object`

#### Returns

`Object`

#### Defined in

[src/ui/filtering/filterstore.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;141)

___

### get\_fields

▸ **get_fields**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;137)

___

### get\_items

▸ **get_items**(): [`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Returns

[`FilterLine`](../interfaces/corelib.FilterLine.md)[]

#### Defined in

[src/ui/filtering/filterstore.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;145)

___

### raiseChanged

▸ **raiseChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterstore.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;149)

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

[src/ui/filtering/filterstore.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;158)

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

[src/ui/filtering/filterstore.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;43)

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

[src/ui/filtering/filterstore.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterstore.ts#line&#x3D;95)
