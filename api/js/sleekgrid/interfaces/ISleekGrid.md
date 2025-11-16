[serenity-is/sleekgrid](../README.md) / ISleekGrid

# Interface: ISleekGrid\<TItem\>

Defined in: [src/core/isleekgrid.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L12)

## Extends

- [`CellNavigation`](CellNavigation.md).[`EditorHost`](EditorHost.md).[`GridPluginHost`](GridPluginHost.md)

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### onActiveCellChanged

> `readonly` **onActiveCellChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md)\>

Defined in: [src/core/isleekgrid.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L13)

***

### onActiveCellPositionChanged

> `readonly` **onActiveCellPositionChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L14)

***

### onAddNewRow

> `readonly` **onAddNewRow**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsAddNewRow`](ArgsAddNewRow.md)\>

Defined in: [src/core/isleekgrid.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L15)

***

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L16)

***

### onBeforeCellEditorDestroy

> `readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsEditorDestroy`](ArgsEditorDestroy.md)\>

Defined in: [src/core/isleekgrid.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L17)

***

### onBeforeDestroy

> `readonly` **onBeforeDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L18)

***

### onBeforeEditCell

> `readonly` **onBeforeEditCell**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCellEdit`](ArgsCellEdit.md)\>

Defined in: [src/core/isleekgrid.ts:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L19)

***

### onBeforeFooterRowCellDestroy

> `readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L20)

***

### onBeforeHeaderCellDestroy

> `readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L21)

***

### onBeforeHeaderRowCellDestroy

> `readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L22)

***

### onCellChange

> `readonly` **onCellChange**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCellChange`](ArgsCellChange.md)\>

Defined in: [src/core/isleekgrid.ts:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L23)

***

### onCellCssStylesChanged

> `readonly` **onCellCssStylesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCssStyle`](ArgsCssStyle.md)\>

Defined in: [src/core/isleekgrid.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L24)

***

### onClick

> `readonly` **onClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L25)

***

### onColumnsReordered

> `readonly` **onColumnsReordered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L26)

***

### onColumnsResized

> `readonly` **onColumnsResized**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L27)

***

### onCompositeEditorChange

> **onCompositeEditorChange**: [`EventEmitter`](../classes/EventEmitter.md)\<`any`\>

Defined in: [src/core/editing.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L28)

#### Inherited from

[`EditorHost`](EditorHost.md).[`onCompositeEditorChange`](EditorHost.md#oncompositeeditorchange)

***

### onContextMenu

> `readonly` **onContextMenu**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L28)

***

### onDblClick

> `readonly` **onDblClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L29)

***

### onDrag

> `readonly` **onDrag**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L30)

***

### onDragEnd

> `readonly` **onDragEnd**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:31](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L31)

***

### onDragInit

> `readonly` **onDragInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L32)

***

### onDragStart

> `readonly` **onDragStart**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:33](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L33)

***

### onFooterRowCellRendered

> `readonly` **onFooterRowCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L34)

***

### onHeaderCellRendered

> `readonly` **onHeaderCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L35)

***

### onHeaderClick

> `readonly` **onHeaderClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L36)

***

### onHeaderContextMenu

> `readonly` **onHeaderContextMenu**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L37)

***

### onHeaderMouseEnter

> `readonly` **onHeaderMouseEnter**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L38)

***

### onHeaderMouseLeave

> `readonly` **onHeaderMouseLeave**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L39)

***

### onHeaderRowCellRendered

> `readonly` **onHeaderRowCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L40)

***

### onKeyDown

> `readonly` **onKeyDown**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `KeyboardEvent`\>

Defined in: [src/core/isleekgrid.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L41)

***

### onMouseEnter

> `readonly` **onMouseEnter**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L42)

***

### onMouseLeave

> `readonly` **onMouseLeave**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L43)

***

### onScroll

> `readonly` **onScroll**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsScroll`](ArgsScroll.md)\>

Defined in: [src/core/isleekgrid.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L44)

***

### onSelectedRowsChanged

> `readonly` **onSelectedRowsChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsSelectedRowsChange`](ArgsSelectedRowsChange.md)\>

Defined in: [src/core/isleekgrid.ts:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L45)

***

### onSort

> `readonly` **onSort**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsSort`](ArgsSort.md)\>

Defined in: [src/core/isleekgrid.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L46)

***

### onValidationError

