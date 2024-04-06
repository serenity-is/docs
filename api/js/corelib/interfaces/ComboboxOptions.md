[@serenity-is/corelib](../README.md) / ComboboxOptions

# Interface: ComboboxOptions\<TSource\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TSource` | `any` |

## Table of contents

### Properties

- [allowClear](ComboboxOptions.md#allowclear)
- [arbitraryValues](ComboboxOptions.md#arbitraryvalues)
- [createSearchChoice](ComboboxOptions.md#createsearchchoice)
- [element](ComboboxOptions.md#element)
- [formatResult](ComboboxOptions.md#formatresult)
- [formatSelection](ComboboxOptions.md#formatselection)
- [minimumResultsForSearch](ComboboxOptions.md#minimumresultsforsearch)
- [multiple](ComboboxOptions.md#multiple)
- [pageSize](ComboboxOptions.md#pagesize)
- [placeholder](ComboboxOptions.md#placeholder)
- [providerOptions](ComboboxOptions.md#provideroptions)
- [search](ComboboxOptions.md#search)
- [typeDelay](ComboboxOptions.md#typedelay)

## Properties

### allowClear

• `Optional` **allowClear**: `boolean`

#### Defined in

[src/ui/editors/combobox.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L30)

___

### arbitraryValues

• `Optional` **arbitraryValues**: `boolean`

Allow arbitrary values for items

#### Defined in

[src/ui/editors/combobox.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L34)

___

### createSearchChoice

• `Optional` **createSearchChoice**: (`s`: `string`) => [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Type declaration

▸ (`s`): [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `string` |

##### Returns

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Defined in

[src/ui/editors/combobox.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L31)

___

### element

• `Optional` **element**: `HTMLSelectElement` \| `HTMLInputElement` \| `Element`[]

#### Defined in

[src/ui/editors/combobox.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L32)

___

### formatResult

• `Optional` **formatResult**: (`p1`: [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>) => [`ComboboxFormatResult`](../README.md#comboboxformatresult)

#### Type declaration

▸ (`p1`): [`ComboboxFormatResult`](../README.md#comboboxformatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | [`ComboboxItem`](ComboboxItem.md)\<`TSource`\> |

##### Returns

[`ComboboxFormatResult`](../README.md#comboboxformatresult)

#### Defined in

[src/ui/editors/combobox.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L36)

___

### formatSelection

• `Optional` **formatSelection**: (`p1`: [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>) => [`ComboboxFormatResult`](../README.md#comboboxformatresult)

#### Type declaration

▸ (`p1`): [`ComboboxFormatResult`](../README.md#comboboxformatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | [`ComboboxItem`](ComboboxItem.md)\<`TSource`\> |

##### Returns

[`ComboboxFormatResult`](../README.md#comboboxformatresult)

#### Defined in

[src/ui/editors/combobox.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L35)

___

### minimumResultsForSearch

• `Optional` **minimumResultsForSearch**: `number`

#### Defined in

[src/ui/editors/combobox.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L37)

___

### multiple

• `Optional` **multiple**: `boolean`

#### Defined in

[src/ui/editors/combobox.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L38)

___

### pageSize

• `Optional` **pageSize**: `number`

Page size to use while loading or displaying results

#### Defined in

[src/ui/editors/combobox.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L40)

___

### placeholder

• `Optional` **placeholder**: `string`

#### Defined in

[src/ui/editors/combobox.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L41)

___

### providerOptions

• `Optional` **providerOptions**: (`type`: ``"select2"``, `opt`: [`ComboboxOptions`](ComboboxOptions.md)\<`any`\>) => `any`

Callback to get options specific to the combobox provider type

#### Type declaration

▸ (`type`, `opt`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `type` | ``"select2"`` |
| `opt` | [`ComboboxOptions`](ComboboxOptions.md)\<`any`\> |

##### Returns

`any`

#### Defined in

[src/ui/editors/combobox.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L43)

___

### search

• `Optional` **search**: (`query`: [`ComboboxSearchQuery`](ComboboxSearchQuery.md)) => [`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

#### Type declaration

▸ (`query`): [`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

##### Parameters

| Name | Type |
| :------ | :------ |
| `query` | [`ComboboxSearchQuery`](ComboboxSearchQuery.md) |

##### Returns

[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

#### Defined in

[src/ui/editors/combobox.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L44)

___

### typeDelay

• `Optional` **typeDelay**: `number`

Type delay for searching, default is 200

#### Defined in

[src/ui/editors/combobox.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L46)
