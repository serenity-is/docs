@serenity-is/sleekgrid

# @serenity-is/sleekgrid

## Table of contents

### Namespaces

- [Editors](modules/Editors.md)
- [Formatters](modules/Formatters.md)

### Classes

- [AutoTooltips](classes/AutoTooltips.md)
- [CheckboxEditor](classes/CheckboxEditor.md)
- [DateEditor](classes/DateEditor.md)
- [EditorLock](classes/EditorLock.md)
- [EventData](classes/EventData.md)
- [EventEmitter](classes/EventEmitter.md)
- [EventSubscriber](classes/EventSubscriber.md)
- [FloatEditor](classes/FloatEditor.md)
- [Grid](classes/Grid.md)
- [Group](classes/Group.md)
- [GroupItemMetadataProvider](classes/GroupItemMetadataProvider.md)
- [GroupTotals](classes/GroupTotals.md)
- [IntegerEditor](classes/IntegerEditor.md)
- [LongTextEditor](classes/LongTextEditor.md)
- [NonDataRow](classes/NonDataRow.md)
- [PercentCompleteEditor](classes/PercentCompleteEditor.md)
- [Range](classes/Range.md)
- [TextEditor](classes/TextEditor.md)
- [YesNoSelectEditor](classes/YesNoSelectEditor.md)

### Interfaces

- [ArgsAddNewRow](interfaces/ArgsAddNewRow.md)
- [ArgsCell](interfaces/ArgsCell.md)
- [ArgsCellChange](interfaces/ArgsCellChange.md)
- [ArgsCellEdit](interfaces/ArgsCellEdit.md)
- [ArgsColumn](interfaces/ArgsColumn.md)
- [ArgsColumnNode](interfaces/ArgsColumnNode.md)
- [ArgsCssStyle](interfaces/ArgsCssStyle.md)
- [ArgsEditorDestroy](interfaces/ArgsEditorDestroy.md)
- [ArgsGrid](interfaces/ArgsGrid.md)
- [ArgsScroll](interfaces/ArgsScroll.md)
- [ArgsSelectedRowsChange](interfaces/ArgsSelectedRowsChange.md)
- [ArgsSort](interfaces/ArgsSort.md)
- [ArgsValidationError](interfaces/ArgsValidationError.md)
- [AutoTooltipsOptions](interfaces/AutoTooltipsOptions.md)
- [Column](interfaces/Column.md)
- [ColumnMetadata](interfaces/ColumnMetadata.md)
- [ColumnSort](interfaces/ColumnSort.md)
- [CompatFormatterResult](interfaces/CompatFormatterResult.md)
- [EditCommand](interfaces/EditCommand.md)
- [EditController](interfaces/EditController.md)
- [Editor](interfaces/Editor.md)
- [EditorClass](interfaces/EditorClass.md)
- [EditorFactory](interfaces/EditorFactory.md)
- [EditorHost](interfaces/EditorHost.md)
- [EditorOptions](interfaces/EditorOptions.md)
- [FormatterContext](interfaces/FormatterContext.md)
- [FormatterFactory](interfaces/FormatterFactory.md)
- [GridOptions](interfaces/GridOptions.md)
- [GroupItemMetadataProviderOptions](interfaces/GroupItemMetadataProviderOptions.md)
- [IEventData](interfaces/IEventData.md)
- [IPlugin](interfaces/IPlugin.md)
- [ItemMetadata](interfaces/ItemMetadata.md)
- [LayoutEngine](interfaces/LayoutEngine.md)
- [LayoutHost](interfaces/LayoutHost.md)
- [Position](interfaces/Position.md)
- [RowCell](interfaces/RowCell.md)
- [SelectionModel](interfaces/SelectionModel.md)
- [ValidationResult](interfaces/ValidationResult.md)
- [ViewRange](interfaces/ViewRange.md)
- [ViewportInfo](interfaces/ViewportInfo.md)

### Type Aliases