> `readonly` **onValidationError**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsValidationError`](ArgsValidationError.md)\>

Defined in: [src/core/isleekgrid.ts:47](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L47)

***

### onViewportChanged

> `readonly` **onViewportChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L48)

***

### render()

> **render**: () => `void`

Defined in: [src/core/isleekgrid.ts:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L129)

#### Returns

`void`

***

### resizeCanvas()

> **resizeCanvas**: () => `void`

Defined in: [src/core/isleekgrid.ts:138](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L138)

#### Returns

`void`

## Methods

### addCellCssStyles()

> **addCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/core/isleekgrid.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L50)

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

***

### autosizeColumns()

> **autosizeColumns**(): `void`

Defined in: [src/core/isleekgrid.ts:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L51)

#### Returns

`void`

***

### canCellBeActive()

> **canCellBeActive**(`row`, `cell`): `boolean`

Defined in: [src/core/isleekgrid.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L52)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

***

### canCellBeSelected()

> **canCellBeSelected**(`row`, `cell`): `boolean`

Defined in: [src/core/isleekgrid.ts:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L53)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

***

### clearTextSelection()

> **clearTextSelection**(): `void`

Defined in: [src/core/isleekgrid.ts:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L54)

#### Returns

`void`

***

### columnsResized()

> **columnsResized**(`invalidate?`): `void`

Defined in: [src/core/isleekgrid.ts:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L55)

#### Parameters

##### invalidate?

`boolean`

#### Returns

`void`

***

### commitCurrentEdit()

> **commitCurrentEdit**(): `boolean`

Defined in: [src/core/isleekgrid.ts:56](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L56)

#### Returns

`boolean`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/core/isleekgrid.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L57)

#### Returns

`void`

***

### editActiveCell()

> **editActiveCell**(`editor?`): `void`

Defined in: [src/core/isleekgrid.ts:58](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L58)

#### Parameters

##### editor?

[`EditorClass`](EditorClass.md)

#### Returns

`void`

***

### flashCell()

> **flashCell**(`row`, `cell`, `speed?`): `void`

Defined in: [src/core/isleekgrid.ts:59](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L59)

#### Parameters

##### row

`number`

##### cell

`number`

##### speed?

`number`

#### Returns

`void`

***

### focus()

> **focus**(): `void`

Defined in: [src/core/isleekgrid.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L60)

#### Returns

`void`

***

### getAbsoluteColumnMinWidth()

> **getAbsoluteColumnMinWidth**(): `number`

Defined in: [src/core/isleekgrid.ts:61](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L61)

#### Returns

`number`

***

### getActiveCanvasNode()

> **getActiveCanvasNode**(`e?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:62](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L62)

#### Parameters

##### e?

###### target

`EventTarget`

#### Returns

`HTMLElement`

***

### getActiveCell()

> **getActiveCell**(): [`RowCell`](RowCell.md)

Defined in: [src/core/editing.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L25)

#### Returns

[`RowCell`](RowCell.md)

#### Inherited from

[`EditorHost`](EditorHost.md).[`getActiveCell`](EditorHost.md#getactivecell)

***

### getActiveCellNode()

> **getActiveCellNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:63](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L63)

#### Returns

`HTMLElement`

***

### getActiveViewportNode()

