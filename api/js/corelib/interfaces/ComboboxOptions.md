[@serenity-is/corelib](../README.md) / ComboboxOptions

# Interface: ComboboxOptions\<TSource\>

Defined in: [src/ui/editors/combobox.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L62)

Options for the [Combobox](../classes/Combobox.md).

## Type Parameters

### TSource

`TSource` = `any`

The source item type.

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/combobox.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L64)

Whether the selection can be cleared.

***

### arbitraryValues?

> `optional` **arbitraryValues**: `boolean`

Defined in: [src/ui/editors/combobox.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L70)

Allow arbitrary values for items.

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`s`) => [`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

Defined in: [src/ui/editors/combobox.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L66)

Callback that creates a search choice for arbitrary values.

#### Parameters

##### s

`string`

#### Returns

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

***

### element?

> `optional` **element**: `HTMLInputElement` \| `HTMLSelectElement` \| `Element`[]

Defined in: [src/ui/editors/combobox.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L68)

The element to attach the combobox to.

***

### formatResult()?

> `optional` **formatResult**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L74)

Formatter for result items.

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`) => [`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

Defined in: [src/ui/editors/combobox.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L72)

Formatter for the selected item.

#### Parameters

##### p1

[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>

#### Returns

[`ComboboxFormatResult`](../type-aliases/ComboboxFormatResult.md)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/combobox.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L76)

Minimum results required to show the search box.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/combobox.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L78)

Whether multiple items can be selected.

***

### pageSize?

> `optional` **pageSize**: `number`

Defined in: [src/ui/editors/combobox.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L80)

Page size to use while loading or displaying results.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/combobox.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L82)

Placeholder text.

***

### providerOptions()?

> `optional` **providerOptions**: (`type`, `opt`) => `any`

Defined in: [src/ui/editors/combobox.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L84)

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

Defined in: [src/ui/editors/combobox.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L86)

Callback that performs the search.

#### Parameters

##### query

[`ComboboxSearchQuery`](ComboboxSearchQuery.md)

#### Returns

[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\> \| `PromiseLike`\<[`ComboboxSearchResult`](ComboboxSearchResult.md)\<[`ComboboxItem`](ComboboxItem.md)\<`TSource`\>\>\>

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/editors/combobox.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L88)

Type delay for searching, default is 200.
