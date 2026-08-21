[@serenity-is/corelib](../README.md) / ComboboxOptions

# Interface: ComboboxOptions\<TSource\>

Defined in: [src/ui/editors/combobox.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L59)

Options for the [Combobox](../classes/Combobox.md).

## Type Parameters

### TSource

`TSource` = `any`

The source item type.

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/combobox.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L61)

Whether the selection can be cleared.

***

### arbitraryValues?

> `optional` **arbitraryValues**: `boolean`

Defined in: [src/ui/editors/combobox.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L67)

Allow arbitrary values for items.

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`s`) => [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

Defined in: [src/ui/editors/combobox.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L63)

Callback that creates a search choice for arbitrary values.

#### Parameters

##### s

`string`

#### Returns

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

***

### element?

> `optional` **element**: `HTMLInputElement` \| `HTMLSelectElement` \| `Element`[]

Defined in: [src/ui/editors/combobox.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L65)

The element to attach the combobox to.

***

### formatResult()?

> `optional` **formatResult**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L71)

Formatter for result items.

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L69)

Formatter for the selected item.

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/combobox.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L73)

Minimum results required to show the search box.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/combobox.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L75)

Whether multiple items can be selected.

***

### pageSize?

> `optional` **pageSize**: `number`

Defined in: [src/ui/editors/combobox.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L77)

Page size to use while loading or displaying results.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/combobox.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L79)

Placeholder text.

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/ui/editors/combobox.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L81)

Callback to get options specific to the combobox provider type.

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

Defined in: [src/ui/editors/combobox.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L83)

Callback that performs the search.

#### Parameters

##### query

[`ComboboxSearchQuery`](ComboboxSearchQuery.md)

#### Returns

[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/editors/combobox.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L85)

Type delay for searching, default is 200.