> **getActiveViewportNode**(`e?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L64)

#### Parameters

##### e?

###### target

`EventTarget`

#### Returns

`HTMLElement`

***

### getAllColumns()

> **getAllColumns**(): [`Column`](Column.md)\<`TItem`\>[]

Defined in: [src/core/isleekgrid.ts:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L66)

Returns all columns in the grid, including hidden ones, the order might not match visible columns due to pinning, ordering etc.

#### Returns

[`Column`](Column.md)\<`TItem`\>[]

***

### getCanvases()

> **getCanvases**(): `any`

Defined in: [src/core/isleekgrid.ts:67](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L67)

#### Returns

`any`

***

### getCanvasNode()

> **getCanvasNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:68](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L68)

#### Parameters

##### row?

`number`

##### cell?

`number`

#### Returns

`HTMLElement`

***

### getCellCssStyles()

> **getCellCssStyles**(`key`): [`CellStylesHash`](../type-aliases/CellStylesHash.md)

Defined in: [src/core/isleekgrid.ts:69](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L69)

#### Parameters

##### key

`string`

#### Returns

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

***

### getCellEditor()

> **getCellEditor**(): [`Editor`](Editor.md)

Defined in: [src/core/isleekgrid.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L70)

#### Returns

[`Editor`](Editor.md)

***

### getCellFromEvent()

> **getCellFromEvent**(`e`): `object`

Defined in: [src/core/isleekgrid.ts:71](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L71)

#### Parameters

##### e

`any`

#### Returns

`object`

##### cell

> **cell**: `number`

##### row

> **row**: `number`

***

### getCellFromNode()

> **getCellFromNode**(`cellNode`): `number`

Defined in: [src/core/isleekgrid.ts:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L72)

#### Parameters

##### cellNode

`Element`

#### Returns

`number`

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): `object`

Defined in: [src/core/isleekgrid.ts:73](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L73)

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

***

### getCellNode()

> **getCellNode**(`row`, `cell`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L74)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`HTMLElement`

***

### getCellNodeBox()

> **getCellNodeBox**(`row`, `cell`): `object`

Defined in: [src/core/isleekgrid.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L75)

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

***

### getColspan()

> **getColspan**(`row`, `cell`): `number`

Defined in: [src/core/isleekgrid.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L76)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`number`

***

### getColumnById()

> **getColumnById**(`id`): [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L78)

Gets a column by its ID. May also return hidden columns.

#### Parameters

##### id

`string`

#### Returns

[`Column`](Column.md)\<`TItem`\>

***

### getColumnFromNode()

> **getColumnFromNode**(`cellNode`): [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:79](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L79)

#### Parameters

##### cellNode

`Element`

#### Returns

[`Column`](Column.md)\<`TItem`\>

***

### getColumnIndex()

> **getColumnIndex**(`id`, `opt?`): `number`

Defined in: [src/core/isleekgrid.ts:81](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L81)

Returns a column's index in the visible columns list by its column ID. If opt.inAll is true, it will return index in all columns.

#### Parameters

##### id

`string`

##### opt?

###### inAll?

`boolean`

#### Returns

`number`

***

### getColumns()

> **getColumns**(): [`Column`](Column.md)\<`TItem`\>[]

Defined in: [src/core/isleekgrid.ts:83](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L83)

Returns only the visible columns in order

#### Returns

[`Column`](Column.md)\<`TItem`\>[]

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:84](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L84)

#### Returns

`HTMLElement`

***

### getData()

> **getData**(): `any`

Defined in: [src/core/isleekgrid.ts:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L85)

#### Returns

`any`

***

### getDataItem()

> **getDataItem**(`row`): `TItem`

Defined in: [src/core/isleekgrid.ts:86](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L86)

#### Parameters

##### row

`number`

#### Returns

`TItem`

***

### getDataItemValueForColumn()

> **getDataItemValueForColumn**(`item`, `columnDef`): `any`

Defined in: [src/core/isleekgrid.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L87)

#### Parameters

##### item

`TItem`

##### columnDef

[`Column`](Column.md)\<`TItem`\>

#### Returns

`any`

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/core/isleekgrid.ts:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L88)

#### Returns

`number`

***

### getDisplayedScrollbarDimensions()

> **getDisplayedScrollbarDimensions**(): `object`

Defined in: [src/core/isleekgrid.ts:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L89)

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

***

### getEditController()

> **getEditController**(): [`EditController`](EditController.md)

Defined in: [src/core/isleekgrid.ts:90](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L90)

#### Returns

[`EditController`](EditController.md)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](EditorFactory.md)

Defined in: [src/core/editing.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L29)

#### Returns

[`EditorFactory`](EditorFactory.md)

#### Inherited from

[`EditorHost`](EditorHost.md).[`getEditorFactory`](EditorHost.md#geteditorfactory)

***

### getEditorLock()

> **getEditorLock**(): [`EditorLock`](../classes/EditorLock.md)

Defined in: [src/core/isleekgrid.ts:91](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L91)

#### Returns

[`EditorLock`](../classes/EditorLock.md)

***

### getFooterRow()

> **getFooterRow**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:92](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L92)

#### Returns

`HTMLElement`

***

### getFooterRowColumn()

> **getFooterRowColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L93)

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

***

### getFormatter()

> **getFormatter**(`row`, `column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:94](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L94)

#### Parameters

##### row

`number`

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

***

### getFormatterContext()

> **getFormatterContext**(`row`, `cell`): [`FormatterContext`](FormatterContext.md)

Defined in: [src/core/isleekgrid.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L95)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

[`FormatterContext`](FormatterContext.md)

***

### getGridPosition()

> **getGridPosition**(): [`Position`](Position.md)

Defined in: [src/core/isleekgrid.ts:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L96)

#### Returns

[`Position`](Position.md)

***

