[@serenity-is/corelib](../README.md) / ComboboxOptions

# Interface: ComboboxOptions\<TSource\>

## Type Parameters

• **TSource** = `any`

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

#### Defined in

[src/ui/editors/combobox.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L30)

***

### arbitraryValues?

> `optional` **arbitraryValues**: `boolean`

Allow arbitrary values for items

#### Defined in

[src/ui/editors/combobox.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L34)

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`s`) => [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Parameters

##### s

`string`

#### Returns

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Defined in

[src/ui/editors/combobox.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L31)

***

### element?

> `optional` **element**: `HTMLInputElement` \| `HTMLSelectElement` \| `Element`[]

#### Defined in

[src/ui/editors/combobox.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L32)

***

### formatResult()?

> `optional` **formatResult**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

#### Defined in

[src/ui/editors/combobox.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L36)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

#### Defined in

[src/ui/editors/combobox.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L35)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

#### Defined in

[src/ui/editors/combobox.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L37)

***

### multiple?

> `optional` **multiple**: `boolean`

#### Defined in

[src/ui/editors/combobox.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L38)

***

### pageSize?

> `optional` **pageSize**: `number`

Page size to use while loading or displaying results

#### Defined in

[src/ui/editors/combobox.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L40)

***

### placeholder?

> `optional` **placeholder**: `string`

#### Defined in

[src/ui/editors/combobox.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L41)

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Callback to get options specific to the combobox provider type

#### Parameters

##### type

`"select2"`

##### opt

[`ComboboxOptions`](ComboboxOptions.md)\<`any`\>

#### Returns

`any`

#### Defined in

[src/ui/editors/combobox.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L43)

***

### search()?

> `optional` **search**: (`query`) => [`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

#### Parameters

##### query

[`ComboboxSearchQuery`](ComboboxSearchQuery.md)

#### Returns

[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

#### Defined in

[src/ui/editors/combobox.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L44)

***

### typeDelay?

> `optional` **typeDelay**: `number`

Type delay for searching, default is 200

#### Defined in

[src/ui/editors/combobox.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L46)
