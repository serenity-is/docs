[@serenity-is/sleekgrid](../README.md) / GridOptions

# Interface: GridOptions\<TItem\>

Configuration options for the SleekGrid component.

## Type Parameters

• **TItem** = `any`

The type of items in the grid.

## Properties

### addNewRowCssClass?

> `optional` **addNewRowCssClass**: `string`

CSS class applied to newly added rows for custom styling. Default is `"new-row"`.

#### Defined in

[grid/gridoptions.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L14)

***

### alwaysAllowHorizontalScroll?

> `optional` **alwaysAllowHorizontalScroll**: `boolean`

Defaults to `false`. If `true`, a horizontal scrollbar is always visible regardless of content width.

#### Defined in

[grid/gridoptions.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L19)

***

### alwaysShowVerticalScroll?

> `optional` **alwaysShowVerticalScroll**: `boolean`

Defaults to `false`. If `true`, a vertical scrollbar is always visible, useful for fixed-height grids or menus.

#### Defined in

[grid/gridoptions.ts:24](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L24)

***

### asyncEditorLoadDelay?

> `optional` **asyncEditorLoadDelay**: `number`

Defaults to `100`. Delay in milliseconds before asynchronous loading of editors.

#### Defined in

[grid/gridoptions.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L29)

***

### asyncEditorLoading?

> `optional` **asyncEditorLoading**: `boolean`

Defaults to `false`. If `true`, editors are loaded asynchronously, reducing initial rendering load.

#### Defined in

[grid/gridoptions.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L34)

***

### asyncPostCleanupDelay?

> `optional` **asyncPostCleanupDelay**: `number`

Defaults to `40`. Delay in milliseconds before cleaning up post-rendered elements.

#### Defined in

[grid/gridoptions.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L39)

***

### asyncPostRenderDelay?

> `optional` **asyncPostRenderDelay**: `number`

Defaults to `-1` which means immediate execution. Delay in milliseconds before starting asynchronous post-rendering.

#### Defined in

[grid/gridoptions.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L44)

***

### autoEdit?

> `optional` **autoEdit**: `boolean`

Defaults to `true`. If `true`, automatically opens the cell editor when a cell gains focus.

#### Defined in

[grid/gridoptions.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L49)

***

### autoHeight?

> `optional` **autoHeight**: `boolean`

Defaults to `false`. If `true`, automatically adjusts the grid's height to fit the entire content without scrolling.

#### Defined in

[grid/gridoptions.ts:54](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L54)

***

### cellFlashingCssClass?

> `optional` **cellFlashingCssClass**: `string`

CSS class applied to cells with a flashing effect. Default is `"flashing"`.

#### Defined in

[grid/gridoptions.ts:59](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L59)

***

### columns?

> `optional` **columns**: [`Column`](Column.md)\<`TItem`\>[]

Array of column definitions for the grid.

#### Defined in

[grid/gridoptions.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L69)

***

### createPreHeaderPanel?

> `optional` **createPreHeaderPanel**: `boolean`

Defaults to `false`. If `true`, creates an extra pre-header panel for column grouping.

#### Defined in

[grid/gridoptions.ts:74](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L74)

***

### dataItemColumnValueExtractor()?

> `optional` **dataItemColumnValueExtractor**: (`item`, `column`) => `void`

Function to extract column values from data items, used for custom copy buffer operations. Default is `null`.

#### Parameters

##### item

`TItem`

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

`void`

#### Defined in

[grid/gridoptions.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L79)

***

### defaultColumnWidth?

> `optional` **defaultColumnWidth**: `number`

Defaults to `80`. Default width of columns in pixels.

#### Defined in

[grid/gridoptions.ts:84](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L84)

***

### defaultFormat?

> `optional` **defaultFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Default formatting options for columns. Default is `defaultColumnFormat`.

#### Defined in

[grid/gridoptions.ts:89](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L89)

***

### defaultFormatter?

> `optional` **defaultFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Default formatter function for cells.

#### Defined in

[grid/gridoptions.ts:94](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L94)

***

### editable?

> `optional` **editable**: `boolean`

Defaults to `false`. If `true`, cells can be edited inline.

#### Defined in

[grid/gridoptions.ts:99](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L99)

***

### editCommandHandler()?

> `optional` **editCommandHandler**: (`item`, `column`, `command`) => `void`

Function to handle edit commands, useful for implementing custom undo support. Default is `null`.

#### Parameters

##### item

`TItem`

##### column

[`Column`](Column.md)\<`TItem`\>

##### command

[`EditCommand`](EditCommand.md)

