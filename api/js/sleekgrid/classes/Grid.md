[@serenity-is/sleekgrid](../README.md) / Grid

# Class: Grid\<TItem\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

## Implements

- [`EditorHost`](../interfaces/EditorHost.md)

## Table of contents

### Constructors

- [constructor](Grid.md#constructor)

### Properties

- [onActiveCellChanged](Grid.md#onactivecellchanged)
- [onActiveCellPositionChanged](Grid.md#onactivecellpositionchanged)
- [onAddNewRow](Grid.md#onaddnewrow)
- [onBeforeCellEditorDestroy](Grid.md#onbeforecelleditordestroy)
- [onBeforeDestroy](Grid.md#onbeforedestroy)
- [onBeforeEditCell](Grid.md#onbeforeeditcell)
- [onBeforeFooterRowCellDestroy](Grid.md#onbeforefooterrowcelldestroy)
- [onBeforeHeaderCellDestroy](Grid.md#onbeforeheadercelldestroy)
- [onBeforeHeaderRowCellDestroy](Grid.md#onbeforeheaderrowcelldestroy)
- [onCellChange](Grid.md#oncellchange)
- [onCellCssStylesChanged](Grid.md#oncellcssstyleschanged)
- [onClick](Grid.md#onclick)
- [onColumnsReordered](Grid.md#oncolumnsreordered)
- [onColumnsResized](Grid.md#oncolumnsresized)
- [onCompositeEditorChange](Grid.md#oncompositeeditorchange)
- [onContextMenu](Grid.md#oncontextmenu)
- [onDblClick](Grid.md#ondblclick)
- [onDrag](Grid.md#ondrag)
- [onDragEnd](Grid.md#ondragend)
- [onDragInit](Grid.md#ondraginit)
- [onDragStart](Grid.md#ondragstart)
- [onFooterRowCellRendered](Grid.md#onfooterrowcellrendered)
- [onHeaderCellRendered](Grid.md#onheadercellrendered)
- [onHeaderClick](Grid.md#onheaderclick)
- [onHeaderContextMenu](Grid.md#onheadercontextmenu)
- [onHeaderMouseEnter](Grid.md#onheadermouseenter)
- [onHeaderMouseLeave](Grid.md#onheadermouseleave)
- [onHeaderRowCellRendered](Grid.md#onheaderrowcellrendered)
- [onKeyDown](Grid.md#onkeydown)
- [onMouseEnter](Grid.md#onmouseenter)
- [onMouseLeave](Grid.md#onmouseleave)
- [onScroll](Grid.md#onscroll)
- [onSelectedRowsChanged](Grid.md#onselectedrowschanged)
- [onSort](Grid.md#onsort)
- [onValidationError](Grid.md#onvalidationerror)
- [onViewportChanged](Grid.md#onviewportchanged)

### Methods

- [addCellCssStyles](Grid.md#addcellcssstyles)
- [autosizeColumns](Grid.md#autosizecolumns)
- [canCellBeActive](Grid.md#cancellbeactive)
- [canCellBeSelected](Grid.md#cancellbeselected)
- [clearTextSelection](Grid.md#cleartextselection)
- [columnsResized](Grid.md#columnsresized)
- [commitCurrentEdit](Grid.md#commitcurrentedit)
- [destroy](Grid.md#destroy)
- [editActiveCell](Grid.md#editactivecell)
- [flashCell](Grid.md#flashcell)
- [focus](Grid.md#focus)
- [getAbsoluteColumnMinWidth](Grid.md#getabsolutecolumnminwidth)
- [getActiveCanvasNode](Grid.md#getactivecanvasnode)
- [getActiveCell](Grid.md#getactivecell)
- [getActiveCellNode](Grid.md#getactivecellnode)
- [getActiveViewportNode](Grid.md#getactiveviewportnode)
- [getCanvasNode](Grid.md#getcanvasnode)
- [getCanvases](Grid.md#getcanvases)
- [getCellCssStyles](Grid.md#getcellcssstyles)
- [getCellEditor](Grid.md#getcelleditor)
- [getCellFromEvent](Grid.md#getcellfromevent)
- [getCellFromNode](Grid.md#getcellfromnode)
- [getCellFromPoint](Grid.md#getcellfrompoint)
- [getCellNode](Grid.md#getcellnode)
- [getCellNodeBox](Grid.md#getcellnodebox)
- [getColspan](Grid.md#getcolspan)
- [getColumnById](Grid.md#getcolumnbyid)
- [getColumnFromNode](Grid.md#getcolumnfromnode)
- [getColumnIndex](Grid.md#getcolumnindex)
- [getColumns](Grid.md#getcolumns)
- [getContainerNode](Grid.md#getcontainernode)
- [getData](Grid.md#getdata)
- [getDataItem](Grid.md#getdataitem)
- [getDataItemValueForColumn](Grid.md#getdataitemvalueforcolumn)
- [getDataLength](Grid.md#getdatalength)
- [getDisplayedScrollbarDimensions](Grid.md#getdisplayedscrollbardimensions)
- [getEditController](Grid.md#geteditcontroller)
- [getEditorLock](Grid.md#geteditorlock)
- [getFooterRow](Grid.md#getfooterrow)
- [getFooterRowColumn](Grid.md#getfooterrowcolumn)
- [getFormatter](Grid.md#getformatter)
- [getFormatterContext](Grid.md#getformattercontext)
- [getGridPosition](Grid.md#getgridposition)
- [getGroupingPanel](Grid.md#getgroupingpanel)
- [getHeader](Grid.md#getheader)
- [getHeaderColumn](Grid.md#getheadercolumn)
- [getHeaderRow](Grid.md#getheaderrow)
- [getHeaderRowColumn](Grid.md#getheaderrowcolumn)
- [getInitialColumnIndex](Grid.md#getinitialcolumnindex)
- [getInitialColumns](Grid.md#getinitialcolumns)
- [getOptions](Grid.md#getoptions)
- [getPluginByName](Grid.md#getpluginbyname)
- [getPreHeaderPanel](Grid.md#getpreheaderpanel)
- [getRenderedRange](Grid.md#getrenderedrange)
- [getRowFromNode](Grid.md#getrowfromnode)
- [getScrollBarDimensions](Grid.md#getscrollbardimensions)
- [getSelectedRows](Grid.md#getselectedrows)
- [getSelectionModel](Grid.md#getselectionmodel)
- [getSortColumns](Grid.md#getsortcolumns)
- [getTopPanel](Grid.md#gettoppanel)
- [getUID](Grid.md#getuid)
- [getViewport](Grid.md#getviewport)
- [getViewportNode](Grid.md#getviewportnode)
- [getVisibleColumnById](Grid.md#getvisiblecolumnbyid)
- [getVisibleRange](Grid.md#getvisiblerange)
- [gotoCell](Grid.md#gotocell)
- [groupTotalsFormatter](Grid.md#grouptotalsformatter)
- [init](Grid.md#init)
- [invalidate](Grid.md#invalidate)
- [invalidateAllRows](Grid.md#invalidateallrows)
- [invalidateRow](Grid.md#invalidaterow)
- [invalidateRows](Grid.md#invalidaterows)
- [navigate](Grid.md#navigate)
- [navigateBottom](Grid.md#navigatebottom)
- [navigateDown](Grid.md#navigatedown)
- [navigateLeft](Grid.md#navigateleft)
- [navigateNext](Grid.md#navigatenext)
- [navigatePageDown](Grid.md#navigatepagedown)
- [navigatePageUp](Grid.md#navigatepageup)
- [navigatePrev](Grid.md#navigateprev)
- [navigateRight](Grid.md#navigateright)
- [navigateRowEnd](Grid.md#navigaterowend)
- [navigateRowStart](Grid.md#navigaterowstart)
- [navigateToRow](Grid.md#navigatetorow)
- [navigateTop](Grid.md#navigatetop)
- [navigateUp](Grid.md#navigateup)
- [registerPlugin](Grid.md#registerplugin)
- [removeCellCssStyles](Grid.md#removecellcssstyles)
- [render](Grid.md#render)
- [resetActiveCell](Grid.md#resetactivecell)
- [resizeCanvas](Grid.md#resizecanvas)
- [scrollActiveCellIntoView](Grid.md#scrollactivecellintoview)
- [scrollCellIntoView](Grid.md#scrollcellintoview)
- [scrollColumnIntoView](Grid.md#scrollcolumnintoview)
- [scrollRowIntoView](Grid.md#scrollrowintoview)
- [scrollRowToTop](Grid.md#scrollrowtotop)
- [setActiveCell](Grid.md#setactivecell)
- [setActiveRow](Grid.md#setactiverow)
- [setCellCssStyles](Grid.md#setcellcssstyles)
- [setColumnHeaderVisibility](Grid.md#setcolumnheadervisibility)
- [setColumns](Grid.md#setcolumns)
- [setData](Grid.md#setdata)
- [setFooterRowVisibility](Grid.md#setfooterrowvisibility)
- [setGroupingPanelVisibility](Grid.md#setgroupingpanelvisibility)
- [setHeaderRowVisibility](Grid.md#setheaderrowvisibility)
- [setOptions](Grid.md#setoptions)
- [setPreHeaderPanelVisibility](Grid.md#setpreheaderpanelvisibility)
- [setSelectedRows](Grid.md#setselectedrows)
- [setSelectionModel](Grid.md#setselectionmodel)
- [setSortColumn](Grid.md#setsortcolumn)
- [setSortColumns](Grid.md#setsortcolumns)
- [setTopPanelVisibility](Grid.md#settoppanelvisibility)
- [unregisterPlugin](Grid.md#unregisterplugin)
- [updateCell](Grid.md#updatecell)
- [updateColumnHeader](Grid.md#updatecolumnheader)
- [updatePagingStatusFromView](Grid.md#updatepagingstatusfromview)
- [updateRow](Grid.md#updaterow)

## Constructors

### constructor

• **new Grid**\<`TItem`\>(`container`, `data`, `columns`, `options`): [`Grid`](Grid.md)\<`TItem`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `data` | `any` |
| `columns` | [`Column`](../interfaces/Column.md)\<`TItem`\>[] |
| `options` | [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\> |

#### Returns

[`Grid`](Grid.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:124](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L124)

## Properties

### onActiveCellChanged

• `Readonly` **onActiveCellChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L87)

___

### onActiveCellPositionChanged

• `Readonly` **onActiveCellPositionChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:88](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L88)

___

### onAddNewRow

• `Readonly` **onAddNewRow**: [`EventEmitter`](EventEmitter.md)\<[`ArgsAddNewRow`](../interfaces/ArgsAddNewRow.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:89](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L89)

___

### onBeforeCellEditorDestroy

• `Readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsEditorDestroy`](../interfaces/ArgsEditorDestroy.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:90](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L90)

___

### onBeforeDestroy

• `Readonly` **onBeforeDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:91](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L91)

___

### onBeforeEditCell

• `Readonly` **onBeforeEditCell**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellEdit`](../interfaces/ArgsCellEdit.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:92](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L92)

___

### onBeforeFooterRowCellDestroy

• `Readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:93](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L93)

___

### onBeforeHeaderCellDestroy

• `Readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:94](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L94)

___

### onBeforeHeaderRowCellDestroy

• `Readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:95](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L95)

___

### onCellChange

• `Readonly` **onCellChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellChange`](../interfaces/ArgsCellChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:96](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L96)

___

### onCellCssStylesChanged

• `Readonly` **onCellCssStylesChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCssStyle`](../interfaces/ArgsCssStyle.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:97](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L97)

___

### onClick

• `Readonly` **onClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:98](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L98)

___

### onColumnsReordered

• `Readonly` **onColumnsReordered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:99](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L99)

___

### onColumnsResized

• `Readonly` **onColumnsResized**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:100](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L100)

___

### onCompositeEditorChange

• `Readonly` **onCompositeEditorChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[onCompositeEditorChange](../interfaces/EditorHost.md#oncompositeeditorchange)

#### Defined in

[grid/grid.ts:101](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L101)

___

### onContextMenu

• `Readonly` **onContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:102](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L102)

___

### onDblClick

• `Readonly` **onDblClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:103](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L103)

___

### onDrag

• `Readonly` **onDrag**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L104)

___

### onDragEnd

• `Readonly` **onDragEnd**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:105](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L105)

___

### onDragInit

• `Readonly` **onDragInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:106](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L106)

___

### onDragStart

• `Readonly` **onDragStart**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:107](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L107)

___

### onFooterRowCellRendered

• `Readonly` **onFooterRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:108](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L108)

___

### onHeaderCellRendered

• `Readonly` **onHeaderCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:109](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L109)

___

### onHeaderClick

• `Readonly` **onHeaderClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:110](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L110)

___

### onHeaderContextMenu

• `Readonly` **onHeaderContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:111](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L111)

___

### onHeaderMouseEnter

• `Readonly` **onHeaderMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:112](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L112)

___

### onHeaderMouseLeave

• `Readonly` **onHeaderMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:113](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L113)

___

### onHeaderRowCellRendered

• `Readonly` **onHeaderRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:114](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L114)

___

### onKeyDown

• `Readonly` **onKeyDown**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `KeyboardEvent`\>

#### Defined in

[grid/grid.ts:115](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L115)

___

### onMouseEnter

• `Readonly` **onMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:116](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L116)

___

### onMouseLeave

• `Readonly` **onMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:117](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L117)

___

### onScroll

• `Readonly` **onScroll**: [`EventEmitter`](EventEmitter.md)\<[`ArgsScroll`](../interfaces/ArgsScroll.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:118](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L118)

___

### onSelectedRowsChanged

• `Readonly` **onSelectedRowsChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSelectedRowsChange`](../interfaces/ArgsSelectedRowsChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:119](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L119)

___

### onSort

• `Readonly` **onSort**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSort`](../interfaces/ArgsSort.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:120](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L120)

___

### onValidationError

• `Readonly` **onValidationError**: [`EventEmitter`](EventEmitter.md)\<[`ArgsValidationError`](../interfaces/ArgsValidationError.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:121](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L121)

___

### onViewportChanged

• `Readonly` **onViewportChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:122](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L122)

## Methods

### addCellCssStyles

▸ **addCellCssStyles**(`key`, `hash`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `hash` | [`CellStylesHash`](../README.md#cellstyleshash) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2840](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2840)

___

### autosizeColumns

▸ **autosizeColumns**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1252](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1252)

___

### canCellBeActive

▸ **canCellBeActive**(`row`, `cell`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3796](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3796)

___

### canCellBeSelected

▸ **canCellBeSelected**(`row`, `cell`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`any`

#### Defined in

[grid/grid.ts:3819](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3819)

___

### clearTextSelection

▸ **clearTextSelection**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3350](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3350)

___

### columnsResized

▸ **columnsResized**(`invalidate?`): `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `invalidate` | `boolean` | `true` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1037](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1037)

___

### commitCurrentEdit

▸ **commitCurrentEdit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3864](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3864)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1174](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1174)

___

### editActiveCell

▸ **editActiveCell**(`editor?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor?` | [`EditorClass`](../interfaces/EditorClass.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3407](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3407)

___

### flashCell

▸ **flashCell**(`row`, `cell`, `speed?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |
| `speed?` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2875](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2875)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3244](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3244)

___

### getAbsoluteColumnMinWidth

▸ **getAbsoluteColumnMinWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:452](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L452)

___

### getActiveCanvasNode

▸ **getActiveCanvasNode**(`e?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e?` | [`IEventData`](../interfaces/IEventData.md) |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:479](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L479)

___

### getActiveCell

▸ **getActiveCell**(): [`RowCell`](../interfaces/RowCell.md)

#### Returns

[`RowCell`](../interfaces/RowCell.md)

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[getActiveCell](../interfaces/EditorHost.md#getactivecell)

#### Defined in

[grid/grid.ts:3528](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3528)

___

### getActiveCellNode

▸ **getActiveCellNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:3536](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3536)

___

### getActiveViewportNode

▸ **getActiveViewportNode**(`e?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e?` | [`IEventData`](../interfaces/IEventData.md) |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:494](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L494)

___

### getCanvasNode

▸ **getCanvasNode**(`columnIdOrIdx?`, `row?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx?` | `string` \| `number` |
| `row?` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:470](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L470)

___

### getCanvases

▸ **getCanvases**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:474](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L474)

___

### getCellCssStyles

▸ **getCellCssStyles**(`key`): [`CellStylesHash`](../README.md#cellstyleshash)

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

[`CellStylesHash`](../README.md#cellstyleshash)

#### Defined in

[grid/grid.ts:2871](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2871)

___

### getCellEditor

▸ **getCellEditor**(): [`Editor`](../interfaces/Editor.md)

#### Returns

[`Editor`](../interfaces/Editor.md)

#### Defined in

[grid/grid.ts:3524](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3524)

___

### getCellFromEvent

▸ **getCellFromEvent**(`e`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `cell` | `number` |
| `row` | `number` |

#### Defined in

[grid/grid.ts:3186](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3186)

___

### getCellFromNode

▸ **getCellFromNode**(`cellNode`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `Element` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:3148](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3148)

___

### getCellFromPoint

▸ **getCellFromPoint**(`x`, `y`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `cell` | `number` |
| `row` | `number` |

#### Defined in

[grid/grid.ts:3131](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3131)

___

### getCellNode

▸ **getCellNode**(`row`, `cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:3761](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3761)

___

### getCellNodeBox

▸ **getCellNodeBox**(`row`, `cell`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `bottom` | `number` |
| `left` | `number` |
| `right` | `number` |
| `top` | `number` |

#### Defined in

[grid/grid.ts:3206](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3206)

___

### getColspan

▸ **getColspan**(`row`, `cell`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:3660](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3660)

___

### getColumnById

▸ **getColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Gets a column by its ID. May also return non visible columns

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1233](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1233)

___

### getColumnFromNode

▸ **getColumnFromNode**(`cellNode`): [`Column`](../interfaces/Column.md)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `Element` |

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:3164](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3164)

___

### getColumnIndex

▸ **getColumnIndex**(`id`): `number`

Returns a column's index in the visible columns list by its column ID

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1238](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1238)

___

### getColumns

▸ **getColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Returns only the visible columns in order

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Defined in

[grid/grid.ts:1370](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1370)

___

### getContainerNode

▸ **getContainerNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1664](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1664)

___

### getData

▸ **getData**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:1555](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1555)

___

### getDataItem

▸ **getDataItem**(`i`): `TItem`

#### Parameters

| Name | Type |
| :------ | :------ |
| `i` | `number` |

#### Returns

`TItem`

#### Defined in

[grid/grid.ts:1572](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1572)

___

### getDataItemValueForColumn

▸ **getDataItemValueForColumn**(`item`, `columnDef`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `columnDef` | [`Column`](../interfaces/Column.md)\<`TItem`\> |

#### Returns

`any`

#### Defined in

[grid/grid.ts:1797](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1797)

___

### getDataLength

▸ **getDataLength**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1559](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1559)

___

### getDisplayedScrollbarDimensions

▸ **getDisplayedScrollbarDimensions**(): `Object`

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `height` | `number` |
| `width` | `number` |

#### Defined in

[grid/grid.ts:445](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L445)

___

### getEditController

▸ **getEditController**(): [`EditController`](../interfaces/EditController.md)

#### Returns

[`EditController`](../interfaces/EditController.md)

#### Defined in

[grid/grid.ts:1228](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1228)

___

### getEditorLock

▸ **getEditorLock**(): [`EditorLock`](EditorLock.md)

#### Returns

[`EditorLock`](EditorLock.md)

#### Defined in

[grid/grid.ts:1224](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1224)

___

### getFooterRow

▸ **getFooterRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:598](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L598)

___

### getFooterRowColumn

▸ **getFooterRowColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx` | `string` \| `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:602](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L602)

___

### getFormatter

▸ **getFormatter**(`row`, `column`): [`ColumnFormat`](../README.md#columnformat)\<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `column` | [`Column`](../interfaces/Column.md)\<`TItem`\> |

#### Returns

[`ColumnFormat`](../README.md#columnformat)\<`TItem`\>

#### Defined in

[grid/grid.ts:1712](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1712)

___

### getFormatterContext

▸ **getFormatterContext**(`row`, `cell`): [`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

[`FormatterContext`](../interfaces/FormatterContext.md)\<`any`\>

#### Defined in

[grid/grid.ts:1766](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1766)

___

### getGridPosition

▸ **getGridPosition**(): [`Position`](../interfaces/Position.md)

#### Returns

[`Position`](../interfaces/Position.md)

#### Defined in

[grid/grid.ts:3497](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3497)

___

### getGroupingPanel

▸ **getGroupingPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:578](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L578)

___

### getHeader

▸ **getHeader**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:566](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L566)

___

### getHeaderColumn

▸ **getHeaderColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx` | `string` \| `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:570](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L570)

___

### getHeaderRow

▸ **getHeaderRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:586](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L586)

___

### getHeaderRowColumn

▸ **getHeaderRowColumn**(`columnIdOrIdx`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx` | `string` \| `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:590](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L590)

___

### getInitialColumnIndex

▸ **getInitialColumnIndex**(`id`): `number`

Gets index of a column in the initial column list passed to the grid, or setColumns method. May include invisible cols and index does not have to match visible column order.

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1243](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1243)

___

### getInitialColumns

▸ **getInitialColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Returns list of columns passed to the grid constructor, or setColumns method. May include invisible columns and order does not match visible column order.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Defined in

[grid/grid.ts:1375](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1375)

___

### getOptions

▸ **getOptions**(): [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Returns

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1465](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1465)

___

### getPluginByName

▸ **getPluginByName**(`name`): [`IPlugin`](../interfaces/IPlugin.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |

#### Returns

[`IPlugin`](../interfaces/IPlugin.md)

#### Defined in

[grid/grid.ts:416](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L416)

___

### getPreHeaderPanel

▸ **getPreHeaderPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:582](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L582)

___

### getRenderedRange

▸ **getRenderedRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `viewportTop?` | `number` |
| `viewportLeft?` | `number` |

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Defined in

[grid/grid.ts:2271](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2271)

___

### getRowFromNode

▸ **getRowFromNode**(`rowNode`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rowNode` | `Element` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:3175](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3175)

___

### getScrollBarDimensions

▸ **getScrollBarDimensions**(): `Object`

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `height` | `number` |
| `width` | `number` |

#### Defined in

[grid/grid.ts:441](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L441)

___

### getSelectedRows

▸ **getSelectedRows**(): `number`[]

#### Returns

`number`[]

#### Defined in

[grid/grid.ts:3957](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3957)

___

### getSelectionModel

▸ **getSelectionModel**(): [`SelectionModel`](../interfaces/SelectionModel.md)

#### Returns

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Defined in

[grid/grid.ts:456](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L456)

___

### getSortColumns

▸ **getSortColumns**(): [`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Returns

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Defined in

[grid/grid.ts:1314](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1314)

___

### getTopPanel

▸ **getTopPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1580](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1580)

___

### getUID

▸ **getUID**(): `string`

#### Returns

`string`

#### Defined in

[grid/grid.ts:1668](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1668)

___

### getViewport

▸ **getViewport**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `viewportTop?` | `number` | optional viewport top |
| `viewportLeft?` | `number` | optional viewport left |

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

viewport range

#### Defined in

[grid/grid.ts:2249](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2249)

___

### getViewportNode

▸ **getViewportNode**(`columnIdOrIdx?`, `row?`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx?` | `string` \| `number` |
| `row?` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:486](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L486)

___

### getVisibleColumnById

▸ **getVisibleColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Gets a view (e.g. visible) column by its column ID

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Defined in

[grid/grid.ts:1248](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1248)

___

### getVisibleRange

▸ **getVisibleRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `viewportTop?` | `number` |
| `viewportLeft?` | `number` |

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Defined in

[grid/grid.ts:2253](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2253)

___

### gotoCell

▸ **gotoCell**(`row`, `cell`, `forceEdit?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |
| `forceEdit?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3838](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3838)

___

### groupTotalsFormatter

▸ **groupTotalsFormatter**(`p1?`, `p2?`, `grid?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `p1?` | [`GroupTotals`](GroupTotals.md)\<`TItem`\> |
| `p2?` | [`Column`](../interfaces/Column.md)\<`TItem`\> |
| `grid?` | `any` |

#### Returns

`string`

#### Defined in

[grid/grid.ts:2612](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2612)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:262](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L262)

___

### invalidate

▸ **invalidate**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1961](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1961)

___

### invalidateAllRows

▸ **invalidateAllRows**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1968](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1968)

___

### invalidateRow

▸ **invalidateRow**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2054](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2054)

___

### invalidateRows

▸ **invalidateRows**(`rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rows` | `number`[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2036](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2036)

___

### navigate

▸ **navigate**(`dir`): `boolean`

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `dir` | `string` | Navigation direction. |

#### Returns

`boolean`

Whether navigation resulted in a change of active cell.

#### Defined in

[grid/grid.ts:3714](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3714)

___

### navigateBottom

▸ **navigateBottom**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3623](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3623)

___

### navigateDown

▸ **navigateDown**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3686](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3686)

___

### navigateLeft

▸ **navigateLeft**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3682](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3682)

___

### navigateNext

▸ **navigateNext**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[navigateNext](../interfaces/EditorHost.md#navigatenext)

#### Defined in

[grid/grid.ts:3694](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3694)

___

### navigatePageDown

▸ **navigatePageDown**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3611](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3611)

___

### navigatePageUp

▸ **navigatePageUp**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3615](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3615)

___

### navigatePrev

▸ **navigatePrev**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[navigatePrev](../interfaces/EditorHost.md#navigateprev)

#### Defined in

[grid/grid.ts:3698](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3698)

___

### navigateRight

▸ **navigateRight**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3678](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3678)

___

### navigateRowEnd

▸ **navigateRowEnd**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3706](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3706)

___

### navigateRowStart

▸ **navigateRowStart**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3702](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3702)

___

### navigateToRow

▸ **navigateToRow**(`row`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3627](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3627)

___

### navigateTop

▸ **navigateTop**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3619](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3619)

___

### navigateUp

▸ **navigateUp**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3690](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3690)

___

### registerPlugin

▸ **registerPlugin**(`plugin`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `plugin` | [`IPlugin`](../interfaces/IPlugin.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:399](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L399)

___

### removeCellCssStyles

▸ **removeCellCssStyles**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2851](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2851)

___

### render

▸ **render**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2616](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2616)

___

### resetActiveCell

▸ **resetActiveCell**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3240](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3240)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2133](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2133)

___

### scrollActiveCellIntoView

▸ **scrollActiveCellIntoView**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3540](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3540)

___

### scrollCellIntoView

▸ **scrollCellIntoView**(`row`, `cell`, `doPaging?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |
| `doPaging?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3256](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3256)

___

### scrollColumnIntoView

▸ **scrollColumnIntoView**(`cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3266](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3266)

___

### scrollRowIntoView

▸ **scrollRowIntoView**(`row`, `doPaging?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `doPaging?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3546](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3546)

___

### scrollRowToTop

▸ **scrollRowToTop**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3573](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3573)

___

### setActiveCell

▸ **setActiveCell**(`row`, `cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3769](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3769)

___

### setActiveRow

▸ **setActiveRow**(`row`, `cell`, `suppressScrollIntoView?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |
| `suppressScrollIntoView?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3784](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3784)

___

### setCellCssStyles

▸ **setCellCssStyles**(`key`, `hash`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `hash` | [`CellStylesHash`](../README.md#cellstyleshash) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2862](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2862)

___

### setColumnHeaderVisibility

▸ **setColumnHeaderVisibility**(`visible`, `animate?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |
| `animate?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1599](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1599)

___

### setColumns

▸ **setColumns**(`columns`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columns` | [`Column`](../interfaces/Column.md)\<`TItem`\>[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1427](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1427)

___

### setData

▸ **setData**(`newData`, `scrollToTop?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newData` | `any` |
| `scrollToTop?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1544](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1544)

___

### setFooterRowVisibility

▸ **setFooterRowVisibility**(`visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1614](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1614)

___

### setGroupingPanelVisibility

▸ **setGroupingPanelVisibility**(`visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1629](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1629)

___

### setHeaderRowVisibility

▸ **setHeaderRowVisibility**(`visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1649](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1649)

___

### setOptions

▸ **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\> |
| `suppressRender?` | `boolean` |
| `suppressColumnSet?` | `boolean` |
| `suppressSetOverflow?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1469](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1469)

___

### setPreHeaderPanelVisibility

▸ **setPreHeaderPanelVisibility**(`visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1645](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1645)

___

### setSelectedRows

▸ **setSelectedRows**(`rows`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rows` | `number`[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3964](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L3964)

___

### setSelectionModel

▸ **setSelectionModel**(`model`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `model` | [`SelectionModel`](../interfaces/SelectionModel.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:423](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L423)

___

### setSortColumn

▸ **setSortColumn**(`columnId`, `ascending`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnId` | `string` |
| `ascending` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1283](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1283)

___

### setSortColumns

▸ **setSortColumns**(`cols`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cols` | [`ColumnSort`](../interfaces/ColumnSort.md)[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1287](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1287)

___

### setTopPanelVisibility

▸ **setTopPanelVisibility**(`visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1584](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L1584)

___

### unregisterPlugin

▸ **unregisterPlugin**(`plugin`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `plugin` | [`IPlugin`](../interfaces/IPlugin.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:404](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L404)

___

### updateCell

▸ **updateCell**(`row`, `cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2058](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2058)

___

### updateColumnHeader

▸ **updateColumnHeader**(`columnId`, `title?`, `toolTip?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnId` | `string` |
| `title?` | `string` |
| `toolTip?` | `string` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:522](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L522)

___

### updatePagingStatusFromView

▸ **updatePagingStatusFromView**(`pagingInfo`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `pagingInfo` | `Object` |
| `pagingInfo.pageNum` | `number` |
| `pagingInfo.pageSize` | `number` |
| `pagingInfo.totalPages` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2156](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2156)

___

### updateRow

▸ **updateRow**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2080](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#L2080)
