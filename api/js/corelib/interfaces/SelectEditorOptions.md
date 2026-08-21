[@serenity-is/corelib](../README.md) / SelectEditorOptions

# Interface: SelectEditorOptions

Defined in: [src/ui/editors/selecteditor.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L63)

Options for the [SelectEditor](../classes/SelectEditor.md).

## Extends

- [`ComboboxCommonOptions`](ComboboxCommonOptions.md)

## Extended by

- [`DateYearEditorOptions`](DateYearEditorOptions.md)

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L19)

Whether the selection can be cleared.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`allowClear`](ComboboxCommonOptions.md#allowclear)

***

### delimited?

> `optional` **delimited**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L21)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`delimited`](ComboboxCommonOptions.md#delimited)

***

### emptyOptionText?

> `optional` **emptyOptionText**: `string`

Defined in: [src/ui/editors/selecteditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L67)

Text for the empty option.

***

### items?

> `optional` **items**: `any`[]

Defined in: [src/ui/editors/selecteditor.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L65)

Items to display; each is a value or a [value, text] pair.

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L23)

Minimum results required to show the search box.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`minimumResultsForSearch`](ComboboxCommonOptions.md#minimumresultsforsearch)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L25)

Whether multiple items can be selected.

#### Inherited from

[`ComboboxCommonOptions`](ComboboxCommonOptions.md).[`multiple`](ComboboxCommonOptions.md#multiple)