#### Returns

`void`

#### Defined in

[grid/gridoptions.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L104)

***

### editorCellNavOnLRKeys?

> `optional` **editorCellNavOnLRKeys**: `boolean`

Defaults to `false`. If `true`, enables navigation between cells using left and right arrow keys within the editor.

#### Defined in

[grid/gridoptions.ts:109](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L109)

***

### editorFactory?

> `optional` **editorFactory**: [`EditorFactory`](EditorFactory.md)

Factory function for creating custom editors. Default is `null`.

#### Defined in

[grid/gridoptions.ts:114](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L114)

***

### editorLock?

> `optional` **editorLock**: [`EditorLock`](../classes/EditorLock.md)

Global editor lock instance, used for managing concurrent editor access. Default is `GlobalEditorLock`.

#### Defined in

[grid/gridoptions.ts:119](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L119)

***

### emptyNode()?

> `optional` **emptyNode**: (`node`) => `void`

Function to handle clearing a DOM node, used for custom cleanup logic. Default is `null`.

#### Parameters

##### node

`Element`

#### Returns

`void`

#### Defined in

[grid/gridoptions.ts:64](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L64)

***

### enableAddRow?

> `optional` **enableAddRow**: `boolean`

Defaults to `false`. If `true`, enables the ability to add new rows to the grid.

#### Defined in

[grid/gridoptions.ts:124](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L124)

***

### enableAsyncPostRender?

> `optional` **enableAsyncPostRender**: `boolean`

Defaults to `false`. If `true`, enables asynchronous post-rendering.

#### Defined in

[grid/gridoptions.ts:129](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L129)

***

### enableAsyncPostRenderCleanup?

> `optional` **enableAsyncPostRenderCleanup**: `boolean`

Defaults to `false`. If `true`, enables cleanup after asynchronous post-rendering.

#### Defined in

[grid/gridoptions.ts:134](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L134)

***

### enableCellNavigation?

> `optional` **enableCellNavigation**: `boolean`

Defaults to `true`. If `true`, enables cell navigation with arrow keys.

#### Defined in

[grid/gridoptions.ts:139](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L139)

***

### enableCellRangeSelection?

> `optional` **enableCellRangeSelection**: `boolean`

Defaults to `false`. If `true`, allows selection of cell ranges.

#### Defined in

[grid/gridoptions.ts:144](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L144)

***

### enableColumnReorder?

> `optional` **enableColumnReorder**: `boolean`

Defaults to `true`. If `true`, enables column reordering.

#### Defined in

[grid/gridoptions.ts:149](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L149)

***

### enableRowReordering?

> `optional` **enableRowReordering**: `boolean`

Defaults to `false`. If `true`, enables row reordering.

#### Defined in

[grid/gridoptions.ts:154](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L154)

***

### enableTabKeyNavigation?

> `optional` **enableTabKeyNavigation**: `boolean`

Defaults to `true`. If `true`, enables navigation between cells using the Tab key.

#### Defined in

[grid/gridoptions.ts:159](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L159)

***

### enableTextSelectionOnCells?

> `optional` **enableTextSelectionOnCells**: `boolean`

Defaults to `false`. If `true`, enables text selection within cells.

#### Defined in

[grid/gridoptions.ts:164](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L164)

***

### explicitInitialization?

> `optional` **explicitInitialization**: `boolean`

Defaults to `false`. If `true`, requires explicit initialization of the grid.

#### Defined in

[grid/gridoptions.ts:169](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L169)

***

### footerRowHeight?

> `optional` **footerRowHeight**: `number`

Defaults to `30`. Height of the footer row in pixels.

#### Defined in

[grid/gridoptions.ts:174](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L174)

***

### forceFitColumns?

> `optional` **forceFitColumns**: `boolean`

Defaults to `false`. If `true`, forces columns to fit the grid width.

#### Defined in

[grid/gridoptions.ts:179](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L179)

***

### forceSyncScrolling?

> `optional` **forceSyncScrolling**: `boolean`

Defaults to `false`. If `true`, synchronizes scrolling between the grid and its container.

#### Defined in

[grid/gridoptions.ts:184](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L184)

***

### forceSyncScrollInterval?

> `optional` **forceSyncScrollInterval**: `number`

Defaults to `250`. Interval in milliseconds for synchronizing scrolling when `forceSyncScrolling` is enabled.

#### Defined in

[grid/gridoptions.ts:189](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L189)

***

### formatterFactory?

> `optional` **formatterFactory**: [`FormatterFactory`](FormatterFactory.md)\<`any`\>

