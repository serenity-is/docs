[@serenity-is/sleekgrid](../README.md) / Grid

# Class: Grid\<TItem\>

## Type Parameters

• **TItem** = `any`

## Implements

- [`EditorHost`](../interfaces/EditorHost.md)

## Constructors

### new Grid()

> **new Grid**\<`TItem`\>(`container`, `data`, `columns`, `options`): [`Grid`](Grid.md)\<`TItem`\>

#### Parameters

##### container

`string` | `HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### data

`any`

##### columns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

##### options

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Returns

[`Grid`](Grid.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:126](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L126)

## Properties

### onActiveCellChanged

> `readonly` **onActiveCellChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:89](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L89)

***

### onActiveCellPositionChanged

> `readonly` **onActiveCellPositionChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:90](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L90)

***

### onAddNewRow

> `readonly` **onAddNewRow**: [`EventEmitter`](EventEmitter.md)\<[`ArgsAddNewRow`](../interfaces/ArgsAddNewRow.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:91](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L91)

***

### onBeforeCellEditorDestroy

> `readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsEditorDestroy`](../interfaces/ArgsEditorDestroy.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:92](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L92)

***

### onBeforeDestroy

> `readonly` **onBeforeDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:93](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L93)

***

### onBeforeEditCell

> `readonly` **onBeforeEditCell**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellEdit`](../interfaces/ArgsCellEdit.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:94](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L94)

***

### onBeforeFooterRowCellDestroy

> `readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:95](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L95)

***

### onBeforeHeaderCellDestroy

> `readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:96](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L96)

***

### onBeforeHeaderRowCellDestroy

> `readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:97](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L97)

***

### onCellChange

> `readonly` **onCellChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellChange`](../interfaces/ArgsCellChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:98](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L98)

***

### onCellCssStylesChanged

> `readonly` **onCellCssStylesChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCssStyle`](../interfaces/ArgsCssStyle.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:99](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L99)

***

### onClick

> `readonly` **onClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:100](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L100)

***

### onColumnsReordered

> `readonly` **onColumnsReordered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:101](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L101)

***

### onColumnsResized

> `readonly` **onColumnsResized**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:102](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L102)

***

### onCompositeEditorChange

> `readonly` **onCompositeEditorChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Implementation of

[`EditorHost`](../interfaces/EditorHost.md).[`onCompositeEditorChange`](../interfaces/EditorHost.md#oncompositeeditorchange)

#### Defined in

[grid/grid.ts:103](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L103)

***

### onContextMenu

> `readonly` **onContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L104)

***

### onDblClick

> `readonly` **onDblClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:105](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L105)

***

### onDrag

> `readonly` **onDrag**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:106](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L106)

***

### onDragEnd

> `readonly` **onDragEnd**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:107](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L107)

***

### onDragInit

> `readonly` **onDragInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:108](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L108)

***

### onDragStart

> `readonly` **onDragStart**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:109](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L109)

***

### onFooterRowCellRendered

> `readonly` **onFooterRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:110](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L110)

***

### onHeaderCellRendered

> `readonly` **onHeaderCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:111](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L111)

***

### onHeaderClick

> `readonly` **onHeaderClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:112](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L112)

***

### onHeaderContextMenu

> `readonly` **onHeaderContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:113](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L113)

***

### onHeaderMouseEnter

> `readonly` **onHeaderMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:114](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L114)

***

### onHeaderMouseLeave

> `readonly` **onHeaderMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:115](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L115)

***

### onHeaderRowCellRendered

> `readonly` **onHeaderRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:116](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L116)

***

### onKeyDown

> `readonly` **onKeyDown**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `KeyboardEvent`\>

#### Defined in

[grid/grid.ts:117](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L117)

***

### onMouseEnter

> `readonly` **onMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:118](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L118)

***

### onMouseLeave

> `readonly` **onMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:119](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L119)

***

### onScroll

> `readonly` **onScroll**: [`EventEmitter`](EventEmitter.md)\<[`ArgsScroll`](../interfaces/ArgsScroll.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:120](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L120)

***

### onSelectedRowsChanged

> `readonly` **onSelectedRowsChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSelectedRowsChange`](../interfaces/ArgsSelectedRowsChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:121](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L121)

***

### onSort

