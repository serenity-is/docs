[@serenity-is/sleekgrid](../README.md) / Column

# Interface: Column<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Table of contents

### Properties

- [asyncPostRender](Column.md#asyncpostrender)
- [asyncPostRenderCleanup](Column.md#asyncpostrendercleanup)
- [behavior](Column.md#behavior)
- [cannotTriggerInsert](Column.md#cannottriggerinsert)
- [cssClass](Column.md#cssclass)
- [defaultSortAsc](Column.md#defaultsortasc)
- [editor](Column.md#editor)
- [editorFixedDecimalPlaces](Column.md#editorfixeddecimalplaces)
- [field](Column.md#field)
- [focusable](Column.md#focusable)
- [footerCssClass](Column.md#footercssclass)
- [format](Column.md#format)
- [formatter](Column.md#formatter)
- [frozen](Column.md#frozen)
- [groupTotalsFormatter](Column.md#grouptotalsformatter)
- [headerCssClass](Column.md#headercssclass)
- [id](Column.md#id)
- [maxWidth](Column.md#maxwidth)
- [minWidth](Column.md#minwidth)
- [name](Column.md#name)
- [nameIsHtml](Column.md#nameishtml)
- [previousWidth](Column.md#previouswidth)
- [referencedFields](Column.md#referencedfields)
- [rerenderOnResize](Column.md#rerenderonresize)
- [resizable](Column.md#resizable)
- [selectable](Column.md#selectable)
- [sortOrder](Column.md#sortorder)
- [sortable](Column.md#sortable)
- [toolTip](Column.md#tooltip)
- [validator](Column.md#validator)
- [visible](Column.md#visible)
- [width](Column.md#width)

## Properties

### asyncPostRender

• `Optional` **asyncPostRender**: [`AsyncPostRender`](../README.md#asyncpostrender)<`TItem`\>

#### Defined in

[core/column.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L6)

___

### asyncPostRenderCleanup

• `Optional` **asyncPostRenderCleanup**: [`AsyncPostCleanup`](../README.md#asyncpostcleanup)<`TItem`\>

#### Defined in

[core/column.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L7)

___

### behavior

• `Optional` **behavior**: `any`

#### Defined in

[core/column.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L8)

___

### cannotTriggerInsert

• `Optional` **cannotTriggerInsert**: `boolean`

#### Defined in

[core/column.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L9)

___

### cssClass

• `Optional` **cssClass**: `string`

#### Defined in

[core/column.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L10)

___

### defaultSortAsc

• `Optional` **defaultSortAsc**: `boolean`

#### Defined in

[core/column.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L11)

___

### editor

• `Optional` **editor**: [`EditorClass`](EditorClass.md)

#### Defined in

[core/column.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L12)

___

### editorFixedDecimalPlaces

• `Optional` **editorFixedDecimalPlaces**: `number`

#### Defined in

[core/column.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L13)

___

### field

• `Optional` **field**: `string`

#### Defined in

[core/column.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L14)

___

### focusable

• `Optional` **focusable**: `boolean`

#### Defined in

[core/column.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L16)

___

### footerCssClass

• `Optional` **footerCssClass**: `string`

#### Defined in

[core/column.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L17)

___

### format

• `Optional` **format**: [`ColumnFormat`](../README.md#columnformat)<`TItem`\>

#### Defined in

[core/column.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L18)

___

### formatter

• `Optional` **formatter**: [`CompatFormatter`](../README.md#compatformatter)<`TItem`\>

**`Deprecated`**

#### Defined in

[core/column.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L20)

___

### frozen

• `Optional` **frozen**: `boolean`

#### Defined in

[core/column.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L15)

___

### groupTotalsFormatter

• `Optional` **groupTotalsFormatter**: (`p1?`: [`GroupTotals`](../classes/GroupTotals.md)<`TItem`\>, `p2?`: [`Column`](Column.md)<`TItem`\>, `grid?`: `unknown`) => `string`

#### Type declaration

▸ (`p1?`, `p2?`, `grid?`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1?` | [`GroupTotals`](../classes/GroupTotals.md)<`TItem`\> |
| `p2?` | [`Column`](Column.md)<`TItem`\> |
| `grid?` | `unknown` |

##### Returns

`string`

#### Defined in

[core/column.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L21)

___

### headerCssClass

• `Optional` **headerCssClass**: `string`

#### Defined in

[core/column.ts:22](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L22)

___

### id

• `Optional` **id**: `string`

#### Defined in

[core/column.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L23)

___

### maxWidth

• `Optional` **maxWidth**: `any`

#### Defined in

[core/column.ts:24](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L24)

___

### minWidth

• `Optional` **minWidth**: `number`

#### Defined in

[core/column.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L25)

___

### name

• `Optional` **name**: `string`

#### Defined in

[core/column.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L26)

___

### nameIsHtml

• `Optional` **nameIsHtml**: `boolean`

#### Defined in

[core/column.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L27)

___

### previousWidth

• `Optional` **previousWidth**: `number`

#### Defined in

[core/column.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L28)

___

### referencedFields

• `Optional` **referencedFields**: `string`[]

#### Defined in

[core/column.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L29)

___

### rerenderOnResize

• `Optional` **rerenderOnResize**: `boolean`

#### Defined in

[core/column.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L30)

___

### resizable

• `Optional` **resizable**: `boolean`

#### Defined in

[core/column.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L31)

___

### selectable

• `Optional` **selectable**: `boolean`

#### Defined in

[core/column.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L32)

___

### sortOrder

• `Optional` **sortOrder**: `number`

#### Defined in

[core/column.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L34)

___

### sortable

• `Optional` **sortable**: `boolean`

#### Defined in

[core/column.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L33)

___

### toolTip

• `Optional` **toolTip**: `string`

#### Defined in

[core/column.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L35)

___

### validator

• `Optional` **validator**: (`value`: `any`, `editorArgs?`: `any`) => [`ValidationResult`](ValidationResult.md)

#### Type declaration

▸ (`value`, `editorArgs?`): [`ValidationResult`](ValidationResult.md)

##### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |
| `editorArgs?` | `any` |

##### Returns

[`ValidationResult`](ValidationResult.md)

#### Defined in

[core/column.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L36)

___

### visible

• `Optional` **visible**: `boolean`

#### Defined in

[core/column.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L37)

___

### width

• `Optional` **width**: `number`

#### Defined in

[core/column.ts:38](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L38)
