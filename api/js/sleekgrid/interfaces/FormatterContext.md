[serenity-is/sleekgrid](../README.md) / FormatterContext

# Interface: FormatterContext\<TItem\>

Defined in: [src/core/formatting.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L11)

Context object for column formatters. It provides access to the
current cell value, row index, column index, etc.
Use grid.getFormatterContext() or the

## See

formatterContext helper to create a new instance.

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### addAttrs?

> `optional` **addAttrs**: `object`

Defined in: [src/core/formatting.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L16)

Additional attributes to be added to the cell node.

#### Index Signature

\[`key`: `string`\]: `string`

***

### addClass?

> `optional` **addClass**: `string`

Defined in: [src/core/formatting.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L21)

Additional classes to be added to the cell node.

***

### cell?

> `optional` **cell**: `number`

Defined in: [src/core/formatting.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L46)

The column index of the cell.

***

### column?

> `optional` **column**: [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L51)

The column definition of the cell.

***

### enableHtmlRendering

> `readonly` **enableHtmlRendering**: `boolean`

Defined in: [src/core/formatting.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L29)

True if the formatter is allowed to return raw HTML that will be set using innerHTML.
This is set from grid options and defaults to true for backward compatibility.
When set to false, the formatter should return plain text and the result will be set using textContent
and the escape() method is a noop in that case.

***

### grid?

> `optional` **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/formatting.ts:56](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L56)

The grid instance.

***

### item?

> `optional` **item**: `TItem`

Defined in: [src/core/formatting.ts:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L61)

The item of the row.

***

### purpose?

> `optional` **purpose**: `"print"` \| `"auto-width"` \| `"excel-export"` \| `"group-header"` \| `"grand-totals"` \| `"group-totals"` \| `"header-filter"` \| `"pdf-export"`

Defined in: [src/core/formatting.ts:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L66)

Purpose of the call, e.g. "auto-width", "excel-export", "group-header", "header-filter", "pdf-export", "print".

***

### row?

> `optional` **row**: `number`

Defined in: [src/core/formatting.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L41)

The row index of the cell.

***

### sanitizer()

> **sanitizer**: (`dirtyHtml`) => `string`

Defined in: [src/core/formatting.ts:71](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L71)

Sanitizer function to clean up dirty HTML.

#### Parameters

##### dirtyHtml

`string`

#### Returns

`string`

***

### tooltip?

> `optional` **tooltip**: `string`

Defined in: [src/core/formatting.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L76)

Tooltip text to be added to the cell node as title attribute.

***

### value?

> `optional` **value**: `any`

Defined in: [src/core/formatting.ts:79](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L79)

when returning a formatter result as HTML string, prefer ctx.escape() to avoid script injection attacks!

## Methods

### escape()

> **escape**(`value?`): `string`

Defined in: [src/core/formatting.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L36)

Returns html escaped ctx.value if called without arguments. Prefer this over
ctx.value when returning as HTML string to avoid html injection attacks!
   * Note that when enableHtmlRendering is false, this is simply a noop and returns the value as string.

#### Parameters

##### value?

`any`

#### Returns

`string`