> `readonly` **onSort**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSort`](../interfaces/ArgsSort.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:122](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L122)

***

### onValidationError

> `readonly` **onValidationError**: [`EventEmitter`](EventEmitter.md)\<[`ArgsValidationError`](../interfaces/ArgsValidationError.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:123](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L123)

***

### onViewportChanged

> `readonly` **onViewportChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:124](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L124)

## Methods

### addCellCssStyles()

> **addCellCssStyles**(`key`, `hash`): `void`

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:2883](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2883)

***

### autosizeColumns()

> **autosizeColumns**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1282](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1282)

***

### canCellBeActive()

> **canCellBeActive**(`row`, `cell`): `boolean`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3862](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3862)

***

### canCellBeSelected()

> **canCellBeSelected**(`row`, `cell`): `any`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`any`

#### Defined in

[grid/grid.ts:3885](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3885)

***

### clearTextSelection()

> **clearTextSelection**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3416](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3416)

***

### columnsResized()

> **columnsResized**(`invalidate`): `void`

#### Parameters

##### invalidate

`boolean` = `true`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1062](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1062)

***

### commitCurrentEdit()

> **commitCurrentEdit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3930](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3930)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1199](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1199)

***

### editActiveCell()

> **editActiveCell**(`editor`?): `void`

#### Parameters

##### editor?

[`EditorClass`](../interfaces/EditorClass.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:3473](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3473)

***

### flashCell()

> **flashCell**(`row`, `cell`, `speed`?): `void`

#### Parameters

##### row

`number`

##### cell

`number`

##### speed?

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2918](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2918)

***

### focus()

> **focus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3310](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3310)

***

### getAbsoluteColumnMinWidth()

> **getAbsoluteColumnMinWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:466](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L466)

***

### getActiveCanvasNode()

> **getActiveCanvasNode**(`e`?): `HTMLElement`

#### Parameters

##### e?

[`IEventData`](../interfaces/IEventData.md)

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:493](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L493)

***

### getActiveCell()

> **getActiveCell**(): [`RowCell`](../interfaces/RowCell.md)

#### Returns

[`RowCell`](../interfaces/RowCell.md)

#### Implementation of

[`EditorHost`](../interfaces/EditorHost.md).[`getActiveCell`](../interfaces/EditorHost.md#getactivecell)

#### Defined in

[grid/grid.ts:3594](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3594)

***

### getActiveCellNode()

> **getActiveCellNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:3602](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3602)

***

### getActiveViewportNode()

> **getActiveViewportNode**(`e`?): `HTMLElement`

#### Parameters

##### e?

[`IEventData`](../interfaces/IEventData.md)

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:508](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L508)

***

### getCanvases()

> **getCanvases**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:488](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L488)

***

### getCanvasNode()

> **getCanvasNode**(`columnIdOrIdx`?, `row`?): `HTMLElement`

#### Parameters

##### columnIdOrIdx?

`string` | `number`

##### row?

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:484](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L484)

***

### getCellCssStyles()

> **getCellCssStyles**(`key`): [`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Parameters

##### key

`string`

#### Returns

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Defined in

[grid/grid.ts:2914](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2914)

***

### getCellEditor()

> **getCellEditor**(): [`Editor`](../interfaces/Editor.md)

#### Returns

[`Editor`](../interfaces/Editor.md)

#### Defined in

[grid/grid.ts:3590](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3590)

***

### getCellFromEvent()

> **getCellFromEvent**(`e`): `object`

#### Parameters

##### e

`any`

#### Returns

`object`

##### cell

> **cell**: `number`

##### row

> **row**: `number`

#### Defined in

[grid/grid.ts:3252](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3252)

***

### getCellFromNode()

> **getCellFromNode**(`cellNode`): `number`

#### Parameters

##### cellNode

`Element`

#### Returns

`number`

#### Defined in

[grid/grid.ts:3214](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3214)

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): `object`

#### Parameters

##### x

`number`

##### y

`number`

#### Returns

`object`

##### cell

> **cell**: `number`

##### row

> **row**: `number`

#### Defined in

[grid/grid.ts:3197](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3197)

***

### getCellNode()

> **getCellNode**(`row`, `cell`): `HTMLElement`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:3827](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3827)

***

### getCellNodeBox()

> **getCellNodeBox**(`row`, `cell`): `object`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`object`

##### bottom

> **bottom**: `number`

##### left

> **left**: `number`

##### right

> **right**: `number`

##### top

> **top**: `number`

#### Defined in

[grid/grid.ts:3272](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3272)

***

### getColspan()

