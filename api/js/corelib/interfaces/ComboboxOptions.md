[corelib](../README.md) / ComboboxOptions

# Interface: ComboboxOptions\<TSource\>

Defined in: [src/ui/editors/combobox.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L29)

## Type Parameters

### TSource

`TSource` = `any`

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/combobox.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L30)

***

### arbitraryValues?

> `optional` **arbitraryValues**: `boolean`

Defined in: [src/ui/editors/combobox.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L34)

Allow arbitrary values for items

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`s`) => [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

Defined in: [src/ui/editors/combobox.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L31)

#### Parameters

##### s

`string`

#### Returns

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

***

### element?

> `optional` **element**: `HTMLInputElement` \| `HTMLSelectElement` \| `Element`[]

Defined in: [src/ui/editors/combobox.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L32)

***

### formatResult()?

> `optional` **formatResult**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L36)

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L35)

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/combobox.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L37)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/combobox.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L38)

***

### pageSize?

> `optional` **pageSize**: `number`

Defined in: [src/ui/editors/combobox.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L40)

Page size to use while loading or displaying results

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/combobox.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L41)

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/ui/editors/combobox.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L43)

Callback to get options specific to the combobox provider type

#### Parameters

##### type

`"select2"`

##### opt

`ComboboxOptions`

#### Returns

`any`

***

### search()?

> `optional` **search**: (`query`) => [`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

Defined in: [src/ui/editors/combobox.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L44)

#### Parameters

##### query

[`ComboboxSearchQuery`](ComboboxSearchQuery.md)

#### Returns

[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/editors/combobox.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L46)

Type delay for searching, default is 200
