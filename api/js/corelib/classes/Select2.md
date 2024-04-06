[@serenity-is/corelib](../README.md) / Select2

# Class: Select2

## Table of contents

### Constructors

- [constructor](Select2.md#constructor)

### Properties

- [el](Select2.md#el)
- [ajaxDefaults](Select2.md#ajaxdefaults)
- [defaults](Select2.md#defaults)

### Accessors

- [container](Select2.md#container)
- [data](Select2.md#data)
- [dropdown](Select2.md#dropdown)
- [instance](Select2.md#instance)
- [isFocused](Select2.md#isfocused)
- [isMultiple](Select2.md#ismultiple)
- [opened](Select2.md#opened)
- [search](Select2.md#search)
- [val](Select2.md#val)

### Methods

- [close](Select2.md#close)
- [destroy](Select2.md#destroy)
- [disable](Select2.md#disable)
- [enable](Select2.md#enable)
- [focus](Select2.md#focus)
- [open](Select2.md#open)
- [positionDropdown](Select2.md#positiondropdown)
- [readonly](Select2.md#readonly)
- [getInstance](Select2.md#getinstance)
- [stripDiacritics](Select2.md#stripdiacritics)

## Constructors

### constructor

• **new Select2**(`opts?`): [`Select2`](Select2.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `opts?` | [`Select2Options`](../interfaces/Select2Options.md) |

#### Returns

[`Select2`](Select2.md)

#### Defined in

[src/ui/editors/select2.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L482)

## Properties

### el

• `Private` **el**: `Select2Element`

#### Defined in

[src/ui/editors/select2.ts:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L480)

___

### ajaxDefaults

▪ `Static` `Readonly` **ajaxDefaults**: `Select2AjaxOptions`

#### Defined in

[src/ui/editors/select2.ts:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L588)

___

### defaults

▪ `Static` `Readonly` **defaults**: [`Select2Options`](../interfaces/Select2Options.md)

#### Defined in

[src/ui/editors/select2.ts:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L597)

## Accessors

### container

• `get` **container**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/select2.ts:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L514)

___

### data

• `get` **data**(): `Select2Item` \| `Select2Item`[]

#### Returns

`Select2Item` \| `Select2Item`[]

#### Defined in

[src/ui/editors/select2.ts:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L526)

• `set` **data**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Select2Item` \| `Select2Item`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:530](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L530)

___

### dropdown

• `get` **dropdown**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/select2.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L518)

___

### instance

• `get` **instance**(): `AbstractSelect2`

#### Returns

`AbstractSelect2`

#### Defined in

[src/ui/editors/select2.ts:504](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L504)

___

### isFocused

• `get` **isFocused**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L546)

___

### isMultiple

• `get` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L550)

___

### opened

• `get` **opened**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L554)

___

### search

• `get` **search**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Defined in

[src/ui/editors/select2.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L570)

___

### val

• `get` **val**(): `string` \| `string`[]

#### Returns

`string` \| `string`[]

#### Defined in

[src/ui/editors/select2.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L574)

• `set` **val**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L578)

## Methods

### close

▸ **close**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L510)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L522)

___

### disable

▸ **disable**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:534](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L534)

___

### enable

▸ **enable**(`enabled?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `enabled?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L538)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:542](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L542)

___

### open

▸ **open**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:558](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L558)

___

### positionDropdown

▸ **positionDropdown**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:562](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L562)

___

### readonly

▸ **readonly**(`value?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L566)

___

### getInstance

▸ **getInstance**(`el`): [`Select2`](Select2.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Select2Element` |

#### Returns

[`Select2`](Select2.md)

#### Defined in

[src/ui/editors/select2.ts:582](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L582)

___

### stripDiacritics

▸ **stripDiacritics**(`str`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `str` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L662)