> **getColspan**(`row`, `cell`): `number`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:3726](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3726)

***

### getColumnById()

> **getColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Gets a column by its ID. May also return non visible columns

#### Parameters

##### id

`string`

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1263](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1263)

***

### getColumnFromNode()

> **getColumnFromNode**(`cellNode`): [`Column`](../interfaces/Column.md)\<`TItem`\>

#### Parameters

##### cellNode

`Element`

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:3230](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3230)

***

### getColumnIndex()

> **getColumnIndex**(`id`): `number`

Returns a column's index in the visible columns list by its column ID

#### Parameters

##### id

`string`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1268](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1268)

***

### getColumns()

> **getColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Returns only the visible columns in order

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Defined in

[grid/grid.ts:1400](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1400)

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1694](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1694)

***

### getData()

> **getData**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:1585](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1585)

***

### getDataItem()

> **getDataItem**(`i`): `TItem`

#### Parameters

##### i

`number`

#### Returns

`TItem`

#### Defined in

[grid/grid.ts:1602](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1602)

***

### getDataItemValueForColumn()

> **getDataItemValueForColumn**(`item`, `columnDef`): `any`

#### Parameters

##### item

`TItem`

##### columnDef

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Returns

`any`

#### Defined in

[grid/grid.ts:1827](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1827)

***

### getDataLength()

> **getDataLength**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1589](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1589)

***

### getDisplayedScrollbarDimensions()

> **getDisplayedScrollbarDimensions**(): `object`

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Defined in

[grid/grid.ts:459](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L459)

***

### getEditController()

> **getEditController**(): [`EditController`](../interfaces/EditController.md)

#### Returns

[`EditController`](../interfaces/EditController.md)

#### Defined in

[grid/grid.ts:1258](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1258)

***

### getEditorLock()

> **getEditorLock**(): [`EditorLock`](EditorLock.md)

#### Returns

[`EditorLock`](EditorLock.md)

#### Defined in

[grid/grid.ts:1254](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1254)

***

### getFooterRow()

> **getFooterRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:612](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L612)

***

### getFooterRowColumn()

> **getFooterRowColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:616](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L616)

***

### getFormatter()

> **getFormatter**(`row`, `column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Parameters

##### row

`number`

##### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1742](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1742)

***

### getFormatterContext()

> **getFormatterContext**(`row`, `cell`): [`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

[`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

#### Defined in

[grid/grid.ts:1796](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1796)

***

### getGridPosition()

> **getGridPosition**(): [`Position`](../interfaces/Position.md)

#### Returns

[`Position`](../interfaces/Position.md)

#### Defined in

[grid/grid.ts:3563](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3563)

***

### getGroupingPanel()

> **getGroupingPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:592](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L592)

***

### getHeader()

> **getHeader**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:580](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L580)

***

### getHeaderColumn()

> **getHeaderColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:584](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L584)

***

### getHeaderRow()

> **getHeaderRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:600](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L600)

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:604](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L604)

***

### getInitialColumnIndex()

> **getInitialColumnIndex**(`id`): `number`

Gets index of a column in the initial column list passed to the grid, or setColumns method. May include invisible cols and index does not have to match visible column order.

#### Parameters

##### id

`string`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1273](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1273)

***

### getInitialColumns()

> **getInitialColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Returns list of columns passed to the grid constructor, or setColumns method. May include invisible columns and order does not match visible column order.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Defined in

[grid/grid.ts:1405](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1405)

***

### getOptions()

> **getOptions**(): [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Returns

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1495](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1495)

***

### getPluginByName()

> **getPluginByName**(`name`): [`IPlugin`](../interfaces/IPlugin.md)

#### Parameters

##### name

`string`

#### Returns

[`IPlugin`](../interfaces/IPlugin.md)

#### Defined in

[grid/grid.ts:430](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L430)

***

### getPreHeaderPanel()

> **getPreHeaderPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:596](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L596)

***

### getRenderedRange()

> **getRenderedRange**(`viewportTop`?, `viewportLeft`?): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Defined in

[grid/grid.ts:2309](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2309)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

#### Parameters

##### rowNode

`Element`

#### Returns

`number`

#### Defined in

[grid/grid.ts:3241](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3241)

***

### getScrollBarDimensions()

> **getScrollBarDimensions**(): `object`

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Defined in

[grid/grid.ts:455](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L455)

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

#### Returns

`number`[]

#### Defined in

[grid/grid.ts:4023](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L4023)

***

### getSelectionModel()

> **getSelectionModel**(): [`SelectionModel`](../interfaces/SelectionModel.md)

#### Returns

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Defined in

[grid/grid.ts:470](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L470)

***

### getSortColumns()

> **getSortColumns**(): [`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Returns

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Defined in

[grid/grid.ts:1344](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1344)

***

### getTopPanel()

> **getTopPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1610](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1610)

***

### getUID()

> **getUID**(): `string`

#### Returns

`string`

#### Defined in

[grid/grid.ts:1698](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1698)

***

### getViewport()

> **getViewport**(`viewportTop`?, `viewportLeft`?): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

##### viewportTop?

`number`

optional viewport top

##### viewportLeft?

`number`

optional viewport left

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

viewport range

#### Defined in

[grid/grid.ts:2287](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2287)

***

### getViewportNode()

> **getViewportNode**(`columnIdOrIdx`?, `row`?): `HTMLElement`

#### Parameters

##### columnIdOrIdx?

`string` | `number`

##### row?

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:500](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L500)

