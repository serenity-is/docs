[@serenity-is/sleekgrid](../README.md) / Column

# Interface: Column\<TItem\>

Defined in: [src/core/column.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L10)

Definition of a single grid column.

## Type Parameters

### TItem

`TItem` = `any`

Row item type the column belongs to.

## Properties

### asyncPostRender?

> `optional` **asyncPostRender**: [`AsyncPostRender`](../type-aliases/AsyncPostRender.md)\<`TItem`\>

Defined in: [src/core/column.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L12)

Async post-render hook invoked after the cell node is attached to the DOM.

***

### asyncPostRenderCleanup?

> `optional` **asyncPostRenderCleanup**: [`AsyncPostCleanup`](../type-aliases/AsyncPostCleanup.md)\<`TItem`\>

Defined in: [src/core/column.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L14)

Cleanup counterpart to `asyncPostRender`; called before the node is removed or re-rendered.

***

### behavior?

> `optional` **behavior**: `any`

Defined in: [src/core/column.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L16)

Arbitrary behavior token consumed by plugins (e.g. `"selectAndMove"`).

***

### cannotTriggerInsert?

> `optional` **cannotTriggerInsert**: `boolean`

Defined in: [src/core/column.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L18)

When `true`, editing this column cannot trigger insertion of a new row.

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/core/column.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L20)

CSS class(es) applied to every body cell in this column.

***

### defaultSortAsc?

> `optional` **defaultSortAsc**: `boolean`

Defined in: [src/core/column.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L22)

Default sort direction for this column; `true` means ascending.

***

### editor?

> `optional` **editor**: [`EditorClass`](EditorClass.md)

Defined in: [src/core/column.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L24)

Editor class used when the cell enters edit mode.

***

### editorFixedDecimalPlaces?

> `optional` **editorFixedDecimalPlaces**: `number`

Defined in: [src/core/column.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L26)

Fixed number of decimal places the editor should preserve (if applicable).

***

### field?

> `optional` **field**: `string`

Defined in: [src/core/column.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L28)

Property name on `TItem` that this column is bound to.

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/core/column.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L32)

Whether cells in this column can receive focus. Defaults to `true`.

***

### footerCssClass?

> `optional` **footerCssClass**: `string`

Defined in: [src/core/column.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L34)

CSS class(es) applied to footer row cells in this column.

***

### format?

> `optional` **format**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/column.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L36)

Modern formatter for body cells. Prefer this over the deprecated `formatter`.

***

### ~~formatter?~~

> `optional` **formatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/column.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L41)

Legacy formatter for body cells.

#### Deprecated

Use [Column.format](#format) instead.

***

### frozen?

> `optional` **frozen**: `boolean` \| `"end"` \| `"start"`

Defined in: [src/core/column.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L30)

Freezing / pinning of the column. `true`/`"start"` pins to the start side, `"end"` to the end side.

***

### groupTotalsFormat()?

> `optional` **groupTotalsFormat**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/column.ts:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L43)

Formatter used to render group-totals rows for this column.

#### Parameters

##### ctx

[`FormatterContext`](FormatterContext.md)\<[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### ~~groupTotalsFormatter()?~~

> `optional` **groupTotalsFormatter**: (`totals?`, `column?`, `grid?`) => `string`

Defined in: [src/core/column.ts:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L48)

Legacy group-totals formatter.

#### Parameters

##### totals?

[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>

##### column?

`Column`\<`TItem`\>

##### grid?

`unknown`

#### Returns

`string`

#### Deprecated

Use [Column.groupTotalsFormat](#grouptotalsformat) instead.

***

### headerCssClass?

> `optional` **headerCssClass**: `string`

Defined in: [src/core/column.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L50)

CSS class(es) applied to the header cell.

***

### id?

> `optional` **id**: `string`

Defined in: [src/core/column.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L52)

Unique column identifier. Auto-generated from `field` or a fallback if omitted.

***

### maxWidth?

> `optional` **maxWidth**: `any`

Defined in: [src/core/column.ts:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L54)

Maximum pixel width the column may be resized to.

***

### minWidth?

> `optional` **minWidth**: `number`

Defined in: [src/core/column.ts:56](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L56)

Minimum pixel width the column may be resized to.

***

### name?

> `optional` **name**: `string`

Defined in: [src/core/column.ts:58](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L58)

Display name shown in the header. Defaults to a titleized form of `field`/`id`.

***

### nameFormat()?

> `optional` **nameFormat**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/column.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L60)

Formatter used to render the header `name` content.

#### Parameters

##### ctx

[`FormatterContext`](FormatterContext.md)\<`TItem`\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### previousWidth?

> `optional` **previousWidth**: `number`

Defined in: [src/core/column.ts:62](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L62)

Previous width before the last resize; managed internally for `forceFitColumns`.

***

### referencedFields?

> `optional` **referencedFields**: `string`[]

Defined in: [src/core/column.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L64)

Extra field names the column depends on (besides `field`), used for dirty tracking.

***

### rerenderOnResize?

> `optional` **rerenderOnResize**: `boolean`

Defined in: [src/core/column.ts:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L66)

When `true`, cells are re-rendered on column resize.

***

### resizable?

> `optional` **resizable**: `boolean`

Defined in: [src/core/column.ts:68](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L68)

Whether the column can be resized by dragging its header border.

***

### selectable?

> `optional` **selectable**: `boolean`

Defined in: [src/core/column.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L70)

Whether cells in this column can be selected.

***

### sortable?

> `optional` **sortable**: `boolean`

Defined in: [src/core/column.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L74)

Whether clicking the header sorts by this column.

***

### sortOrder?

> `optional` **sortOrder**: `number`

Defined in: [src/core/column.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L76)

Sort priority when multiple columns are sorted; lower numbers sort first.

***

### tabbable?

> `optional` **tabbable**: `boolean`

Defined in: [src/core/column.ts:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L72)

Whether cells in this column participate in tab navigation.

***

### toolTip?

> `optional` **toolTip**: `string`

Defined in: [src/core/column.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L78)

Tooltip text for the header cell.

***

### validator()?

> `optional` **validator**: (`value`, `editorArgs?`) => [`ValidationResult`](ValidationResult.md)

Defined in: [src/core/column.ts:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L85)

Optional validator invoked by the editor.

#### Parameters

##### value

`any`

The value to validate.

##### editorArgs?

`any`

Additional editor context, if any.

#### Returns

[`ValidationResult`](ValidationResult.md)

Validation result indicating validity and an optional message.

***

### visible?

> `optional` **visible**: `boolean`

Defined in: [src/core/column.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L87)

Whether the column is currently visible. Columns with `visible: false` are hidden but retained.

***

### width?

> `optional` **width**: `number`

Defined in: [src/core/column.ts:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L89)

Current pixel width of the column.
