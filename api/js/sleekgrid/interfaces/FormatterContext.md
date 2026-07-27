[@serenity-is/sleekgrid](../README.md) / FormatterContext

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

Defined in: [src/core/formatting.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L49)

The column index of the cell.

***

### column?

> `optional` **column**: [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L54)

The column definition of the cell.

***

### enableHtmlRendering

> `readonly` **enableHtmlRendering**: `boolean`

Defined in: [src/core/formatting.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L30)

True if the formatter is allowed to return raw HTML that will be set using innerHTML.
This is set from grid options and defaults to false which means the formatter
should return plain text and the result will be set using textContent and
the escape() method is a noop. If true, the formatter can return HTML strings but should
take care to avoid script injection attacks by using ctx.escape() method.

***

### grid?

> `optional` **grid**: [`ISleekGrid`](ISleekGrid.md)

Defined in: [src/core/formatting.ts:59](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L59)

The grid instance.

***

### item?

> `optional` **item**: `TItem`

Defined in: [src/core/formatting.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L64)

The item of the row.

***

### purpose?

> `optional` **purpose**: `"print"` \| `"auto-width"` \| `"excel-export"` \| `"group-header"` \| `"grand-totals"` \| `"group-totals"` \| `"header-filter"` \| `"pdf-export"`

Defined in: [src/core/formatting.ts:69](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L69)

Purpose of the call, e.g. "auto-width", "excel-export", "group-header", "header-filter", "pdf-export", "print".

***

### row?

> `optional` **row**: `number`

Defined in: [src/core/formatting.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L44)

The row index of the cell.

***

### sanitizer()

> **sanitizer**: (`dirtyHtml`) => `string`

Defined in: [src/core/formatting.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L74)

Sanitizer function to clean up dirty HTML.

#### Parameters

##### dirtyHtml

`string`

#### Returns

`string`

***

### tooltip?

> `optional` **tooltip**: `string`

Defined in: [src/core/formatting.ts:79](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L79)

Tooltip text to be added to the cell node as title attribute.

***

### value?

> `optional` **value**: `any`

Defined in: [src/core/formatting.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L82)

when returning a formatter result as HTML string, prefer ctx.escape() to avoid script injection attacks!

## Methods

### escape()

> **escape**(`value?`): `string`

Defined in: [src/core/formatting.ts:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L39)

When enableHtmlRendering is false (default), this simply returns the value as string.
When enableHtmlRendering is true, returns html escaped value / ctx.value if called without
arguments. Prefer this over ctx.value when returning HTML strings to avoid html injection
attacks when enableHtmlRendering is true. You don't have to use this inside JSX
style formatters as JSX automatically escapes values.

#### Parameters

##### value?

`any`

#### Returns

`string`