***

### getVisibleColumnById()

> **getVisibleColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Gets a view (e.g. visible) column by its column ID

#### Parameters

##### id

`string`

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1278](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1278)

***

### getVisibleRange()

> **getVisibleRange**(`viewportTop`?, `viewportLeft`?): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Defined in

[grid/grid.ts:2291](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2291)

***

### gotoCell()

> **gotoCell**(`row`, `cell`, `forceEdit`?): `void`

#### Parameters

##### row

`number`

##### cell

`number`

##### forceEdit?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3904](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3904)

***

### groupTotalsFormatter()

> **groupTotalsFormatter**(`p1`?, `p2`?, `grid`?): `string`

#### Parameters

##### p1?

[`GroupTotals`](GroupTotals.md)\<`TItem`\>

##### p2?

[`Column`](../interfaces/Column.md)\<`TItem`\>

##### grid?

`any`

#### Returns

`string`

#### Defined in

[grid/grid.ts:2655](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2655)

***

### init()

> **init**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:266](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L266)

***

### invalidate()

> **invalidate**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1995](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1995)

***

### invalidateAllRows()

> **invalidateAllRows**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2002](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2002)

***

### invalidateRow()

> **invalidateRow**(`row`): `void`

#### Parameters

##### row

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2088](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2088)

***

### invalidateRows()

> **invalidateRows**(`rows`): `void`

#### Parameters

##### rows

`number`[]

#### Returns

`void`

#### Defined in

[grid/grid.ts:2070](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2070)

***

### navigate()

> **navigate**(`dir`): `boolean`

#### Parameters

##### dir

`string`

Navigation direction.

#### Returns

`boolean`

Whether navigation resulted in a change of active cell.

#### Defined in

[grid/grid.ts:3780](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3780)

***

### navigateBottom()

> **navigateBottom**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3689](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3689)

***

### navigateDown()

> **navigateDown**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3752](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3752)

***

### navigateLeft()

> **navigateLeft**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3748](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3748)

***

### navigateNext()

> **navigateNext**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[`EditorHost`](../interfaces/EditorHost.md).[`navigateNext`](../interfaces/EditorHost.md#navigatenext)

#### Defined in

[grid/grid.ts:3760](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3760)

***

### navigatePageDown()

> **navigatePageDown**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3677](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3677)

***

### navigatePageUp()

> **navigatePageUp**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3681](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3681)

***

### navigatePrev()

> **navigatePrev**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[`EditorHost`](../interfaces/EditorHost.md).[`navigatePrev`](../interfaces/EditorHost.md#navigateprev)

#### Defined in

[grid/grid.ts:3764](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3764)

***

### navigateRight()

> **navigateRight**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3744](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3744)

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3772](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3772)

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3768](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3768)

***

### navigateTop()

> **navigateTop**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3685](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3685)

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

#### Parameters

##### row

`number`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3693](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3693)

***

### navigateUp()

> **navigateUp**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3756](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3756)

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

#### Parameters

##### plugin

[`IPlugin`](../interfaces/IPlugin.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:413](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L413)

***

### removeCellCssStyles()

> **removeCellCssStyles**(`key`): `void`

#### Parameters

##### key

`string`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2894](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2894)

***

### render()

> **render**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2659](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2659)

***

### resetActiveCell()

> **resetActiveCell**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3306](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3306)

***

### resizeCanvas()

> **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2171](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2171)

***