Factory function for creating custom formatters. Default is `null`.

#### Defined in

[grid/gridoptions.ts:194](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L194)

***

### frozenBottom?

> `optional` **frozenBottom**: `boolean`

Defaults to `false`. If `true`, places frozen rows at the bottom edge of the grid.

#### Defined in

[grid/gridoptions.ts:199](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L199)

***

### frozenColumns?

> `optional` **frozenColumns**: `number`

Defaults to `undefined`. If specified, freezes the given number of columns on the left edge of the grid.
Prefer setting column.frozen = 'true' for individual columns as this is only for compatibility.

#### Defined in

[grid/gridoptions.ts:205](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L205)

***

### frozenRows?

> `optional` **frozenRows**: `number`

Defaults to `undefined`. If specified, freezes the given number of rows at the top or bottom
edge of the grid based on `frozenBottom`.

#### Defined in

[grid/gridoptions.ts:211](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L211)

***

### fullWidthRows?

> `optional` **fullWidthRows**: `boolean`

Defaults to `false`. If `true`, makes rows take the full width of the grid.

#### Defined in

[grid/gridoptions.ts:216](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L216)

***

### groupingPanel?

> `optional` **groupingPanel**: `boolean`

Defaults to `false`. If `true`, shows the grouping panel for grouping columns.

#### Defined in

[grid/gridoptions.ts:221](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L221)

***

### groupingPanelHeight?

> `optional` **groupingPanelHeight**: `number`

Defaults to `30`. Height of the grouping panel in pixels.

#### Defined in

[grid/gridoptions.ts:226](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L226)

***

### groupTotalsFormatter()?

> `optional` **groupTotalsFormatter**: (`p1`?, `p2`?, `grid`?) => `string`

Function to format group totals for display in the grouping panel.

#### Parameters

##### p1?

[`GroupTotals`](../classes/GroupTotals.md)\<`TItem`\>

##### p2?

[`Column`](Column.md)\<`TItem`\>

##### grid?

`any`

#### Returns

`string`

#### Defined in

[grid/gridoptions.ts:231](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L231)

***

### headerRowHeight?

> `optional` **headerRowHeight**: `number`

Defaults to `30`. Height of the header row in pixels.

#### Defined in

[grid/gridoptions.ts:236](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L236)

***

### jQuery?

> `optional` **jQuery**: `object`

jQuery object for compatibility or custom integration purposes. Default is `undefined` unless jQuery is available in the global object (e.g. window).

#### fn

> **fn**: `any`

#### ready

> **ready**: `any`

#### Defined in

[grid/gridoptions.ts:241](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L241)

***

### layoutEngine?

> `optional` **layoutEngine**: [`LayoutEngine`](LayoutEngine.md)

Layout engine for custom grid layouts. Default is `BasicLayout`. Use FrozenLayout to enable frozen columns / rows.

#### Defined in

[grid/gridoptions.ts:251](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L251)

***

### leaveSpaceForNewRows?

> `optional` **leaveSpaceForNewRows**: `boolean`

Defaults to `false`. If `true`, leaves space for new rows in the DOM visible buffer.

#### Defined in

[grid/gridoptions.ts:246](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L246)

***

### minBuffer?

> `optional` **minBuffer**: `number`

Defaults to `3`. Minimum number of rows to keep in the buffer.

#### Defined in

[grid/gridoptions.ts:256](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L256)

***

### multiColumnSort?

> `optional` **multiColumnSort**: `boolean`

Defaults to `false`. If `true`, allows sorting by multiple columns simultaneously.

#### Defined in

[grid/gridoptions.ts:261](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L261)

***

### multiSelect?

> `optional` **multiSelect**: `boolean`

Defaults to `true`. If `true`, enables multiple cell selection.

#### Defined in

[grid/gridoptions.ts:266](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L266)

***

### preHeaderPanelHeight?

> `optional` **preHeaderPanelHeight**: `number`

Sets grouping panel height. Default is `undefined`, e.g. it is set via CSS.

#### Defined in

[grid/gridoptions.ts:271](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L271)

***

### removeNode()?

> `optional` **removeNode**: (`node`) => `void`

Function to handle removing a DOM node, used for custom cleanup logic. Default is `null` or jQuery.remove if available.

#### Parameters

##### node

`Element`

#### Returns

`void`

#### Defined in

[grid/gridoptions.ts:289](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L289)

***

### renderAllCells?

> `optional` **renderAllCells**: `boolean`

Defaults to `false`. If `true`, renders all cells (row columns) in the viewport, at the cost of higher memory usage and reduced performance.

