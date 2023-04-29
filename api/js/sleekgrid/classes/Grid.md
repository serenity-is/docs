[@serenity-is/sleekgrid](../README.md) / Grid

# Class: Grid<TItem\>

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

- [\_absoluteColMinWidth](Grid.md#_absolutecolminwidth)
- [\_activeCanvasNode](Grid.md#_activecanvasnode)
- [\_activeCell](Grid.md#_activecell)
- [\_activeCellNode](Grid.md#_activecellnode)
- [\_activePosX](Grid.md#_activeposx)
- [\_activeRow](Grid.md#_activerow)
- [\_activeViewportNode](Grid.md#_activeviewportnode)
- [\_boundAncestorScroll](Grid.md#_boundancestorscroll)
- [\_cellCssClasses](Grid.md#_cellcssclasses)
- [\_cellHeightDiff](Grid.md#_cellheightdiff)
- [\_cellNavigator](Grid.md#_cellnavigator)
- [\_cellWidthDiff](Grid.md#_cellwidthdiff)
- [\_colById](Grid.md#_colbyid)
- [\_colDefaults](Grid.md#_coldefaults)
- [\_colLeft](Grid.md#_colleft)
- [\_colRight](Grid.md#_colright)
- [\_cols](Grid.md#_cols)
- [\_columnCssRulesL](Grid.md#_columncssrulesl)
- [\_columnCssRulesR](Grid.md#_columncssrulesr)
- [\_container](Grid.md#_container)
- [\_currentEditor](Grid.md#_currenteditor)
- [\_data](Grid.md#_data)
- [\_editController](Grid.md#_editcontroller)
- [\_focusSink1](Grid.md#_focussink1)
- [\_focusSink2](Grid.md#_focussink2)
- [\_groupingPanel](Grid.md#_groupingpanel)
- [\_hEditorLoader](Grid.md#_heditorloader)
- [\_hPostRender](Grid.md#_hpostrender)
- [\_hPostRenderCleanup](Grid.md#_hpostrendercleanup)
- [\_hRender](Grid.md#_hrender)
- [\_headerColumnWidthDiff](Grid.md#_headercolumnwidthdiff)
- [\_ignoreScrollUntil](Grid.md#_ignorescrolluntil)
- [\_initColById](Grid.md#_initcolbyid)
- [\_initCols](Grid.md#_initcols)
- [\_initialized](Grid.md#_initialized)
- [\_jQuery](Grid.md#_jquery)
- [\_jumpinessCoefficient](Grid.md#_jumpinesscoefficient)
- [\_lastRenderTime](Grid.md#_lastrendertime)
- [\_layout](Grid.md#_layout)
- [\_numberOfPages](Grid.md#_numberofpages)
- [\_options](Grid.md#_options)
- [\_page](Grid.md#_page)
- [\_pageHeight](Grid.md#_pageheight)
- [\_pageOffset](Grid.md#_pageoffset)
- [\_pagingActive](Grid.md#_pagingactive)
- [\_pagingIsLastPage](Grid.md#_pagingislastpage)
- [\_plugins](Grid.md#_plugins)
- [\_postProcessCleanupQueue](Grid.md#_postprocesscleanupqueue)
- [\_postProcessFromRow](Grid.md#_postprocessfromrow)
- [\_postProcessGroupId](Grid.md#_postprocessgroupid)
- [\_postProcessToRow](Grid.md#_postprocesstorow)
- [\_postProcessedRows](Grid.md#_postprocessedrows)
- [\_rowsCache](Grid.md#_rowscache)
- [\_scrollDims](Grid.md#_scrolldims)
- [\_scrollLeft](Grid.md#_scrollleft)
- [\_scrollLeftPrev](Grid.md#_scrollleftprev)
- [\_scrollLeftRendered](Grid.md#_scrollleftrendered)
- [\_scrollTop](Grid.md#_scrolltop)
- [\_scrollTopPrev](Grid.md#_scrolltopprev)
- [\_scrollTopRendered](Grid.md#_scrolltoprendered)
- [\_selectedRows](Grid.md#_selectedrows)
- [\_selectionModel](Grid.md#_selectionmodel)
- [\_serializedEditorValue](Grid.md#_serializededitorvalue)
- [\_sortColumns](Grid.md#_sortcolumns)
- [\_styleNode](Grid.md#_stylenode)
- [\_stylesheet](Grid.md#_stylesheet)
- [\_tabbingDirection](Grid.md#_tabbingdirection)
- [\_uid](Grid.md#_uid)
- [\_vScrollDir](Grid.md#_vscrolldir)
- [\_viewportInfo](Grid.md#_viewportinfo)
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
- [appendCellHtml](Grid.md#appendcellhtml)
- [appendRowHtml](Grid.md#appendrowhtml)
- [applyColumnHeaderWidths](Grid.md#applycolumnheaderwidths)
- [asyncPostProcessCleanupRows](Grid.md#asyncpostprocesscleanuprows)
- [asyncPostProcessRows](Grid.md#asyncpostprocessrows)
- [autosizeColumns](Grid.md#autosizecolumns)
- [bindAncestorScroll](Grid.md#bindancestorscroll)
- [bindToData](Grid.md#bindtodata)
- [calcViewportSize](Grid.md#calcviewportsize)
- [canCellBeActive](Grid.md#cancellbeactive)
- [canCellBeSelected](Grid.md#cancellbeselected)
- [cancelCurrentEdit](Grid.md#cancelcurrentedit)
- [cancelEditAndSetFocus](Grid.md#canceleditandsetfocus)
- [cellExists](Grid.md#cellexists)
- [cleanUpAndRenderCells](Grid.md#cleanupandrendercells)
- [cleanUpCells](Grid.md#cleanupcells)
- [cleanupRows](Grid.md#cleanuprows)
- [clearTextSelection](Grid.md#cleartextselection)
- [colIdOrIdxToCell](Grid.md#colidoridxtocell)
- [commitCurrentEdit](Grid.md#commitcurrentedit)
- [commitEditAndSetFocus](Grid.md#commiteditandsetfocus)
- [createColumnFooters](Grid.md#createcolumnfooters)
- [createColumnHeaders](Grid.md#createcolumnheaders)
- [createCssRules](Grid.md#createcssrules)
- [createGroupingPanel](Grid.md#creategroupingpanel)
- [destroy](Grid.md#destroy)
- [editActiveCell](Grid.md#editactivecell)
- [ensureCellNodesInRowsCache](Grid.md#ensurecellnodesinrowscache)
- [flashCell](Grid.md#flashcell)
- [focus](Grid.md#focus)
- [getAbsoluteColumnMinWidth](Grid.md#getabsolutecolumnminwidth)
- [getActiveCanvasNode](Grid.md#getactivecanvasnode)
- [getActiveCell](Grid.md#getactivecell)
- [getActiveCellNode](Grid.md#getactivecellnode)
- [getActiveCellPosition](Grid.md#getactivecellposition)
- [getActiveViewportNode](Grid.md#getactiveviewportnode)
- [getAvailableWidth](Grid.md#getavailablewidth)
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
- [getColumnCssRules](Grid.md#getcolumncssrules)
- [getColumnFromNode](Grid.md#getcolumnfromnode)
- [getColumnIndex](Grid.md#getcolumnindex)
- [getColumns](Grid.md#getcolumns)
- [getContainerNode](Grid.md#getcontainernode)
- [getData](Grid.md#getdata)
- [getDataItem](Grid.md#getdataitem)
- [getDataItemValueForColumn](Grid.md#getdataitemvalueforcolumn)
- [getDataLength](Grid.md#getdatalength)
- [getDataLengthIncludingAddNew](Grid.md#getdatalengthincludingaddnew)
- [getDisplayedScrollbarDimensions](Grid.md#getdisplayedscrollbardimensions)
- [getEditController](Grid.md#geteditcontroller)
- [getEditor](Grid.md#geteditor)
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
- [getRowFromPosition](Grid.md#getrowfromposition)
- [getRowTop](Grid.md#getrowtop)
- [getScrollBarDimensions](Grid.md#getscrollbardimensions)
- [getSelectedRows](Grid.md#getselectedrows)
- [getSelectionModel](Grid.md#getselectionmodel)
- [getSortColumns](Grid.md#getsortcolumns)
- [getTopPanel](Grid.md#gettoppanel)
- [getUID](Grid.md#getuid)
- [getViewport](Grid.md#getviewport)
- [getViewportNode](Grid.md#getviewportnode)
- [getViewports](Grid.md#getviewports)
- [getVisibleRange](Grid.md#getvisiblerange)
- [gotoCell](Grid.md#gotocell)
- [groupTotalsFormatter](Grid.md#grouptotalsformatter)
- [handleActiveCellPositionChange](Grid.md#handleactivecellpositionchange)
- [handleClick](Grid.md#handleclick)
- [handleContextMenu](Grid.md#handlecontextmenu)
- [handleDblClick](Grid.md#handledblclick)
- [handleDrag](Grid.md#handledrag)
- [handleDragEnd](Grid.md#handledragend)
- [handleDragInit](Grid.md#handledraginit)
- [handleDragStart](Grid.md#handledragstart)
- [handleFooterRowScroll](Grid.md#handlefooterrowscroll)
- [handleHeaderClick](Grid.md#handleheaderclick)
- [handleHeaderContextMenu](Grid.md#handleheadercontextmenu)
- [handleHeaderMouseEnter](Grid.md#handleheadermouseenter)
- [handleHeaderMouseLeave](Grid.md#handleheadermouseleave)
- [handleHeaderRowScroll](Grid.md#handleheaderrowscroll)
- [handleKeyDown](Grid.md#handlekeydown)
- [handleMouseEnter](Grid.md#handlemouseenter)
- [handleMouseLeave](Grid.md#handlemouseleave)
- [handleMouseWheel](Grid.md#handlemousewheel)
- [handleScroll](Grid.md#handlescroll)
- [handleSelectedRangesChanged](Grid.md#handleselectedrangeschanged)
- [hasFrozenColumns](Grid.md#hasfrozencolumns)
- [hasFrozenRows](Grid.md#hasfrozenrows)
- [init](Grid.md#init)
- [internalScrollColumnIntoView](Grid.md#internalscrollcolumnintoview)
- [invalidate](Grid.md#invalidate)
- [invalidateAllRows](Grid.md#invalidateallrows)
- [invalidatePostProcessingResults](Grid.md#invalidatepostprocessingresults)
- [invalidateRow](Grid.md#invalidaterow)
- [invalidateRows](Grid.md#invalidaterows)
- [isCellPotentiallyEditable](Grid.md#iscellpotentiallyeditable)
- [makeActiveCellEditable](Grid.md#makeactivecelleditable)
- [makeActiveCellNormal](Grid.md#makeactivecellnormal)
- [measureCellPaddingAndBorder](Grid.md#measurecellpaddingandborder)
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
- [queuePostProcessedCellForCleanup](Grid.md#queuepostprocessedcellforcleanup)
- [queuePostProcessedRowForCleanup](Grid.md#queuepostprocessedrowforcleanup)
- [registerPlugin](Grid.md#registerplugin)
- [removeCellCssStyles](Grid.md#removecellcssstyles)
- [removeCssRules](Grid.md#removecssrules)
- [removeRowFromCache](Grid.md#removerowfromcache)
- [render](Grid.md#render)
- [renderRows](Grid.md#renderrows)
- [resetActiveCell](Grid.md#resetactivecell)
- [resizeCanvas](Grid.md#resizecanvas)
- [rowsToRanges](Grid.md#rowstoranges)
- [scrollActiveCellIntoView](Grid.md#scrollactivecellintoview)
- [scrollCellIntoView](Grid.md#scrollcellintoview)
- [scrollColumnIntoView](Grid.md#scrollcolumnintoview)
- [scrollPage](Grid.md#scrollpage)
- [scrollRowIntoView](Grid.md#scrollrowintoview)
- [scrollRowToTop](Grid.md#scrollrowtotop)
- [scrollTo](Grid.md#scrollto)
- [setActiveCell](Grid.md#setactivecell)
- [setActiveCellInternal](Grid.md#setactivecellinternal)
- [setActiveRow](Grid.md#setactiverow)
- [setCellCssStyles](Grid.md#setcellcssstyles)
- [setColumnHeaderVisibility](Grid.md#setcolumnheadervisibility)
- [setColumns](Grid.md#setcolumns)
- [setData](Grid.md#setdata)
- [setFocus](Grid.md#setfocus)
- [setFooterRowVisibility](Grid.md#setfooterrowvisibility)
- [setGroupingPanelVisibility](Grid.md#setgroupingpanelvisibility)
- [setHeaderRowVisibility](Grid.md#setheaderrowvisibility)
- [setInitialCols](Grid.md#setinitialcols)
- [setOptions](Grid.md#setoptions)
- [setOverflow](Grid.md#setoverflow)
- [setPreHeaderPanelVisibility](Grid.md#setpreheaderpanelvisibility)
- [setSelectedRows](Grid.md#setselectedrows)
- [setSelectionModel](Grid.md#setselectionmodel)
- [setSortColumn](Grid.md#setsortcolumn)
- [setSortColumns](Grid.md#setsortcolumns)
- [setTopPanelVisibility](Grid.md#settoppanelvisibility)
- [setupColumnReorder](Grid.md#setupcolumnreorder)
- [setupColumnResize](Grid.md#setupcolumnresize)
- [setupColumnSort](Grid.md#setupcolumnsort)
- [startPostProcessing](Grid.md#startpostprocessing)
- [startPostProcessingCleanup](Grid.md#startpostprocessingcleanup)
- [trigger](Grid.md#trigger)
- [unbindAncestorScrollEvents](Grid.md#unbindancestorscrollevents)
- [unbindFromData](Grid.md#unbindfromdata)
- [unregisterPlugin](Grid.md#unregisterplugin)
- [unregisterSelectionModel](Grid.md#unregisterselectionmodel)
- [updateCanvasWidth](Grid.md#updatecanvaswidth)
- [updateCell](Grid.md#updatecell)
- [updateCellCssStylesOnRenderedRows](Grid.md#updatecellcssstylesonrenderedrows)
- [updateCellWithFormatter](Grid.md#updatecellwithformatter)
- [updateColumnHeader](Grid.md#updatecolumnheader)
- [updateGrandTotals](Grid.md#updategrandtotals)
- [updatePagingStatusFromView](Grid.md#updatepagingstatusfromview)
- [updateRow](Grid.md#updaterow)
- [updateRowCount](Grid.md#updaterowcount)
- [updateRowPositions](Grid.md#updaterowpositions)
- [updateViewColLeftRight](Grid.md#updateviewcolleftright)
- [validateAndEnforceOptions](Grid.md#validateandenforceoptions)
- [viewOnDataChanged](Grid.md#viewondatachanged)
- [viewOnRowCountChanged](Grid.md#viewonrowcountchanged)
- [viewOnRowsChanged](Grid.md#viewonrowschanged)

## Constructors

### constructor

• **new Grid**<`TItem`\>(`container`, `data`, `columns`, `options`)

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `any` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `HTMLElement` \| { `jquery`: `string` ; `length`: `number`  } |
| `data` | `any` |
| `columns` | [`Column`](../interfaces/Column.md)<`TItem`\>[] |
| `options` | [`GridOptions`](../interfaces/GridOptions.md)<`TItem`\> |

#### Defined in

[grid/grid.ts:121](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;121)

## Properties

### \_absoluteColMinWidth

• `Private` **\_absoluteColMinWidth**: `number`

#### Defined in

[grid/grid.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;12)

___

### \_activeCanvasNode

• `Private` **\_activeCanvasNode**: `HTMLElement`

#### Defined in

[grid/grid.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;13)

___

### \_activeCell

• `Private` **\_activeCell**: `number`

#### Defined in

[grid/grid.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;14)

___

### \_activeCellNode

• `Private` **\_activeCellNode**: `HTMLElement` = `null`

#### Defined in

[grid/grid.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;15)

___

### \_activePosX

• `Private` **\_activePosX**: `number`

#### Defined in

[grid/grid.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;16)

___

### \_activeRow

• `Private` **\_activeRow**: `number`

#### Defined in

[grid/grid.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;17)

___

### \_activeViewportNode

• `Private` **\_activeViewportNode**: `HTMLElement`

#### Defined in

[grid/grid.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;18)

___

### \_boundAncestorScroll

• `Private` **\_boundAncestorScroll**: `HTMLElement`[] = `[]`

#### Defined in

[grid/grid.ts:78](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;78)

___

### \_cellCssClasses

• `Private` **\_cellCssClasses**: `Record`<`string`, [`CellStylesHash`](../README.md#cellstyleshash)\> = `{}`

#### Defined in

[grid/grid.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;19)

___

### \_cellHeightDiff

• `Private` **\_cellHeightDiff**: `number` = `0`

#### Defined in

[grid/grid.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;20)

___

### \_cellNavigator

• `Private` **\_cellNavigator**: `CellNavigator`

#### Defined in

[grid/grid.ts:22](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;22)

___

### \_cellWidthDiff

• `Private` **\_cellWidthDiff**: `number` = `0`

#### Defined in

[grid/grid.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;21)

___

### \_colById

• `Private` **\_colById**: `Object`

#### Index signature

▪ [key: `string`]: `number`

#### Defined in

[grid/grid.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;23)

___

### \_colDefaults

• `Private` **\_colDefaults**: `Partial`<[`Column`](../interfaces/Column.md)<`any`\>\>

#### Defined in

[grid/grid.ts:24](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;24)

___

### \_colLeft

• `Private` **\_colLeft**: `number`[] = `[]`

#### Defined in

[grid/grid.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;25)

___

### \_colRight

• `Private` **\_colRight**: `number`[] = `[]`

#### Defined in

[grid/grid.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;26)

___

### \_cols

• `Private` **\_cols**: [`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Defined in

[grid/grid.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;27)

___

### \_columnCssRulesL

• `Private` **\_columnCssRulesL**: `any`

#### Defined in

[grid/grid.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;28)

___

### \_columnCssRulesR

• `Private` **\_columnCssRulesR**: `any`

#### Defined in

[grid/grid.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;29)

___

### \_container

• `Private` **\_container**: `HTMLElement`

#### Defined in

[grid/grid.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;79)

___

### \_currentEditor

• `Private` **\_currentEditor**: [`Editor`](../interfaces/Editor.md) = `null`

#### Defined in

[grid/grid.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;30)

___

### \_data

• `Private` **\_data**: `any`

#### Defined in

[grid/grid.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;31)

___

### \_editController

• `Private` **\_editController**: [`EditController`](../interfaces/EditController.md)

#### Defined in

[grid/grid.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;32)

___

### \_focusSink1

• `Private` **\_focusSink1**: `HTMLElement`

#### Defined in

[grid/grid.ts:80](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;80)

___

### \_focusSink2

• `Private` **\_focusSink2**: `HTMLElement`

#### Defined in

[grid/grid.ts:81](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;81)

___

### \_groupingPanel

• `Private` **\_groupingPanel**: `HTMLElement`

#### Defined in

[grid/grid.ts:82](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;82)

___

### \_hEditorLoader

• `Private` **\_hEditorLoader**: `number` = `null`

#### Defined in

[grid/grid.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;34)

___

### \_hPostRender

• `Private` **\_hPostRender**: `number` = `null`

#### Defined in

[grid/grid.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;35)

___

### \_hPostRenderCleanup

• `Private` **\_hPostRenderCleanup**: `number` = `null`

#### Defined in

[grid/grid.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;36)

___

### \_hRender

• `Private` **\_hRender**: `number` = `null`

#### Defined in

[grid/grid.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;37)

___

### \_headerColumnWidthDiff

• `Private` **\_headerColumnWidthDiff**: `number` = `0`

#### Defined in

[grid/grid.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;33)

___

### \_ignoreScrollUntil

• `Private` **\_ignoreScrollUntil**: `number` = `0`

#### Defined in

[grid/grid.ts:38](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;38)

___

### \_initColById

• `Private` **\_initColById**: `Object`

#### Index signature

▪ [key: `string`]: `number`

#### Defined in

[grid/grid.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;39)

___

### \_initCols

• `Private` **\_initCols**: [`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Defined in

[grid/grid.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;40)

___

### \_initialized

• `Private` **\_initialized**: `boolean` = `false`

#### Defined in

[grid/grid.ts:41](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;41)

___

### \_jQuery

• `Private` **\_jQuery**: `any`

#### Defined in

[grid/grid.ts:42](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;42)

___

### \_jumpinessCoefficient

• `Private` **\_jumpinessCoefficient**: `number`

#### Defined in

[grid/grid.ts:43](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;43)

___

### \_lastRenderTime

• `Private` **\_lastRenderTime**: `number`

#### Defined in

[grid/grid.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;44)

___

### \_layout

• `Private` **\_layout**: [`LayoutEngine`](../interfaces/LayoutEngine.md)

#### Defined in

[grid/grid.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;45)

___

### \_numberOfPages

• `Private` **\_numberOfPages**: `number`

#### Defined in

[grid/grid.ts:46](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;46)

___

### \_options

• `Private` **\_options**: [`GridOptions`](../interfaces/GridOptions.md)<`TItem`\>

#### Defined in

[grid/grid.ts:47](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;47)

___

### \_page

• `Private` **\_page**: `number` = `0`

#### Defined in

[grid/grid.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;48)

___

### \_pageHeight

• `Private` **\_pageHeight**: `number`

#### Defined in

[grid/grid.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;49)

___

### \_pageOffset

• `Private` **\_pageOffset**: `number` = `0`

#### Defined in

[grid/grid.ts:50](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;50)

___

### \_pagingActive

• `Private` **\_pagingActive**: `boolean` = `false`

#### Defined in

[grid/grid.ts:51](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;51)

___

### \_pagingIsLastPage

• `Private` **\_pagingIsLastPage**: `boolean` = `false`

#### Defined in

[grid/grid.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;52)

___

### \_plugins

• `Private` **\_plugins**: [`IPlugin`](../interfaces/IPlugin.md)[] = `[]`

#### Defined in

[grid/grid.ts:53](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;53)

___

### \_postProcessCleanupQueue

• `Private` **\_postProcessCleanupQueue**: `PostProcessCleanupEntry`[] = `[]`

#### Defined in

[grid/grid.ts:54](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;54)

___

### \_postProcessFromRow

• `Private` **\_postProcessFromRow**: `number` = `null`

#### Defined in

[grid/grid.ts:56](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;56)

___

### \_postProcessGroupId

• `Private` **\_postProcessGroupId**: `number` = `0`

#### Defined in

[grid/grid.ts:57](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;57)

___

### \_postProcessToRow

• `Private` **\_postProcessToRow**: `number` = `null`

#### Defined in

[grid/grid.ts:58](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;58)

___

### \_postProcessedRows

• `Private` **\_postProcessedRows**: `any` = `{}`

#### Defined in

[grid/grid.ts:55](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;55)

___

### \_rowsCache

• `Private` **\_rowsCache**: `Object` = `{}`

#### Index signature

▪ [key: `number`]: `CachedRow`

#### Defined in

[grid/grid.ts:59](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;59)

___

### \_scrollDims

• `Private` **\_scrollDims**: `Object`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `height` | `number` |
| `width` | `number` |

#### Defined in

[grid/grid.ts:60](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;60)

___

### \_scrollLeft

• `Private` **\_scrollLeft**: `number` = `0`

#### Defined in

[grid/grid.ts:61](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;61)

___

### \_scrollLeftPrev

• `Private` **\_scrollLeftPrev**: `number` = `0`

#### Defined in

[grid/grid.ts:62](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;62)

___

### \_scrollLeftRendered

• `Private` **\_scrollLeftRendered**: `number` = `0`

#### Defined in

[grid/grid.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;63)

___

### \_scrollTop

• `Private` **\_scrollTop**: `number` = `0`

#### Defined in

[grid/grid.ts:64](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;64)

___

### \_scrollTopPrev

• `Private` **\_scrollTopPrev**: `number` = `0`

#### Defined in

[grid/grid.ts:65](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;65)

___

### \_scrollTopRendered

• `Private` **\_scrollTopRendered**: `number` = `0`

#### Defined in

[grid/grid.ts:66](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;66)

___

### \_selectedRows

• `Private` **\_selectedRows**: `number`[] = `[]`

#### Defined in

[grid/grid.ts:67](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;67)

___

### \_selectionModel

• `Private` **\_selectionModel**: [`SelectionModel`](../interfaces/SelectionModel.md)

#### Defined in

[grid/grid.ts:68](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;68)

___

### \_serializedEditorValue

• `Private` **\_serializedEditorValue**: `any`

#### Defined in

[grid/grid.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;69)

___

### \_sortColumns

• `Private` **\_sortColumns**: [`ColumnSort`](../interfaces/ColumnSort.md)[] = `[]`

#### Defined in

[grid/grid.ts:70](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;70)

___

### \_styleNode

• `Private` **\_styleNode**: `HTMLStyleElement`

#### Defined in

[grid/grid.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;71)

___

### \_stylesheet

• `Private` **\_stylesheet**: `any`

#### Defined in

[grid/grid.ts:72](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;72)

___

### \_tabbingDirection

• `Private` **\_tabbingDirection**: `number` = `1`

#### Defined in

[grid/grid.ts:73](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;73)

___

### \_uid

• `Private` **\_uid**: `string`

#### Defined in

[grid/grid.ts:74](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;74)

___

### \_vScrollDir

• `Private` **\_vScrollDir**: `number` = `1`

#### Defined in

[grid/grid.ts:76](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;76)

___

### \_viewportInfo

• `Private` **\_viewportInfo**: [`ViewportInfo`](../interfaces/ViewportInfo.md)

#### Defined in

[grid/grid.ts:75](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;75)

___

### onActiveCellChanged

• `Readonly` **onActiveCellChanged**: [`EventEmitter`](EventEmitter.md)<[`ArgsCell`](../interfaces/ArgsCell.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:84](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;84)

___

### onActiveCellPositionChanged

• `Readonly` **onActiveCellPositionChanged**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:85](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;85)

___

### onAddNewRow

• `Readonly` **onAddNewRow**: [`EventEmitter`](EventEmitter.md)<[`ArgsAddNewRow`](../interfaces/ArgsAddNewRow.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:86](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;86)

___

### onBeforeCellEditorDestroy

• `Readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](EventEmitter.md)<[`ArgsEditorDestroy`](../interfaces/ArgsEditorDestroy.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;87)

___

### onBeforeDestroy

• `Readonly` **onBeforeDestroy**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:88](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;88)

___

### onBeforeEditCell

• `Readonly` **onBeforeEditCell**: [`EventEmitter`](EventEmitter.md)<[`ArgsCellEdit`](../interfaces/ArgsCellEdit.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:89](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;89)

___

### onBeforeFooterRowCellDestroy

• `Readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:90](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;90)

___

### onBeforeHeaderCellDestroy

• `Readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:91](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;91)

___

### onBeforeHeaderRowCellDestroy

• `Readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:92](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;92)

___

### onCellChange

• `Readonly` **onCellChange**: [`EventEmitter`](EventEmitter.md)<[`ArgsCellChange`](../interfaces/ArgsCellChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:93](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;93)

___

### onCellCssStylesChanged

• `Readonly` **onCellCssStylesChanged**: [`EventEmitter`](EventEmitter.md)<[`ArgsCssStyle`](../interfaces/ArgsCssStyle.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:94](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;94)

___

### onClick

• `Readonly` **onClick**: [`EventEmitter`](EventEmitter.md)<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:95](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;95)

___

### onColumnsReordered

• `Readonly` **onColumnsReordered**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:96](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;96)

___

### onColumnsResized

• `Readonly` **onColumnsResized**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:97](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;97)

___

### onCompositeEditorChange

• `Readonly` **onCompositeEditorChange**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[onCompositeEditorChange](../interfaces/EditorHost.md#oncompositeeditorchange)

#### Defined in

[grid/grid.ts:98](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;98)

___

### onContextMenu

• `Readonly` **onContextMenu**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:99](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;99)

___

### onDblClick

• `Readonly` **onDblClick**: [`EventEmitter`](EventEmitter.md)<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:100](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;100)

___

### onDrag

• `Readonly` **onDrag**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:101](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;101)

___

### onDragEnd

• `Readonly` **onDragEnd**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:102](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;102)

___

### onDragInit

• `Readonly` **onDragInit**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:103](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;103)

___

### onDragStart

• `Readonly` **onDragStart**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

#### Defined in

[grid/grid.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;104)

___

### onFooterRowCellRendered

• `Readonly` **onFooterRowCellRendered**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:105](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;105)

___

### onHeaderCellRendered

• `Readonly` **onHeaderCellRendered**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:106](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;106)

___

### onHeaderClick

• `Readonly` **onHeaderClick**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:107](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;107)

___

### onHeaderContextMenu

• `Readonly` **onHeaderContextMenu**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumn`](../interfaces/ArgsColumn.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:108](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;108)

___

### onHeaderMouseEnter

• `Readonly` **onHeaderMouseEnter**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:109](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;109)

___

### onHeaderMouseLeave

• `Readonly` **onHeaderMouseLeave**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:110](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;110)

___

### onHeaderRowCellRendered

• `Readonly` **onHeaderRowCellRendered**: [`EventEmitter`](EventEmitter.md)<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:111](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;111)

___

### onKeyDown

• `Readonly` **onKeyDown**: [`EventEmitter`](EventEmitter.md)<[`ArgsCell`](../interfaces/ArgsCell.md), `KeyboardEvent`\>

#### Defined in

[grid/grid.ts:112](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;112)

___

### onMouseEnter

• `Readonly` **onMouseEnter**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:113](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;113)

___

### onMouseLeave

• `Readonly` **onMouseLeave**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

#### Defined in

[grid/grid.ts:114](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;114)

___

### onScroll

• `Readonly` **onScroll**: [`EventEmitter`](EventEmitter.md)<[`ArgsScroll`](../interfaces/ArgsScroll.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:115](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;115)

___

### onSelectedRowsChanged

• `Readonly` **onSelectedRowsChanged**: [`EventEmitter`](EventEmitter.md)<[`ArgsSelectedRowsChange`](../interfaces/ArgsSelectedRowsChange.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:116](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;116)

___

### onSort

• `Readonly` **onSort**: [`EventEmitter`](EventEmitter.md)<[`ArgsSort`](../interfaces/ArgsSort.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:117](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;117)

___

### onValidationError

• `Readonly` **onValidationError**: [`EventEmitter`](EventEmitter.md)<[`ArgsValidationError`](../interfaces/ArgsValidationError.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:118](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;118)

___

### onViewportChanged

• `Readonly` **onViewportChanged**: [`EventEmitter`](EventEmitter.md)<[`ArgsGrid`](../interfaces/ArgsGrid.md), [`IEventData`](../interfaces/IEventData.md)\>

#### Defined in

[grid/grid.ts:119](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;119)

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

[grid/grid.ts:2784](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2784)

___

### appendCellHtml

▸ `Private` **appendCellHtml**(`sb`, `row`, `cell`, `colspan`, `item`, `metadata`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `sb` | `string`[] |
| `row` | `number` |
| `cell` | `number` |
| `colspan` | `number` |
| `item` | `TItem` |
| `metadata` | [`ColumnMetadata`](../interfaces/ColumnMetadata.md)<`any`\> |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1822](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1822)

___

### appendRowHtml

▸ `Private` **appendRowHtml**(`stringArrayL`, `stringArrayR`, `row`, `range`, `dataLength`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `stringArrayL` | `string`[] |
| `stringArrayR` | `string`[] |
| `row` | `number` |
| `range` | [`ViewRange`](../interfaces/ViewRange.md) |
| `dataLength` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1754](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1754)

___

### applyColumnHeaderWidths

▸ `Private` **applyColumnHeaderWidths**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1241](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1241)

___

### asyncPostProcessCleanupRows

▸ `Private` **asyncPostProcessCleanupRows**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2725](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2725)

___

### asyncPostProcessRows

▸ `Private` **asyncPostProcessRows**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2683](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2683)

___

### autosizeColumns

▸ **autosizeColumns**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1227](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1227)

___

### bindAncestorScroll

▸ `Private` **bindAncestorScroll**(`elem`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `elem` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:246](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;246)

___

### bindToData

▸ `Private` **bindToData**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1479](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1479)

___

### calcViewportSize

▸ `Private` **calcViewportSize**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2052](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2052)

___

### canCellBeActive

▸ `Private` **canCellBeActive**(`row`, `cell`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3740](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3740)

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

[grid/grid.ts:3763](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3763)

___

### cancelCurrentEdit

▸ `Private` **cancelCurrentEdit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3887](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3887)

___

### cancelEditAndSetFocus

▸ `Private` **cancelEditAndSetFocus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3431](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3431)

___

### cellExists

▸ `Private` **cellExists**(`row`, `cell`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3071](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3071)

___

### cleanUpAndRenderCells

▸ `Private` **cleanUpAndRenderCells**(`range`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `range` | [`ViewRange`](../interfaces/ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2321](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2321)

___

### cleanUpCells

▸ `Private` **cleanUpCells**(`range`, `row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `range` | [`ViewRange`](../interfaces/ViewRange.md) |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2272](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2272)

___

### cleanupRows

▸ `Private` **cleanupRows**(`rangeToKeep`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rangeToKeep` | [`ViewRange`](../interfaces/ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1898](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1898)

___

### clearTextSelection

▸ **clearTextSelection**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3294](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3294)

___

### colIdOrIdxToCell

▸ `Private` **colIdOrIdxToCell**(`columnIdOrIdx`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columnIdOrIdx` | `string` \| `number` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:452](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;452)

___

### commitCurrentEdit

▸ **commitCurrentEdit**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3808](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3808)

___

### commitEditAndSetFocus

▸ `Private` **commitEditAndSetFocus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3420](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3420)

___

### createColumnFooters

▸ `Private` **createColumnFooters**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:602](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;602)

___

### createColumnHeaders

▸ `Private` **createColumnHeaders**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:645](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;645)

___

### createCssRules

▸ `Private` **createCssRules**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1064](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1064)

___

### createGroupingPanel

▸ `Private` **createGroupingPanel**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:232](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;232)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1161](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1161)

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

[grid/grid.ts:3351](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3351)

___

### ensureCellNodesInRowsCache

▸ `Private` **ensureCellNodesInRowsCache**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2254](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2254)

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

[grid/grid.ts:2819](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2819)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3188](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3188)

___

### getAbsoluteColumnMinWidth

▸ **getAbsoluteColumnMinWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:444](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;444)

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

[grid/grid.ts:471](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;471)

___

### getActiveCell

▸ **getActiveCell**(): [`RowCell`](../interfaces/RowCell.md)

#### Returns

[`RowCell`](../interfaces/RowCell.md)

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[getActiveCell](../interfaces/EditorHost.md#getactivecell)

#### Defined in

[grid/grid.ts:3472](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3472)

___

### getActiveCellNode

▸ **getActiveCellNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:3480](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3480)

___

### getActiveCellPosition

▸ `Private` **getActiveCellPosition**(): [`Position`](../interfaces/Position.md)

#### Returns

[`Position`](../interfaces/Position.md)

#### Defined in

[grid/grid.ts:3437](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3437)

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

[grid/grid.ts:486](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;486)

___

### getAvailableWidth

▸ `Private` **getAvailableWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:494](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;494)

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

[grid/grid.ts:462](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;462)

___

### getCanvases

▸ **getCanvases**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:466](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;466)

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

[grid/grid.ts:2815](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2815)

___

### getCellEditor

▸ **getCellEditor**(): [`Editor`](../interfaces/Editor.md)

#### Returns

[`Editor`](../interfaces/Editor.md)

#### Defined in

[grid/grid.ts:3468](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3468)

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

[grid/grid.ts:3130](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3130)

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

[grid/grid.ts:3092](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3092)

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

[grid/grid.ts:3075](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3075)

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

[grid/grid.ts:3705](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3705)

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

[grid/grid.ts:3150](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3150)

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

[grid/grid.ts:3604](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3604)

___

### getColumnCssRules

▸ `Private` **getColumnCssRules**(`idx`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `idx` | `number` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `left` | `any` |
| `right` | `any` |

#### Defined in

[grid/grid.ts:1107](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1107)

___

### getColumnFromNode

▸ **getColumnFromNode**(`cellNode`): [`Column`](../interfaces/Column.md)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `Element` |

#### Returns

[`Column`](../interfaces/Column.md)<`TItem`\>

#### Defined in

[grid/grid.ts:3108](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3108)

___

### getColumnIndex

▸ **getColumnIndex**(`id`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1219](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1219)

___

### getColumns

▸ **getColumns**(): [`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Returns

[`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Defined in

[grid/grid.ts:1344](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1344)

___

### getContainerNode

▸ **getContainerNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1615](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1615)

___

### getData

▸ **getData**(): `any`

#### Returns

`any`

#### Defined in

[grid/grid.ts:1506](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1506)

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

[grid/grid.ts:1523](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1523)

___

### getDataItemValueForColumn

▸ **getDataItemValueForColumn**(`item`, `columnDef`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `columnDef` | [`Column`](../interfaces/Column.md)<`TItem`\> |

#### Returns

`any`

#### Defined in

[grid/grid.ts:1748](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1748)

___

### getDataLength

▸ **getDataLength**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1510](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1510)

___

### getDataLengthIncludingAddNew

▸ `Private` **getDataLengthIncludingAddNew**(): `number`

#### Returns

`number`

#### Defined in

[grid/grid.ts:1518](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1518)

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

[grid/grid.ts:437](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;437)

___

### getEditController

▸ **getEditController**(): [`EditController`](../interfaces/EditController.md)

#### Returns

[`EditController`](../interfaces/EditController.md)

#### Defined in

[grid/grid.ts:1215](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1215)

___

### getEditor

▸ `Private` **getEditor**(`row`, `cell`): [`EditorClass`](../interfaces/EditorClass.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

[`EditorClass`](../interfaces/EditorClass.md)

#### Defined in

[grid/grid.ts:1733](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1733)

___

### getEditorLock

▸ **getEditorLock**(): [`EditorLock`](EditorLock.md)

#### Returns

[`EditorLock`](EditorLock.md)

#### Defined in

[grid/grid.ts:1211](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1211)

___

### getFooterRow

▸ **getFooterRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:590](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;590)

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

[grid/grid.ts:594](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;594)

___

### getFormatter

▸ **getFormatter**(`row`, `column`): [`ColumnFormat`](../README.md#columnformat)<`TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `column` | [`Column`](../interfaces/Column.md)<`TItem`\> |

#### Returns

[`ColumnFormat`](../README.md#columnformat)<`TItem`\>

#### Defined in

[grid/grid.ts:1663](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1663)

___

### getFormatterContext

▸ **getFormatterContext**(`row`, `cell`): [`FormatterContext`](../interfaces/FormatterContext.md)<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

[`FormatterContext`](../interfaces/FormatterContext.md)<`any`\>

#### Defined in

[grid/grid.ts:1717](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1717)

___

### getGridPosition

▸ **getGridPosition**(): [`Position`](../interfaces/Position.md)

#### Returns

[`Position`](../interfaces/Position.md)

#### Defined in

[grid/grid.ts:3441](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3441)

___

### getGroupingPanel

▸ **getGroupingPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:570](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;570)

___

### getHeader

▸ **getHeader**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:558](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;558)

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

[grid/grid.ts:562](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;562)

___

### getHeaderRow

▸ **getHeaderRow**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:578](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;578)

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

[grid/grid.ts:582](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;582)

___

### getInitialColumnIndex

▸ **getInitialColumnIndex**(`id`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1223](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1223)

___

### getInitialColumns

▸ **getInitialColumns**(): [`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Returns

[`Column`](../interfaces/Column.md)<`TItem`\>[]

#### Defined in

[grid/grid.ts:1348](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1348)

___

### getOptions

▸ **getOptions**(): [`GridOptions`](../interfaces/GridOptions.md)<`TItem`\>

#### Returns

[`GridOptions`](../interfaces/GridOptions.md)<`TItem`\>

#### Defined in

[grid/grid.ts:1416](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1416)

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

[grid/grid.ts:408](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;408)

___

### getPreHeaderPanel

▸ **getPreHeaderPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:574](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;574)

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

[grid/grid.ts:2220](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2220)

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

[grid/grid.ts:3119](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3119)

___

### getRowFromPosition

▸ `Private` **getRowFromPosition**(`y`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `y` | `number` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1630](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1630)

___

### getRowTop

▸ `Private` **getRowTop**(`row`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`number`

#### Defined in

[grid/grid.ts:1626](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1626)

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

[grid/grid.ts:433](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;433)

___

### getSelectedRows

▸ **getSelectedRows**(): `number`[]

#### Returns

`number`[]

#### Defined in

[grid/grid.ts:3901](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3901)

___

### getSelectionModel

▸ **getSelectionModel**(): [`SelectionModel`](../interfaces/SelectionModel.md)

#### Returns

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Defined in

[grid/grid.ts:448](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;448)

___

### getSortColumns

▸ **getSortColumns**(): [`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Returns

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Defined in

[grid/grid.ts:1289](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1289)

___

### getTopPanel

▸ **getTopPanel**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/grid.ts:1531](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1531)

___

### getUID

▸ **getUID**(): `string`

#### Returns

`string`

#### Defined in

[grid/grid.ts:1619](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1619)

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

[grid/grid.ts:2198](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2198)

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

[grid/grid.ts:478](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;478)

___

### getViewports

▸ `Private` **getViewports**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/grid.ts:482](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;482)

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

[grid/grid.ts:2202](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2202)

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

[grid/grid.ts:3782](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3782)

___

### groupTotalsFormatter

▸ **groupTotalsFormatter**(`p1?`, `p2?`, `grid?`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `p1?` | [`GroupTotals`](GroupTotals.md)<`TItem`\> |
| `p2?` | [`Column`](../interfaces/Column.md)<`TItem`\> |
| `grid?` | `any` |

#### Returns

`string`

#### Defined in

[grid/grid.ts:2552](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2552)

___

### handleActiveCellPositionChange

▸ `Private` **handleActiveCellPositionChange**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3445](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3445)

___

### handleClick

▸ `Private` **handleClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2980](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2980)

___

### handleContextMenu

▸ `Private` **handleContextMenu**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3011](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3011)

___

### handleDblClick

▸ `Private` **handleDblClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3025](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3025)

___

### handleDrag

▸ `Private` **handleDrag**(`e`, `dd`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `UIEvent` |
| `dd` | `any` |

#### Returns

`any`

#### Defined in

[grid/grid.ts:2874](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2874)

___

### handleDragEnd

▸ `Private` **handleDragEnd**(`e`, `dd`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `UIEvent` |
| `dd` | `any` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2878](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2878)

___

### handleDragInit

▸ `Private` **handleDragInit**(`e`, `dd`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `UIEvent` |
| `dd` | `any` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:2844](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2844)

___

### handleDragStart

▸ `Private` **handleDragStart**(`e`, `dd`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `UIEvent` |
| `dd` | `any` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:2860](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2860)

___

### handleFooterRowScroll

▸ `Private` **handleFooterRowScroll**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`IEventData`](../interfaces/IEventData.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2594](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2594)

___

### handleHeaderClick

▸ `Private` **handleHeaderClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3057](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3057)

___

### handleHeaderContextMenu

▸ `Private` **handleHeaderContextMenu**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3051](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3051)

___

### handleHeaderMouseEnter

▸ `Private` **handleHeaderMouseEnter**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3041](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3041)

___

### handleHeaderMouseLeave

▸ `Private` **handleHeaderMouseLeave**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3046](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3046)

___

### handleHeaderRowScroll

▸ `Private` **handleHeaderRowScroll**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`IEventData`](../interfaces/IEventData.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2584](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2584)

___

### handleKeyDown

▸ `Private` **handleKeyDown**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `KeyboardEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2882](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2882)

___

### handleMouseEnter

▸ `Private` **handleMouseEnter**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3063](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3063)

___

### handleMouseLeave

▸ `Private` **handleMouseLeave**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3067](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3067)

___

### handleMouseWheel

▸ `Private` **handleMouseWheel**(`e`, `delta`, `deltaX`, `deltaY`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `MouseEvent` |
| `delta` | `number` |
| `deltaX` | `number` |
| `deltaY` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2604](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2604)

___

### handleScroll

▸ `Private` **handleScroll**(`isMouseWheel?`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `isMouseWheel?` | `boolean` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:2612](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2612)

___

### handleSelectedRangesChanged

▸ `Private` **handleSelectedRangesChanged**(`e`, `ranges`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`IEventData`](../interfaces/IEventData.md) |
| `ranges` | [`Range`](Range.md)[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1293](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1293)

___

### hasFrozenColumns

▸ `Private` **hasFrozenColumns**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:383](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;383)

___

### hasFrozenRows

▸ `Private` **hasFrozenRows**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:387](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;387)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:254](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;254)

___

### internalScrollColumnIntoView

▸ `Private` **internalScrollColumnIntoView**(`left`, `right`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `left` | `number` |
| `right` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3214](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3214)

___

### invalidate

▸ **invalidate**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1910](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1910)

___

### invalidateAllRows

▸ **invalidateAllRows**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1917](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1917)

___

### invalidatePostProcessingResults

▸ `Private` **invalidatePostProcessingResults**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2503](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2503)

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

[grid/grid.ts:2000](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2000)

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

[grid/grid.ts:1982](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1982)

___

### isCellPotentiallyEditable

▸ `Private` **isCellPotentiallyEditable**(`row`, `cell`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3308](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3308)

___

### makeActiveCellEditable

▸ `Private` **makeActiveCellEditable**(`editor?`, `preClickModeOn?`, `e?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `editor?` | [`EditorClass`](../interfaces/EditorClass.md) |
| `preClickModeOn?` | `boolean` |
| `e?` | `any` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3355](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3355)

___

### makeActiveCellNormal

▸ `Private` **makeActiveCellNormal**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3328](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3328)

___

### measureCellPaddingAndBorder

▸ `Private` **measureCellPaddingAndBorder**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1039](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1039)

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

[grid/grid.ts:3658](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3658)

___

### navigateBottom

▸ **navigateBottom**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3567](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3567)

___

### navigateDown

▸ **navigateDown**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3630](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3630)

___

### navigateLeft

▸ **navigateLeft**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3626](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3626)

___

### navigateNext

▸ **navigateNext**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[navigateNext](../interfaces/EditorHost.md#navigatenext)

#### Defined in

[grid/grid.ts:3638](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3638)

___

### navigatePageDown

▸ **navigatePageDown**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3555](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3555)

___

### navigatePageUp

▸ **navigatePageUp**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3559](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3559)

___

### navigatePrev

▸ **navigatePrev**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[EditorHost](../interfaces/EditorHost.md).[navigatePrev](../interfaces/EditorHost.md#navigateprev)

#### Defined in

[grid/grid.ts:3642](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3642)

___

### navigateRight

▸ **navigateRight**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3622](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3622)

___

### navigateRowEnd

▸ **navigateRowEnd**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3650](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3650)

___

### navigateRowStart

▸ **navigateRowStart**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3646](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3646)

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

[grid/grid.ts:3571](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3571)

___

### navigateTop

▸ **navigateTop**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3563](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3563)

___

### navigateUp

▸ **navigateUp**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/grid.ts:3634](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3634)

___

### queuePostProcessedCellForCleanup

▸ `Private` **queuePostProcessedCellForCleanup**(`cellnode`, `columnIdx`, `rowIdx`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellnode` | `HTMLElement` |
| `columnIdx` | `number` |
| `rowIdx` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1954](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1954)

___

### queuePostProcessedRowForCleanup

▸ `Private` **queuePostProcessedRowForCleanup**(`cacheEntry`, `postProcessedRow`, `rowIdx`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cacheEntry` | `CachedRow` |
| `postProcessedRow` | `Object` |
| `rowIdx` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1928](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1928)

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

[grid/grid.ts:391](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;391)

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

[grid/grid.ts:2795](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2795)

___

### removeCssRules

▸ `Private` **removeCssRules**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1155](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1155)

___

### removeRowFromCache

▸ `Private` **removeRowFromCache**(`row`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1964](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1964)

___

### render

▸ **render**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2556](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2556)

___

### renderRows

▸ `Private` **renderRows**(`range`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `range` | [`ViewRange`](../interfaces/ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2410](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2410)

___

### resetActiveCell

▸ **resetActiveCell**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3184](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3184)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2082](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2082)

___

### rowsToRanges

▸ `Private` **rowsToRanges**(`rows`): [`Range`](Range.md)[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `rows` | `number`[] |

#### Returns

[`Range`](Range.md)[]

#### Defined in

[grid/grid.ts:3892](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3892)

___

### scrollActiveCellIntoView

▸ **scrollActiveCellIntoView**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3484](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3484)

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

[grid/grid.ts:3200](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3200)

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

[grid/grid.ts:3210](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3210)

___

### scrollPage

▸ `Private` **scrollPage**(`dir`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dir` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3522](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3522)

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

[grid/grid.ts:3490](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3490)

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

[grid/grid.ts:3517](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3517)

___

### scrollTo

▸ `Private` **scrollTo**(`y`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `y` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1634](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1634)

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

[grid/grid.ts:3713](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3713)

___

### setActiveCellInternal

▸ `Private` **setActiveCellInternal**(`newCell`, `opt_editMode?`, `preClickModeOn?`, `suppressActiveCellChangedEvent?`, `e?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `newCell` | `HTMLElement` |
| `opt_editMode?` | `boolean` |
| `preClickModeOn?` | `boolean` |
| `suppressActiveCellChangedEvent?` | `boolean` |
| `e?` | `any` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:3232](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3232)

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

[grid/grid.ts:3728](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3728)

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

[grid/grid.ts:2806](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2806)

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

[grid/grid.ts:1550](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1550)

___

### setColumns

▸ **setColumns**(`columns`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `columns` | [`Column`](../interfaces/Column.md)<`TItem`\>[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1394](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1394)

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

[grid/grid.ts:1495](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1495)

___

### setFocus

▸ `Private` **setFocus**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:3192](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3192)

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

[grid/grid.ts:1565](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1565)

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

[grid/grid.ts:1580](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1580)

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

[grid/grid.ts:1600](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1600)

___

### setInitialCols

▸ `Private` **setInitialCols**(`initCols`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `initCols` | [`Column`](../interfaces/Column.md)<`any`\>[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1366](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1366)

___

### setOptions

▸ **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`GridOptions`](../interfaces/GridOptions.md)<`TItem`\> |
| `suppressRender?` | `boolean` |
| `suppressColumnSet?` | `boolean` |
| `suppressSetOverflow?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1420](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1420)

___

### setOverflow

▸ `Private` **setOverflow**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1033](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1033)

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

[grid/grid.ts:1596](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1596)

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

[grid/grid.ts:3908](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;3908)

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

[grid/grid.ts:415](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;415)

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

[grid/grid.ts:1258](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1258)

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

[grid/grid.ts:1262](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1262)

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

[grid/grid.ts:1535](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1535)

___

### setupColumnReorder

▸ `Private` **setupColumnReorder**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:832](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;832)

___

### setupColumnResize

▸ `Private` **setupColumnResize**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:919](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;919)

___

### setupColumnSort

▸ `Private` **setupColumnSort**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:760](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;760)

___

### startPostProcessing

▸ `Private` **startPostProcessing**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2474](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2474)

___

### startPostProcessingCleanup

▸ `Private` **startPostProcessingCleanup**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2488](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2488)

___

### trigger

▸ `Private` **trigger**<`TArgs`, `TEventData`\>(`evt`, `args?`, `e?`): `any`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TArgs` | extends [`ArgsGrid`](../interfaces/ArgsGrid.md) |
| `TEventData` | extends [`IEventData`](../interfaces/IEventData.md) = [`IEventData`](../interfaces/IEventData.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `evt` | [`EventEmitter`](EventEmitter.md)<`TArgs`, `TEventData`\> |
| `args?` | `TArgs` |
| `e?` | `TEventData` |

#### Returns

`any`

#### Defined in

[grid/grid.ts:1203](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1203)

___

### unbindAncestorScrollEvents

▸ `Private` **unbindAncestorScrollEvents**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:506](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;506)

___

### unbindFromData

▸ `Private` **unbindFromData**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1487](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1487)

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

[grid/grid.ts:396](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;396)

___

### unregisterSelectionModel

▸ `Private` **unregisterSelectionModel**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:425](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;425)

___

### updateCanvasWidth

▸ `Private` **updateCanvasWidth**(`forceColumnWidthsUpdate?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `forceColumnWidthsUpdate?` | `boolean` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:498](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;498)

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

[grid/grid.ts:2004](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2004)

___

### updateCellCssStylesOnRenderedRows

▸ `Private` **updateCellCssStylesOnRenderedRows**(`addedHash`, `removedHash`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `addedHash` | [`CellStylesHash`](../README.md#cellstyleshash) |
| `removedHash` | [`CellStylesHash`](../README.md#cellstyleshash) |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2752](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2752)

___

### updateCellWithFormatter

▸ `Private` **updateCellWithFormatter**(`cellNode`, `row`, `cell`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `HTMLElement` |
| `row` | `number` |
| `cell` | `number` |

#### Returns

`void`

#### Defined in

[grid/grid.ts:2017](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2017)

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

[grid/grid.ts:514](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;514)

___

### updateGrandTotals

▸ `Private` **updateGrandTotals**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2530](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2530)

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

[grid/grid.ts:2105](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2105)

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

[grid/grid.ts:2025](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2025)

___

### updateRowCount

▸ `Private` **updateRowCount**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2110](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2110)

___

### updateRowPositions

▸ `Private` **updateRowPositions**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:2521](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;2521)

___

### updateViewColLeftRight

▸ `Private` **updateViewColLeftRight**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1352](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1352)

___

### validateAndEnforceOptions

▸ `Private` **validateAndEnforceOptions**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1457](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1457)

___

### viewOnDataChanged

▸ `Private` **viewOnDataChanged**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1474](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1474)

___

### viewOnRowCountChanged

▸ `Private` **viewOnRowCountChanged**(): `void`

#### Returns

`void`

#### Defined in

[grid/grid.ts:1463](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1463)

___

### viewOnRowsChanged

▸ `Private` **viewOnRowsChanged**(`_`, `args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `_` | `any` |
| `args` | `Object` |
| `args.rows` | `number`[] |

#### Returns

`void`

#### Defined in

[grid/grid.ts:1468](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/grid.ts#line&#x3D;1468)
