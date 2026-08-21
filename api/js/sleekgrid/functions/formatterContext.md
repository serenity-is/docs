[@serenity-is/sleekgrid](../README.md) / formatterContext

# Function: formatterContext()

> **formatterContext**\<`TItem`\>(`opt?`): [`FormatterContext`](../interfaces/FormatterContext.md)\<`TItem`\>

Defined in: [src/core/formatting.ts:275](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L275)

Creates a [FormatterContext](../interfaces/FormatterContext.md) populated with sensible defaults from the grid
options and DOMPurify (when available).

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Parameters

### opt?

`Partial`\<`Exclude`\<[`FormatterContext`](../interfaces/FormatterContext.md)\<`TItem`\>, `"addAttrs"` \| `"addClass"` \| `"tooltip"`\>\>

Partial context fields to pre-fill; `addAttrs`/`addClass`/`tooltip` are managed by the formatter itself.

## Returns

[`FormatterContext`](../interfaces/FormatterContext.md)\<`TItem`\>

Fully initialized formatter context ready to pass to a [ColumnFormat](../type-aliases/ColumnFormat.md).