#### Defined in

[grid/gridoptions.ts:276](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L276)

***

### renderAllRows?

> `optional` **renderAllRows**: `boolean`

Defaults to `false`. If `true`, renders all rows in the viewport, at the cost of higher memory usage and reduced performance.
When both renderAllCells and renderAllRows are true, all cells in the grid are rendered (e.g. virtualization is disabled),
which can be very slow for large datasets, but may be desired to keep all rows and cells in the DOM for accessibility purposes,
proper tabbing and screen reader support.

#### Defined in

[grid/gridoptions.ts:284](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L284)

***

### rowHeight?

> `optional` **rowHeight**: `number`

Defaults to `30`. Height of rows in pixels.

#### Defined in

[grid/gridoptions.ts:294](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L294)

***

### rtl?

> `optional` **rtl**: `boolean`

Default is based on document element's (`<html/>`) `dir` property.. If `true`, enables right-to-left text direction.

#### Defined in

[grid/gridoptions.ts:299](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L299)

***

### sanitizer()?

> `optional` **sanitizer**: (`dirtyHtml`) => `string`

Optional function for sanitizing HTML strings to avoid XSS attacks.
Default is `DOMPurify.sanitize` if available globally, otherwise falls back to `basicRegexSanitizer`.

#### Parameters

##### dirtyHtml

`string`

#### Returns

`string`

#### Defined in

[grid/gridoptions.ts:305](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L305)

***

### selectedCellCssClass?

> `optional` **selectedCellCssClass**: `string`

CSS class applied to selected cells. Default is `"selected"`.

#### Defined in

[grid/gridoptions.ts:310](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L310)

***

### showCellSelection?

> `optional` **showCellSelection**: `boolean`

Defaults to `true`. If `true`, shows cell selection indicators.

#### Defined in

[grid/gridoptions.ts:315](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L315)

***

### showColumnHeader?

> `optional` **showColumnHeader**: `boolean`

Defaults to `true`. If `true`, displays the column header.

#### Defined in

[grid/gridoptions.ts:320](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L320)

***

### showFooterRow?

> `optional` **showFooterRow**: `boolean`

Defaults to `false`. If `true`, displays the footer row.

#### Defined in

[grid/gridoptions.ts:325](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L325)

***

### showGroupingPanel?

> `optional` **showGroupingPanel**: `boolean`

Defaults to `true`. If `true`, displays the grouping panel.

#### Defined in

[grid/gridoptions.ts:330](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L330)

***

### showHeaderRow?

> `optional` **showHeaderRow**: `boolean`

Defaults to `false`. If `true`, displays the header row.

#### Defined in

[grid/gridoptions.ts:335](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L335)

***

### showPreHeaderPanel?

> `optional` **showPreHeaderPanel**: `boolean`

Defaults to `false`. If `true`, displays the pre-header panel for column grouping.

#### Defined in

[grid/gridoptions.ts:340](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L340)

***

### showTopPanel?

> `optional` **showTopPanel**: `boolean`

Defaults to `false`. If `true`, displays the top panel for additional controls or information.

#### Defined in

[grid/gridoptions.ts:345](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L345)

***

### suppressActiveCellChangeOnEdit?

> `optional` **suppressActiveCellChangeOnEdit**: `boolean`

Defaults to `false`. If `true`, suppresses the activation of cells when they contain an editor and are clicked.

#### Defined in

[grid/gridoptions.ts:350](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L350)

***

### syncColumnCellResize?

> `optional` **syncColumnCellResize**: `boolean`

Defaults to `false`. If `true`, synchronizes column resizing with cell resizing.

#### Defined in

[grid/gridoptions.ts:355](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L355)

***

### topPanelHeight?

> `optional` **topPanelHeight**: `number`

Defaults to `30`. Height of the top panel in pixels.

#### Defined in

[grid/gridoptions.ts:360](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L360)

***

### useCssVars?

> `optional` **useCssVars**: `boolean`

Defaults to `false`. If `true`, uses CSS variables for styling.

#### Defined in

[grid/gridoptions.ts:370](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L370)

***

### useLegacyUI?

> `optional` **useLegacyUI**: `boolean`

Defaults to `false`. If `true`, uses legacy jQuery UI classes like ui-state-default and ui-widget-content.

#### Defined in

[grid/gridoptions.ts:365](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L365)

***

### viewportClass?

> `optional` **viewportClass**: `string`

CSS class applied to the viewport container. Default is `undefined`.

#### Defined in

[grid/gridoptions.ts:375](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/gridoptions.ts#L375)
