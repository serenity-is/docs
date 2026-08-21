[@serenity-is/corelib](../README.md) / DateYearEditorOptions

# Interface: DateYearEditorOptions

Defined in: [src/ui/editors/dateyeareditor.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L77)

Options for the [DateYearEditor](../classes/DateYearEditor.md).

## Extends

- [`SelectEditorOptions`](SelectEditorOptions.md)

## Properties

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L19)

Whether the selection can be cleared.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`allowClear`](SelectEditorOptions.md#allowclear)

***

### delimited?

> `optional` **delimited**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L21)

Whether multiple items can be selected.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`delimited`](SelectEditorOptions.md#delimited)

***

### descending?

> `optional` **descending**: `boolean`

Defined in: [src/ui/editors/dateyeareditor.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L83)

Whether years are listed in descending order.

***

### emptyOptionText?

> `optional` **emptyOptionText**: `string`

Defined in: [src/ui/editors/selecteditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L67)

Text for the empty option.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`emptyOptionText`](SelectEditorOptions.md#emptyoptiontext)

***

### items?

> `optional` **items**: `any`[]

Defined in: [src/ui/editors/selecteditor.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L65)

Items to display; each is a value or a [value, text] pair.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`items`](SelectEditorOptions.md#items)

***

### maxYear?

> `optional` **maxYear**: `string`

Defined in: [src/ui/editors/dateyeareditor.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L81)

Maximum year as an absolute value or relative offset (e.g. "+10" or "-5").

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L23)

Minimum results required to show the search box.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`minimumResultsForSearch`](SelectEditorOptions.md#minimumresultsforsearch)

***

### minYear?

> `optional` **minYear**: `string`

Defined in: [src/ui/editors/dateyeareditor.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L79)

Minimum year as an absolute value or relative offset (e.g. "-10" or "+5").

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L25)

Whether multiple items can be selected.

#### Inherited from

[`SelectEditorOptions`](SelectEditorOptions.md).[`multiple`](SelectEditorOptions.md#multiple)
