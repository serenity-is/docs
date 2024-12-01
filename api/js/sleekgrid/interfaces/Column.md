[@serenity-is/sleekgrid](../README.md) / Column

# Interface: Column\<TItem\>

## Type Parameters

• **TItem** = `any`

## Properties

### asyncPostRender?

> `optional` **asyncPostRender**: [`AsyncPostRender`](../type-aliases/AsyncPostRender.md)\<`TItem`\>

#### Defined in

[core/column.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L6)

***

### asyncPostRenderCleanup?

> `optional` **asyncPostRenderCleanup**: [`AsyncPostCleanup`](../type-aliases/AsyncPostCleanup.md)\<`TItem`\>

#### Defined in

[core/column.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L7)

***

### behavior?

> `optional` **behavior**: `any`

#### Defined in

[core/column.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L8)

***

### cannotTriggerInsert?

> `optional` **cannotTriggerInsert**: `boolean`

#### Defined in

[core/column.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L9)

***

### cssClass?

> `optional` **cssClass**: `string`

#### Defined in

[core/column.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L10)

***

### defaultSortAsc?

> `optional` **defaultSortAsc**: `boolean`

#### Defined in

[core/column.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L11)

***

### editor?

> `optional` **editor**: [`EditorClass`](EditorClass.md)

#### Defined in

[core/column.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L12)

***

### editorFixedDecimalPlaces?

> `optional` **editorFixedDecimalPlaces**: `number`

#### Defined in

[core/column.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L13)

***

### field?

> `optional` **field**: `string`

#### Defined in

[core/column.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L14)

***

### focusable?

> `optional` **focusable**: `boolean`

#### Defined in

[core/column.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L16)

***

### footerCssClass?

> `optional` **footerCssClass**: `string`

#### Defined in

[core/column.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L17)

***

### format?

> `optional` **format**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Defined in

[core/column.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L18)

***

### ~~formatter?~~

> `optional` **formatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

#### Deprecated

#### Defined in

[core/column.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L20)

***

### frozen?

> `optional` **frozen**: `boolean`

#### Defined in

[core/column.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L15)

***

### groupTotalsFormatter()?

> `optional` **groupTotalsFormatter**: (`p1`?, `p2`?, `grid`?) => `string`

#### Parameters

##### p1?

[`GroupTotals`](../classes/GroupTotals.md)\<`TItem`\>

##### p2?

[`Column`](Column.md)\<`TItem`\>

##### grid?

`unknown`

#### Returns

`string`

#### Defined in

[core/column.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L21)

***

### headerCssClass?

> `optional` **headerCssClass**: `string`

#### Defined in

[core/column.ts:22](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L22)

***

### id?

> `optional` **id**: `string`

#### Defined in

[core/column.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L23)

***

### maxWidth?

> `optional` **maxWidth**: `any`

#### Defined in

[core/column.ts:24](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L24)

***

### minWidth?

> `optional` **minWidth**: `number`

#### Defined in

[core/column.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L25)

***

### name?

> `optional` **name**: `string`

#### Defined in

[core/column.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L26)

***

### nameIsHtml?

> `optional` **nameIsHtml**: `boolean`

#### Defined in

[core/column.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L27)

***

### previousWidth?

> `optional` **previousWidth**: `number`

#### Defined in

[core/column.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L28)

***

### referencedFields?

> `optional` **referencedFields**: `string`[]

#### Defined in

[core/column.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L29)

***

### rerenderOnResize?

> `optional` **rerenderOnResize**: `boolean`

#### Defined in

[core/column.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L30)

***

### resizable?

> `optional` **resizable**: `boolean`

#### Defined in

[core/column.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L31)

***

### selectable?

> `optional` **selectable**: `boolean`

#### Defined in

[core/column.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L32)

***

### sortable?

> `optional` **sortable**: `boolean`

#### Defined in

[core/column.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L33)

***

### sortOrder?

> `optional` **sortOrder**: `number`

#### Defined in

[core/column.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L34)

***

### toolTip?

> `optional` **toolTip**: `string`

#### Defined in

[core/column.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L35)

***

### validator()?

> `optional` **validator**: (`value`, `editorArgs`?) => [`ValidationResult`](ValidationResult.md)

#### Parameters

##### value

`any`

##### editorArgs?

`any`

#### Returns

[`ValidationResult`](ValidationResult.md)

#### Defined in

[core/column.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L36)

***

### visible?

> `optional` **visible**: `boolean`

#### Defined in

[core/column.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L37)

***

### width?

> `optional` **width**: `number`

#### Defined in

[core/column.ts:38](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L38)
