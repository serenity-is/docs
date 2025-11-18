[@serenity-is/sleekgrid](../README.md) / Column

# Interface: Column\<TItem\>

Defined in: [src/core/column.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L6)

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### asyncPostRender?

> `optional` **asyncPostRender**: [`AsyncPostRender`](../type-aliases/AsyncPostRender.md)\<`TItem`\>

Defined in: [src/core/column.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L7)

***

### asyncPostRenderCleanup?

> `optional` **asyncPostRenderCleanup**: [`AsyncPostCleanup`](../type-aliases/AsyncPostCleanup.md)\<`TItem`\>

Defined in: [src/core/column.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L8)

***

### behavior?

> `optional` **behavior**: `any`

Defined in: [src/core/column.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L9)

***

### cannotTriggerInsert?

> `optional` **cannotTriggerInsert**: `boolean`

Defined in: [src/core/column.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L10)

***

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/core/column.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L11)

***

### defaultSortAsc?

> `optional` **defaultSortAsc**: `boolean`

Defined in: [src/core/column.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L12)

***

### editor?

> `optional` **editor**: [`EditorClass`](EditorClass.md)

Defined in: [src/core/column.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L13)

***

### editorFixedDecimalPlaces?

> `optional` **editorFixedDecimalPlaces**: `number`

Defined in: [src/core/column.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L14)

***

### field?

> `optional` **field**: `string`

Defined in: [src/core/column.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L15)

***

### focusable?

> `optional` **focusable**: `boolean`

Defined in: [src/core/column.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L17)

***

### footerCssClass?

> `optional` **footerCssClass**: `string`

Defined in: [src/core/column.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L18)

***

### format?

> `optional` **format**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/column.ts:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L19)

***

### formatter?

> `optional` **formatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/column.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L21)

@deprecated, use

#### See

format

***

### frozen?

> `optional` **frozen**: `boolean` \| `"end"` \| `"start"`

Defined in: [src/core/column.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L16)

***

### groupTotalsFormat()?

> `optional` **groupTotalsFormat**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/column.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L22)

#### Parameters

##### ctx

[`FormatterContext`](FormatterContext.md)\<[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### groupTotalsFormatter()?

> `optional` **groupTotalsFormatter**: (`totals?`, `column?`, `grid?`) => `string`

Defined in: [src/core/column.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L24)

@deprecated, use

#### Parameters

##### totals?

[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>

##### column?

`Column`\<`TItem`\>

##### grid?

`unknown`

#### Returns

`string`

#### See

groupTotalsFormat

***

### headerCssClass?

> `optional` **headerCssClass**: `string`

Defined in: [src/core/column.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L25)

***

### id?

> `optional` **id**: `string`

Defined in: [src/core/column.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L26)

***

### maxWidth?

> `optional` **maxWidth**: `any`

Defined in: [src/core/column.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L27)

***

### minWidth?

> `optional` **minWidth**: `number`

Defined in: [src/core/column.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L28)

***

### name?

> `optional` **name**: `string`

Defined in: [src/core/column.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L29)

***

### nameFormat()?

> `optional` **nameFormat**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/column.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L30)

#### Parameters

##### ctx

[`FormatterContext`](FormatterContext.md)\<`TItem`\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### previousWidth?

> `optional` **previousWidth**: `number`

Defined in: [src/core/column.ts:31](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L31)

***

### referencedFields?

> `optional` **referencedFields**: `string`[]

Defined in: [src/core/column.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L32)

***

### rerenderOnResize?

> `optional` **rerenderOnResize**: `boolean`

Defined in: [src/core/column.ts:33](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L33)

***

### resizable?

> `optional` **resizable**: `boolean`

Defined in: [src/core/column.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L34)

***

### selectable?

> `optional` **selectable**: `boolean`

Defined in: [src/core/column.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L35)

***

### sortable?

> `optional` **sortable**: `boolean`

Defined in: [src/core/column.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L36)

***

### sortOrder?

> `optional` **sortOrder**: `number`

Defined in: [src/core/column.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L37)

***

### toolTip?

> `optional` **toolTip**: `string`

Defined in: [src/core/column.ts:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L38)

***

### validator()?

> `optional` **validator**: (`value`, `editorArgs?`) => [`ValidationResult`](ValidationResult.md)

Defined in: [src/core/column.ts:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L39)

#### Parameters

##### value

`any`

##### editorArgs?

`any`

#### Returns

[`ValidationResult`](ValidationResult.md)

***

### visible?

> `optional` **visible**: `boolean`

Defined in: [src/core/column.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L40)

***

### width?

> `optional` **width**: `number`

Defined in: [src/core/column.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/column.ts#L41)
