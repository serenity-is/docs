[@serenity-is/corelib](../README.md) / Combobox

# Class: Combobox\<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Table of contents

### Constructors

- [constructor](Combobox.md#constructor)

### Properties

- [defaults](Combobox.md#defaults)

### Accessors

- [container](Combobox.md#container)
- [isMultiple](Combobox.md#ismultiple)
- [type](Combobox.md#type)

### Methods

- [abortInitSelection](Combobox.md#abortinitselection)
- [abortPendingQuery](Combobox.md#abortpendingquery)
- [closeDropdown](Combobox.md#closedropdown)
- [dispose](Combobox.md#dispose)
- [getSelectedItem](Combobox.md#getselecteditem)
- [getSelectedItems](Combobox.md#getselecteditems)
- [getValue](Combobox.md#getvalue)
- [getValues](Combobox.md#getvalues)
- [openDropdown](Combobox.md#opendropdown)
- [setValue](Combobox.md#setvalue)
- [setValues](Combobox.md#setvalues)
- [getInstance](Combobox.md#getinstance)

## Constructors

### constructor

• **new Combobox**\<`TItem`\>(`opt`): [`Combobox`](Combobox.md)\<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\> |

#### Returns

[`Combobox`](Combobox.md)\<`TItem`\>

#### Defined in

[src/ui/editors/combobox.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L57)

## Properties

### defaults

▪ `Static` **defaults**: [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L52)

## Accessors

### container

• `get` **container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/combobox.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L247)

___

### isMultiple

• `get` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/combobox.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L263)

___

### type

• `get` **type**(): ``"select2"``

#### Returns

``"select2"``

#### Defined in

[src/ui/editors/combobox.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L253)

## Methods

### abortInitSelection

▸ **abortInitSelection**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L230)

___

### abortPendingQuery

▸ **abortPendingQuery**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L217)

___

### closeDropdown

▸ **closeDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L377)

___

### dispose

▸ **dispose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L238)

___

### getSelectedItem

▸ **getSelectedItem**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L274)

___

### getSelectedItems

▸ **getSelectedItems**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Defined in

[src/ui/editors/combobox.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L284)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/combobox.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L300)

___

### getValues

▸ **getValues**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/editors/combobox.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L316)

___

### openDropdown

▸ **openDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L381)

___

### setValue

▸ **setValue**(`value`, `triggerChange?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `string` | `undefined` |
| `triggerChange` | `boolean` | `false` |

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L336)

___

### setValues

▸ **setValues**(`value`, `triggerChange?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `string`[] | `undefined` |
| `triggerChange` | `boolean` | `false` |

#### Returns

`void`

#### Defined in

[src/ui/editors/combobox.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L368)

___

### getInstance

▸ **getInstance**(`el`): [`Combobox`](Combobox.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Element` \| `ArrayLike`\<`Element`\> |

#### Returns

[`Combobox`](Combobox.md)\<`any`\>

#### Defined in

[src/ui/editors/combobox.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L385)