### scrollActiveCellIntoView()

> **scrollActiveCellIntoView**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3606](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3606)

***

### scrollCellIntoView()

> **scrollCellIntoView**(`row`, `cell`, `doPaging`?): `void`

#### Parameters

##### row

`number`

##### cell

`number`

##### doPaging?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3322](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3322)

***

### scrollColumnIntoView()

> **scrollColumnIntoView**(`cell`): `void`

#### Parameters

##### cell

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3332](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3332)

***

### scrollRowIntoView()

> **scrollRowIntoView**(`row`, `doPaging`?): `void`

#### Parameters

##### row

`number`

##### doPaging?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3612](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3612)

***

### scrollRowToTop()

> **scrollRowToTop**(`row`): `void`

#### Parameters

##### row

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3639](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3639)

***

### setActiveCell()

> **setActiveCell**(`row`, `cell`): `void`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3835](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3835)

***

### setActiveRow()

> **setActiveRow**(`row`, `cell`, `suppressScrollIntoView`?): `void`

#### Parameters

##### row

`number`

##### cell

`number`

##### suppressScrollIntoView?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3850](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3850)

***

### setCellCssStyles()

> **setCellCssStyles**(`key`, `hash`): `void`

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:2905](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2905)

***

### setColumnHeaderVisibility()

> **setColumnHeaderVisibility**(`visible`, `animate`?): `void`

#### Parameters

##### visible

`boolean`

##### animate?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1629](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1629)

***

### setColumns()

> **setColumns**(`columns`): `void`

#### Parameters

##### columns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Returns

`void`

#### Defined in

[grid/grid.ts:1457](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1457)

***

### setData()

> **setData**(`newData`, `scrollToTop`?): `void`

#### Parameters

##### newData

`any`

##### scrollToTop?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1574](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1574)

***

### setFooterRowVisibility()

> **setFooterRowVisibility**(`visible`): `void`

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1644](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1644)

***

### setGroupingPanelVisibility()

> **setGroupingPanelVisibility**(`visible`): `void`

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1659](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1659)

***

### setHeaderRowVisibility()

> **setHeaderRowVisibility**(`visible`): `void`

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1679](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1679)

***

### setOptions()

> **setOptions**(`args`, `suppressRender`?, `suppressColumnSet`?, `suppressSetOverflow`?): `void`

#### Parameters

##### args

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

##### suppressRender?

`boolean`

##### suppressColumnSet?

`boolean`

##### suppressSetOverflow?

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1499](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1499)

***

### setPreHeaderPanelVisibility()

> **setPreHeaderPanelVisibility**(`visible`): `void`

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1675](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1675)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

#### Parameters

##### rows

`number`[]

#### Returns

`void`

#### Defined in

[grid/grid.ts:4030](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L4030)

***

### setSelectionModel()

> **setSelectionModel**(`model`): `void`

#### Parameters

##### model

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:437](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L437)

***

### setSortColumn()

> **setSortColumn**(`columnId`, `ascending`): `void`

#### Parameters

##### columnId

`string`

##### ascending

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1313](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1313)

***

### setSortColumns()

> **setSortColumns**(`cols`): `void`

#### Parameters

##### cols

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Returns

`void`

#### Defined in

[grid/grid.ts:1317](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1317)

***

### setTopPanelVisibility()

> **setTopPanelVisibility**(`visible`): `void`

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1614](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1614)

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

#### Parameters

##### plugin

[`IPlugin`](../interfaces/IPlugin.md)

#### Returns

`void`

#### Defined in

[grid/grid.ts:418](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L418)

***

### updateCell()

> **updateCell**(`row`, `cell`): `void`

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2092](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2092)

***

### updateColumnHeader()

> **updateColumnHeader**(`columnId`, `title`?, `toolTip`?): `void`

#### Parameters

##### columnId

`string`

##### title?

`string`

##### toolTip?

`string`

#### Returns

`void`

#### Defined in

[grid/grid.ts:536](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L536)

***

### updatePagingStatusFromView()

> **updatePagingStatusFromView**(`pagingInfo`): `void`

#### Parameters

##### pagingInfo

###### pagingInfo.pageNum

`number`

###### pagingInfo.pageSize

`number`

###### pagingInfo.totalPages

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2194](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2194)

***

### updateRow()

> **updateRow**(`row`): `void`

#### Parameters

##### row

`number`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2118](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2118)

***

### updateRowCount()

> **updateRowCount**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2199](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2199)