### getGroupingPanel()

> **getGroupingPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L97)

#### Returns

`HTMLElement`

***

### getHeader()

> **getHeader**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:98](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L98)

#### Returns

`HTMLElement`

***

### getHeaderColumn()

> **getHeaderColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:99](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L99)

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

***

### getHeaderRow()

> **getHeaderRow**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:100](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L100)

#### Returns

`HTMLElement`

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L101)

#### Parameters

##### columnIdOrIdx

`string` | `number`

#### Returns

`HTMLElement`

***

### getLayoutInfo()

> **getLayoutInfo**(): [`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

Defined in: [src/core/isleekgrid.ts:102](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L102)

#### Returns

[`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

***

### getOptions()

> **getOptions**(): [`GridOptions`](GridOptions.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:103](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L103)

#### Returns

[`GridOptions`](GridOptions.md)\<`TItem`\>

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](GridPlugin.md)

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

#### Parameters

##### name

`string`

#### Returns

[`GridPlugin`](GridPlugin.md)

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`getPluginByName`](GridPluginHost.md#getpluginbyname)

***

### getPreHeaderPanel()

> **getPreHeaderPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:104](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L104)

#### Returns

`HTMLElement`

***

### getRenderedRange()

> **getRenderedRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:105](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L105)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](ViewRange.md)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

Defined in: [src/core/isleekgrid.ts:106](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L106)

#### Parameters

##### rowNode

`Element`

#### Returns

`number`

***

### getScrollBarDimensions()

> **getScrollBarDimensions**(): `object`

Defined in: [src/core/isleekgrid.ts:107](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L107)

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/core/isleekgrid.ts:108](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L108)

#### Returns

`number`[]

***

### getSelectionModel()

> **getSelectionModel**(): [`SelectionModel`](SelectionModel.md)

Defined in: [src/core/isleekgrid.ts:109](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L109)

#### Returns

[`SelectionModel`](SelectionModel.md)

***

### getSortColumns()

> **getSortColumns**(): [`ColumnSort`](ColumnSort.md)[]

Defined in: [src/core/isleekgrid.ts:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L110)

#### Returns

[`ColumnSort`](ColumnSort.md)[]

***

### getTopPanel()

> **getTopPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:111](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L111)

#### Returns

`HTMLElement`

***

### getTotalsFormatter()

> **getTotalsFormatter**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:112](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L112)

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

***

### getUID()

> **getUID**(): `string`

Defined in: [src/core/isleekgrid.ts:113](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L113)

#### Returns

`string`

***

### getViewport()

> **getViewport**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:115](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L115)

Gets the viewport range

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](ViewRange.md)

***

### getViewportNode()

> **getViewportNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:116](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L116)

#### Parameters

##### row?

`number`

##### cell?

`number`

#### Returns

`HTMLElement`

***

### getVisibleRange()

> **getVisibleRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:117](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L117)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](ViewRange.md)

***

### gotoCell()

> **gotoCell**(`row`, `cell`, `forceEdit?`): `void`

Defined in: [src/core/isleekgrid.ts:118](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L118)

#### Parameters

##### row

`number`

##### cell

`number`

##### forceEdit?

`boolean`

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/core/isleekgrid.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L49)

#### Returns

`void`

***

### invalidate()

> **invalidate**(): `void`

Defined in: [src/core/isleekgrid.ts:119](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L119)

#### Returns

`void`

***

### invalidateAllRows()

> **invalidateAllRows**(): `void`

Defined in: [src/core/isleekgrid.ts:120](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L120)

#### Returns

`void`

***

### invalidateColumns()

> **invalidateColumns**(): `void`

Defined in: [src/core/isleekgrid.ts:125](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L125)

Invalidates various elements after properties of columns have changed.
Call this if you change columns properties that don't require a full setColumns call (e.g. width, name, visible etc.)

#### Returns

`void`

***

### invalidateRow()

> **invalidateRow**(`row`): `void`

Defined in: [src/core/isleekgrid.ts:126](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L126)

#### Parameters

##### row

`number`

#### Returns

`void`

***

### invalidateRows()

> **invalidateRows**(`rows`): `void`

Defined in: [src/core/isleekgrid.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L127)

#### Parameters

##### rows

`number`[]

#### Returns

`void`

***

### navigate()

> **navigate**(`dir`): `boolean`

Defined in: [src/core/cellnavigation.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L22)

Navigate the active cell in the specified direction.

#### Parameters

##### dir

[`CellNavigationDirection`](../type-aliases/CellNavigationDirection.md)