- [ArgsSortCol](README.md#argssortcol)
- [AsyncPostCleanup](README.md#asyncpostcleanup)
- [AsyncPostRender](README.md#asyncpostrender)
- [CellStylesHash](README.md#cellstyleshash)
- [ColumnFormat](README.md#columnformat)
- [CompatFormatter](README.md#compatformatter)
- [EventListener](README.md#eventlistener)

### Variables

- [BasicLayout](README.md#basiclayout)
- [FrozenLayout](README.md#frozenlayout)
- [GlobalEditorLock](README.md#globaleditorlock)
- [columnDefaults](README.md#columndefaults)
- [gridDefaults](README.md#griddefaults)
- [keyCode](README.md#keycode)
- [preClickClassName](README.md#preclickclassname)

### Functions

- [CheckboxFormatter](README.md#checkboxformatter)
- [CheckmarkFormatter](README.md#checkmarkformatter)
- [H](README.md#h)
- [PercentCompleteBarFormatter](README.md#percentcompletebarformatter)
- [PercentCompleteFormatter](README.md#percentcompleteformatter)
- [YesNoFormatter](README.md#yesnoformatter)
- [addClass](README.md#addclass)
- [applyFormatterResultToCellNode](README.md#applyformatterresulttocellnode)
- [convertCompatFormatter](README.md#convertcompatformatter)
- [defaultColumnFormat](README.md#defaultcolumnformat)
- [disableSelection](README.md#disableselection)
- [escape](README.md#escape)
- [initializeColumns](README.md#initializecolumns)
- [parsePx](README.md#parsepx)
- [patchEvent](README.md#patchevent)
- [removeClass](README.md#removeclass)
- [spacerDiv](README.md#spacerdiv)
- [titleize](README.md#titleize)

## Type Aliases

### ArgsSortCol

Ƭ **ArgsSortCol**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `sortAsc` | `boolean` |
| `sortCol` | [`Column`](interfaces/Column.md) |

#### Defined in

[grid/eventargs.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/eventargs.ts#L16)

___

### AsyncPostCleanup

Ƭ **AsyncPostCleanup**<`TItem`\>: (`cellNode`: `HTMLElement`, `row?`: `number`, `column?`: [`Column`](interfaces/Column.md)<`TItem`\>) => `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`cellNode`, `row?`, `column?`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `HTMLElement` |
| `row?` | `number` |
| `column?` | [`Column`](interfaces/Column.md)<`TItem`\> |

##### Returns

`void`

#### Defined in

[core/formatting.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L35)

___

### AsyncPostRender

Ƭ **AsyncPostRender**<`TItem`\>: (`cellNode`: `HTMLElement`, `row`: `number`, `item`: `TItem`, `column`: [`Column`](interfaces/Column.md)<`TItem`\>, `reRender`: `boolean`) => `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`cellNode`, `row`, `item`, `column`, `reRender`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `HTMLElement` |
| `row` | `number` |
| `item` | `TItem` |
| `column` | [`Column`](interfaces/Column.md)<`TItem`\> |
| `reRender` | `boolean` |

##### Returns

`void`

#### Defined in

[core/formatting.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L34)

___

### CellStylesHash

Ƭ **CellStylesHash**: `Object`

#### Index signature

▪ [row: `number`]: { `[columnId: string]`: `string`;  }

#### Defined in

[core/formatting.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L37)

___

### ColumnFormat

Ƭ **ColumnFormat**<`TItem`\>: (`ctx`: [`FormatterContext`](interfaces/FormatterContext.md)<`TItem`\>) => `string`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`ctx`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`TItem`\> |

##### Returns

`string`

#### Defined in

[core/formatting.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L19)

___

### CompatFormatter

Ƭ **CompatFormatter**<`TItem`\>: (`row`: `number`, `cell`: `number`, `value`: `any`, `column`: [`Column`](interfaces/Column.md)<`TItem`\>, `item`: `TItem`, `grid?`: `any`) => `string` \| [`CompatFormatterResult`](interfaces/CompatFormatterResult.md)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Type declaration

▸ (`row`, `cell`, `value`, `column`, `item`, `grid?`): `string` \| [`CompatFormatterResult`](interfaces/CompatFormatterResult.md)

##### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |
| `value` | `any` |
| `column` | [`Column`](interfaces/Column.md)<`TItem`\> |
| `item` | `TItem` |
| `grid?` | `any` |

##### Returns

`string` \| [`CompatFormatterResult`](interfaces/CompatFormatterResult.md)

#### Defined in

[core/formatting.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L27)

___

### EventListener

Ƭ **EventListener**<`TArgs`, `TEventData`\>: (`e`: `TEventData`, `args`: `TArgs`) => `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | `TArgs` |
| `TEventData` | extends [`IEventData`](interfaces/IEventData.md) = [`IEventData`](interfaces/IEventData.md) |

#### Type declaration

▸ (`e`, `args`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `TEventData` |
| `args` | `TArgs` |

##### Returns

`void`

#### Defined in

[core/event.ts:1](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L1)

## Variables

### BasicLayout

• `Const` **BasicLayout**: () => [`LayoutEngine`](interfaces/LayoutEngine.md)

#### Type declaration

• **new BasicLayout**(): [`LayoutEngine`](interfaces/LayoutEngine.md)

##### Returns

[`LayoutEngine`](interfaces/LayoutEngine.md)

#### Defined in

[grid/basiclayout.ts:4](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/basiclayout.ts#L4)

___

### FrozenLayout

• `Const` **FrozenLayout**: () => [`LayoutEngine`](interfaces/LayoutEngine.md)

#### Type declaration

• **new FrozenLayout**(): [`LayoutEngine`](interfaces/LayoutEngine.md)

##### Returns

[`LayoutEngine`](interfaces/LayoutEngine.md)

#### Defined in

[layouts/frozenlayout.ts:4](https://github.com/serenity-is/sleekgrid/blob/master/src/layouts/frozenlayout.ts#L4)

___

### GlobalEditorLock

• `Const` **GlobalEditorLock**: [`EditorLock`](classes/EditorLock.md)

A global singleton editor lock.

**`Static`**

#### Defined in

[core/editing.ts:176](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#L176)

___

### columnDefaults

• `Const` **columnDefaults**: `Partial`<[`Column`](interfaces/Column.md)\>

#### Defined in

[core/column.ts:41](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L41)

___

### gridDefaults

• `Const` **gridDefaults**: [`GridOptions`](interfaces/GridOptions.md)

#### Defined in

[grid/gridoptions.ts:78](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L78)

___

### keyCode

• `Const` **keyCode**: `Object`

**`Deprecated`**

#### Type declaration

| Name | Type |
| :------ | :------ |
| `BACKSPACE` | `number` |
| `DELETE` | `number` |
| `DOWN` | `number` |
| `END` | `number` |
| `ENTER` | `number` |
| `ESCAPE` | `number` |
| `HOME` | `number` |
| `INSERT` | `number` |
| `LEFT` | `number` |
| `PAGEDOWN` | `number` |
| `PAGEUP` | `number` |
| `RIGHT` | `number` |
| `TAB` | `number` |
| `UP` | `number` |

#### Defined in

[core/event.ts:159](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L159)

___

### preClickClassName

• `Const` **preClickClassName**: ``"slick-edit-preclick"``

#### Defined in

[core/base.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/core/base.ts#L8)

## Functions

### CheckboxFormatter

▸ **CheckboxFormatter**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

`string`

#### Defined in

[formatters/formatters.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/formatters/formatters.ts#L32)

___

### CheckmarkFormatter

▸ **CheckmarkFormatter**(`ctx`): ``""`` \| ``"<i class=\"slick-checkmark\"></i>"``

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

``""`` \| ``"<i class=\"slick-checkmark\"></i>"``

#### Defined in

[formatters/formatters.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/formatters/formatters.ts#L36)

___

### H

▸ **H**<`K`\>(`tag`, `attr?`, `...children`): `HTMLElementTagNameMap`[`K`]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementTagNameMap` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `tag` | `K` |
| `attr?` | `Object` |
| `attr.ref?` | (`el?`: `HTMLElementTagNameMap`[`K`]) => `void` |
| `...children` | (`string` \| `Node`)[] |

#### Returns

`HTMLElementTagNameMap`[`K`]

#### Defined in

[core/util.ts:60](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L60)

___

### PercentCompleteBarFormatter

▸ **PercentCompleteBarFormatter**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

`string`

#### Defined in

[formatters/formatters.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/formatters/formatters.ts#L12)

___

### PercentCompleteFormatter

▸ **PercentCompleteFormatter**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

`string`

#### Defined in

[formatters/formatters.ts:3](https://github.com/serenity-is/sleekgrid/blob/master/src/formatters/formatters.ts#L3)

___

### YesNoFormatter

▸ **YesNoFormatter**(`ctx`): ``"Yes"`` \| ``"No"``

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

``"Yes"`` \| ``"No"``

#### Defined in

[formatters/formatters.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/formatters/formatters.ts#L27)

___

### addClass

▸ **addClass**(`el`, `cls`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Element` |
| `cls` | `string` |

#### Returns

`void`

#### Defined in

[core/util.ts:1](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L1)

___

### applyFormatterResultToCellNode

▸ **applyFormatterResultToCellNode**(`ctx`, `html`, `node`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |
| `html` | `string` |
| `node` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[core/formatting.ts:58](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L58)

___

### convertCompatFormatter

▸ **convertCompatFormatter**(`compatFormatter`): [`ColumnFormat`](README.md#columnformat)

#### Parameters

| Name | Type |
| :------ | :------ |
| `compatFormatter` | [`CompatFormatter`](README.md#compatformatter)<`any`\> |

#### Returns

[`ColumnFormat`](README.md#columnformat)

#### Defined in

[core/formatting.ts:43](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L43)

___

### defaultColumnFormat

▸ **defaultColumnFormat**(`ctx`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | [`FormatterContext`](interfaces/FormatterContext.md)<`any`\> |

#### Returns

`any`

#### Defined in

[core/formatting.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/core/formatting.ts#L39)

___

### disableSelection

▸ **disableSelection**(`target`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[core/util.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L39)

___

### escape

▸ **escape**(`s`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `s` | `any` |

#### Returns

`any`

#### Defined in

[core/util.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L26)

___

### initializeColumns

▸ **initializeColumns**(`columns`, `defaults`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columns` | [`Column`](interfaces/Column.md)<`any`\>[] |
| `defaults` | `Partial`<[`Column`](interfaces/Column.md)<`any`\>\> |

#### Returns

`void`

#### Defined in

[core/column.ts:76](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L76)

___

### parsePx

▸ **parsePx**(`str`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `str` | `string` |

#### Returns

`number`

#### Defined in

[core/util.ts:88](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L88)

___

### patchEvent

▸ **patchEvent**(`e`): [`IEventData`](interfaces/IEventData.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`IEventData`](interfaces/IEventData.md) |

#### Returns

[`IEventData`](interfaces/IEventData.md)

#### Defined in

[core/event.ts:185](https://github.com/serenity-is/sleekgrid/blob/master/src/core/event.ts#L185)

___

### removeClass

▸ **removeClass**(`el`, `cls`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `Element` |
| `cls` | `string` |

#### Returns

`void`

#### Defined in

[core/util.ts:47](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L47)

___

### spacerDiv

▸ **spacerDiv**(`width`): `HTMLDivElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `width` | `string` |

#### Returns

`HTMLDivElement`

#### Defined in

[core/util.ts:84](https://github.com/serenity-is/sleekgrid/blob/master/src/core/util.ts#L84)

___

### titleize

▸ **titleize**(`str`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `str` | `string` |

#### Returns

`string`

#### Defined in

[core/column.ts:112](https://github.com/serenity-is/sleekgrid/blob/master/src/core/column.ts#L112)