Navigation direction.

#### Returns

`boolean`

Whether navigation resulted in a change of active cell.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigate`](CellNavigation.md#navigate)

***

### navigateBottom()

> **navigateBottom**(): `void`

Defined in: [src/core/cellnavigation.ts:4](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L4)

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateBottom`](CellNavigation.md#navigatebottom)

***

### navigateDown()

> **navigateDown**(): `boolean`

Defined in: [src/core/cellnavigation.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L5)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateDown`](CellNavigation.md#navigatedown)

***

### navigateLeft()

> **navigateLeft**(): `boolean`

Defined in: [src/core/cellnavigation.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L6)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateLeft`](CellNavigation.md#navigateleft)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/core/cellnavigation.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L7)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateNext`](CellNavigation.md#navigatenext)

***

### navigatePageDown()

> **navigatePageDown**(): `void`

Defined in: [src/core/cellnavigation.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L8)

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePageDown`](CellNavigation.md#navigatepagedown)

***

### navigatePageUp()

> **navigatePageUp**(): `void`

Defined in: [src/core/cellnavigation.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L9)

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePageUp`](CellNavigation.md#navigatepageup)

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/core/cellnavigation.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L10)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePrev`](CellNavigation.md#navigateprev)

***

### navigateRight()

> **navigateRight**(): `boolean`

Defined in: [src/core/cellnavigation.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L11)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRight`](CellNavigation.md#navigateright)

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

Defined in: [src/core/cellnavigation.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L12)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRowEnd`](CellNavigation.md#navigaterowend)

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

Defined in: [src/core/cellnavigation.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L13)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRowStart`](CellNavigation.md#navigaterowstart)

***

### navigateTop()

> **navigateTop**(): `void`

Defined in: [src/core/cellnavigation.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L14)

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateTop`](CellNavigation.md#navigatetop)

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

Defined in: [src/core/cellnavigation.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L15)

#### Parameters

##### row

`number`

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateToRow`](CellNavigation.md#navigatetorow)

***

### navigateUp()

> **navigateUp**(): `boolean`

Defined in: [src/core/cellnavigation.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L16)

#### Returns

`boolean`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateUp`](CellNavigation.md#navigateup)

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L16)

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`registerPlugin`](GridPluginHost.md#registerplugin)

***

### removeCellCssStyles()

> **removeCellCssStyles**(`key`): `void`

Defined in: [src/core/isleekgrid.ts:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L128)

#### Parameters

##### key

`string`

#### Returns

`void`

***

### reorderColumns()

> **reorderColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/core/isleekgrid.ts:136](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L136)

Reorders columns based on their IDs and notifies onColumnsReordered by default.

#### Parameters

##### columnIds

`string`[]

##### opt?

Whether to notify onColumnsReordered (default true). If setVisible is provided, it will also set visibility based on that.
This function is used by column picker and other plugins to reorder columns and set visibility in one shot.

###### notify?

`boolean`

###### setVisible?

`string`[]

#### Returns

`void`

***

### resetActiveCell()

> **resetActiveCell**(): `void`

Defined in: [src/core/isleekgrid.ts:137](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L137)

#### Returns

`void`

***

### scrollActiveCellIntoView()

> **scrollActiveCellIntoView**(): `void`

Defined in: [src/core/isleekgrid.ts:139](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L139)

#### Returns

`void`

***

### scrollCellIntoView()

> **scrollCellIntoView**(`row`, `cell`, `doPaging?`): `void`

Defined in: [src/core/isleekgrid.ts:140](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L140)

#### Parameters

##### row

`number`

##### cell

`number`

##### doPaging?

`boolean`

#### Returns

`void`

***

### scrollColumnIntoView()

> **scrollColumnIntoView**(`cell`): `void`

Defined in: [src/core/isleekgrid.ts:141](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L141)

#### Parameters

##### cell

`number`

#### Returns

`void`

***

### scrollRowIntoView()

> **scrollRowIntoView**(`row`, `doPaging?`): `void`

Defined in: [src/core/isleekgrid.ts:142](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L142)

#### Parameters

##### row

`number`

##### doPaging?

`boolean`

#### Returns

`void`

***

### scrollRowToTop()

> **scrollRowToTop**(`row`): `void`

Defined in: [src/core/isleekgrid.ts:143](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L143)

#### Parameters

##### row

`number`

#### Returns

`void`

***

### setActiveCell()

> **setActiveCell**(`row`, `cell`): `void`

Defined in: [src/core/isleekgrid.ts:144](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L144)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

***

### setActiveRow()

> **setActiveRow**(`row`, `cell`, `suppressScrollIntoView?`): `void`

Defined in: [src/core/isleekgrid.ts:145](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L145)

#### Parameters

##### row

`number`

##### cell

`number`

##### suppressScrollIntoView?

`boolean`

#### Returns

`void`

***

### setCellCssStyles()

> **setCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/core/isleekgrid.ts:146](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L146)

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

***

### setColumnHeaderVisibility()

> **setColumnHeaderVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:147](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L147)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setColumns()

> **setColumns**(`columns`): `void`

Defined in: [src/core/isleekgrid.ts:148](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L148)

#### Parameters

##### columns

[`Column`](Column.md)\<`TItem`\>[]

#### Returns

`void`

***

### setData()

> **setData**(`newData`, `scrollToTop?`): `void`

Defined in: [src/core/isleekgrid.ts:157](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L157)

#### Parameters

##### newData

`any`

##### scrollToTop?

`boolean`

#### Returns

`void`

***

### setFooterRowVisibility()

> **setFooterRowVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:158](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L158)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setGroupingPanelVisibility()

> **setGroupingPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:159](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L159)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setHeaderRowVisibility()

> **setHeaderRowVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:160](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L160)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setOptions()

> **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

Defined in: [src/core/isleekgrid.ts:161](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L161)

#### Parameters

##### args

[`GridOptions`](GridOptions.md)\<`TItem`\>

##### suppressRender?

`boolean`

##### suppressColumnSet?

`boolean`

##### suppressSetOverflow?

`boolean`

#### Returns

`void`

***

### setPreHeaderPanelVisibility()

> **setPreHeaderPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:162](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L162)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/core/isleekgrid.ts:163](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L163)

#### Parameters

##### rows

`number`[]

#### Returns

`void`

***

### setSelectionModel()

> **setSelectionModel**(`model`): `void`

Defined in: [src/core/isleekgrid.ts:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L164)

#### Parameters

##### model

[`SelectionModel`](SelectionModel.md)

#### Returns

`void`

***

### setSortColumn()

> **setSortColumn**(`columnId`, `ascending`): `void`

Defined in: [src/core/isleekgrid.ts:165](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L165)

#### Parameters

##### columnId

`string`

##### ascending

`boolean`

#### Returns

`void`

***

### setSortColumns()

> **setSortColumns**(`cols`): `void`

Defined in: [src/core/isleekgrid.ts:166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L166)

#### Parameters

##### cols

[`ColumnSort`](ColumnSort.md)[]

#### Returns

`void`

***

### setTopPanelVisibility()

> **setTopPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:167](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L167)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

***

### setVisibleColumns()

> **setVisibleColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/core/isleekgrid.ts:156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L156)

Sets the visible columns based on their IDs and reorders them to provided order
unless specified otherwise.

#### Parameters

##### columnIds

`string`[]

The IDs of the columns to be made visible.

##### opt?

Whether to reorder the visible columns based on the provided IDs (default true),
and notify onColumnsReordered (default true).

###### notify?

`boolean`

###### reorder?

`boolean`

#### Returns

`void`

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L17)

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`unregisterPlugin`](GridPluginHost.md#unregisterplugin)

***

### updateCell()

> **updateCell**(`row`, `cell`): `void`

Defined in: [src/core/isleekgrid.ts:168](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L168)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

***

### updateColumnHeader()

> **updateColumnHeader**(`columnId`, `title?`, `toolTip?`): `void`

Defined in: [src/core/isleekgrid.ts:169](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L169)

#### Parameters

##### columnId

`string`

##### title?

`string` | [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`any`\>

##### toolTip?

`string`

#### Returns

`void`

***

### updatePagingStatusFromView()

> **updatePagingStatusFromView**(`pagingInfo`): `void`

Defined in: [src/core/isleekgrid.ts:170](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L170)

#### Parameters

##### pagingInfo

###### pageNum

`number`

###### pageSize

`number`

###### totalPages

`number`

#### Returns

`void`

***

### updateRow()

> **updateRow**(`row`): `void`

Defined in: [src/core/isleekgrid.ts:171](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L171)

#### Parameters

##### row

`number`

#### Returns

`void`

***

### updateRowCount()

> **updateRowCount**(): `void`

Defined in: [src/core/isleekgrid.ts:172](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L172)

#### Returns

`void`
