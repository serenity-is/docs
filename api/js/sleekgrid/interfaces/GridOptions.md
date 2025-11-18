[@serenity-is/sleekgrid](../README.md) / GridOptions

# Interface: GridOptions\<TItem\>

Defined in: [src/core/gridoptions.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L13)

Configuration options for the SleekGrid component.

## Type Parameters

### TItem

`TItem` = `any`

The type of items in the grid.

## Properties

### addNewRowCssClass?

> `optional` **addNewRowCssClass**: `string`

Defined in: [src/core/gridoptions.ts:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L17)

CSS class applied to newly added rows for custom styling. Default is `"new-row"`.

***

### alwaysAllowHorizontalScroll?

> `optional` **alwaysAllowHorizontalScroll**: `boolean`

Defined in: [src/core/gridoptions.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L22)

Defaults to `false`. If `true`, a horizontal scrollbar is always visible regardless of content width.

***

### alwaysShowVerticalScroll?

> `optional` **alwaysShowVerticalScroll**: `boolean`

Defined in: [src/core/gridoptions.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L27)

Defaults to `false`. If `true`, a vertical scrollbar is always visible, useful for fixed-height grids or menus.

***

### asyncEditorLoadDelay?

> `optional` **asyncEditorLoadDelay**: `number`

Defined in: [src/core/gridoptions.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L32)

Defaults to `100`. Delay in milliseconds before asynchronous loading of editors.

***

### asyncEditorLoading?

> `optional` **asyncEditorLoading**: `boolean`

Defined in: [src/core/gridoptions.ts:37](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L37)

Defaults to `false`. If `true`, editors are loaded asynchronously, reducing initial rendering load.

***

### asyncPostCleanupDelay?

> `optional` **asyncPostCleanupDelay**: `number`

Defined in: [src/core/gridoptions.ts:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L42)

Defaults to `40`. Delay in milliseconds before cleaning up post-rendered elements.

***

### asyncPostRenderDelay?

> `optional` **asyncPostRenderDelay**: `number`

Defined in: [src/core/gridoptions.ts:47](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L47)

Defaults to `-1` which means immediate execution. Delay in milliseconds before starting asynchronous post-rendering.

***

### autoEdit?

> `optional` **autoEdit**: `boolean`

Defined in: [src/core/gridoptions.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L52)

Defaults to `true`. If `true`, automatically opens the cell editor when a cell gains focus.

***

### autoHeight?

> `optional` **autoHeight**: `boolean`

Defined in: [src/core/gridoptions.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L57)

Defaults to `false`. If `true`, automatically adjusts the grid's height to fit the entire content without scrolling.

***

### cellFlashingCssClass?

> `optional` **cellFlashingCssClass**: `string`

Defined in: [src/core/gridoptions.ts:62](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L62)

CSS class applied to cells with a flashing effect. Default is `"flashing"`.

***

### columns?

> `optional` **columns**: [`Column`](Column.md)\<`TItem`\>[]

Defined in: [src/core/gridoptions.ts:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L72)

Array of column definitions for the grid.

***

### ~~createPreHeaderPanel?~~

> `optional` **createPreHeaderPanel**: `boolean`

Defined in: [src/core/gridoptions.ts:77](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L77)

#### Deprecated

Use showGroupingPanel option instead.

***

### dataItemColumnValueExtractor()?

> `optional` **dataItemColumnValueExtractor**: (`item`, `column`) => `void`

Defined in: [src/core/gridoptions.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L82)

Function to extract column values from data items, used for custom copy buffer operations. Default is `null`.

#### Parameters

##### item

`TItem`

##### column

[`Column`](Column.md)\<`TItem`\>

#### Returns

`void`

***

### defaultColumnWidth?

> `optional` **defaultColumnWidth**: `number`

Defined in: [src/core/gridoptions.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L87)

Defaults to `80`. Default width of columns in pixels.

***

### defaultFormat?

> `optional` **defaultFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/gridoptions.ts:92](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L92)

Default formatting options for columns. Default is `defaultColumnFormat`.

***

### defaultFormatter?

> `optional` **defaultFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<`TItem`\>

Defined in: [src/core/gridoptions.ts:97](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L97)

Default formatter function for cells.

***

### editable?

> `optional` **editable**: `boolean`

Defined in: [src/core/gridoptions.ts:102](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L102)

Defaults to `false`. If `true`, cells can be edited inline.

***

### editCommandHandler()?

> `optional` **editCommandHandler**: (`item`, `column`, `command`) => `void`

Defined in: [src/core/gridoptions.ts:107](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L107)

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

***

### editorCellNavOnLRKeys?

> `optional` **editorCellNavOnLRKeys**: `boolean`

Defined in: [src/core/gridoptions.ts:112](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L112)

Defaults to `false`. If `true`, enables navigation between cells using left and right arrow keys within the editor.

***

### editorFactory?

> `optional` **editorFactory**: [`EditorFactory`](EditorFactory.md)

Defined in: [src/core/gridoptions.ts:117](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L117)

Factory function for creating custom editors. Default is `null`.

***

### editorLock?

> `optional` **editorLock**: [`EditorLock`](../classes/EditorLock.md)

Defined in: [src/core/gridoptions.ts:122](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L122)

Global editor lock instance, used for managing concurrent editor access. Default is `GlobalEditorLock`.

***

### emptyNode()?

> `optional` **emptyNode**: (`node`) => `void`

Defined in: [src/core/gridoptions.ts:67](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L67)

Function to handle clearing a DOM node, used for custom cleanup logic. Default is `null`.

#### Parameters

##### node

`Element`

#### Returns

`void`

***

### enableAddRow?

> `optional` **enableAddRow**: `boolean`

Defined in: [src/core/gridoptions.ts:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L127)

Defaults to `false`. If `true`, enables the ability to add new rows to the grid.

***

### enableAsyncPostRender?

> `optional` **enableAsyncPostRender**: `boolean`

Defined in: [src/core/gridoptions.ts:132](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L132)

Defaults to `false`. If `true`, enables asynchronous post-rendering.

***

### enableAsyncPostRenderCleanup?

> `optional` **enableAsyncPostRenderCleanup**: `boolean`

Defined in: [src/core/gridoptions.ts:137](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L137)

Defaults to `false`. If `true`, enables cleanup after asynchronous post-rendering.

***

### enableCellNavigation?

> `optional` **enableCellNavigation**: `boolean`

Defined in: [src/core/gridoptions.ts:142](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L142)

Defaults to `true`. If `true`, enables cell navigation with arrow keys.

***

### enableCellRangeSelection?

> `optional` **enableCellRangeSelection**: `boolean`

Defined in: [src/core/gridoptions.ts:147](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L147)

Defaults to `false`. If `true`, allows selection of cell ranges.

***

### enableColumnReorder?

> `optional` **enableColumnReorder**: `boolean`

Defined in: [src/core/gridoptions.ts:152](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L152)

Defaults to `true`. If `true`, enables column reordering.

***

### enableHtmlRendering?

> `optional` **enableHtmlRendering**: `boolean`

Defined in: [src/core/gridoptions.ts:158](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L158)

Allow returning raw HTML strings from formatters and use `innerHTML` to render them. Defaults to `false` for tighter security.
It is recommended to leave this as `false` for better security and to avoid XSS vulnerabilities. In that case, formatters should return plain text or DOM elements.

***

### enableRowReordering?

> `optional` **enableRowReordering**: `boolean`

Defined in: [src/core/gridoptions.ts:163](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L163)

Defaults to `false`. If `true`, enables row reordering.

***

### enableTabKeyNavigation?

> `optional` **enableTabKeyNavigation**: `boolean`

Defined in: [src/core/gridoptions.ts:168](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L168)

Defaults to `true`. If `true`, enables navigation between cells using the Tab key.

***

### enableTextSelectionOnCells?

> `optional` **enableTextSelectionOnCells**: `boolean`

Defined in: [src/core/gridoptions.ts:173](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L173)

Defaults to `false`. If `true`, enables text selection within cells.

***

### explicitInitialization?

> `optional` **explicitInitialization**: `boolean`

Defined in: [src/core/gridoptions.ts:178](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L178)

Defaults to `false`. If `true`, requires explicit initialization of the grid.

***

### footerRowHeight?

> `optional` **footerRowHeight**: `number`

Defined in: [src/core/gridoptions.ts:183](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L183)

Defaults to null which means the footer row height is calculated based on CSS rules.

***

### forceFitColumns?

> `optional` **forceFitColumns**: `boolean`

Defined in: [src/core/gridoptions.ts:188](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L188)

Defaults to `false`. If `true`, forces columns to fit the grid width.

***

### forceSyncScrolling?

> `optional` **forceSyncScrolling**: `boolean`

Defined in: [src/core/gridoptions.ts:193](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L193)

Defaults to `false`. If `true`, synchronizes scrolling between the grid and its container.

***

### forceSyncScrollInterval?

> `optional` **forceSyncScrollInterval**: `number`

Defined in: [src/core/gridoptions.ts:198](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L198)

Defaults to `250`. Interval in milliseconds for synchronizing scrolling when `forceSyncScrolling` is enabled.

***

### formatterFactory?

> `optional` **formatterFactory**: [`FormatterFactory`](FormatterFactory.md)

Defined in: [src/core/gridoptions.ts:203](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L203)

Factory function for creating custom formatters. Default is `null`.

***

### frozenBottom?

> `optional` **frozenBottom**: `number` \| `boolean`

Defined in: [src/core/gridoptions.ts:208](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L208)

Defaults to `false`. If `true`, places frozen rows at the bottom edge of the grid.

***

### frozenColumns?

> `optional` **frozenColumns**: `number`

Defined in: [src/core/gridoptions.ts:214](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L214)

Defaults to `undefined`. If specified, freezes the given number of columns on the left edge of the grid.
Prefer setting column.frozen = 'true' for individual columns as this is only for compatibility.

***

### frozenRows?

> `optional` **frozenRows**: `number`

Defined in: [src/core/gridoptions.ts:220](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L220)

Defaults to `undefined`. If specified, freezes the given number of rows at the top or bottom
edge (if frozenBottom === true).

***

### fullWidthRows?

> `optional` **fullWidthRows**: `boolean`

Defined in: [src/core/gridoptions.ts:225](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L225)

Defaults to `false`. If `true`, makes rows take the full width of the grid.

***

### groupingPanel?

> `optional` **groupingPanel**: `boolean`

Defined in: [src/core/gridoptions.ts:230](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L230)

Defaults to `false`. If `true`, shows the grouping panel for grouping columns.

***

### groupingPanelHeight?

> `optional` **groupingPanelHeight**: `number`

Defined in: [src/core/gridoptions.ts:235](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L235)

Defaults to null, e.g. calculated based on CSS. Height of the grouping panel in pixels.

***

### groupTotalsFormat()?

> `optional` **groupTotalsFormat**: (`ctx`) => [`FormatterResult`](../type-aliases/FormatterResult.md)

Defined in: [src/core/gridoptions.ts:240](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L240)

Function to format group totals for display in the grouping panel.

#### Parameters

##### ctx

[`FormatterContext`](FormatterContext.md)\<[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>\>

#### Returns

[`FormatterResult`](../type-aliases/FormatterResult.md)

***

### ~~groupTotalsFormatter()?~~

> `optional` **groupTotalsFormatter**: (`totals?`, `column?`, `grid?`) => `string`

Defined in: [src/core/gridoptions.ts:246](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L246)

Function to format group totals for display in the grouping panel.

#### Parameters

##### totals?

[`IGroupTotals`](IGroupTotals.md)\<`TItem`\>

##### column?

[`Column`](Column.md)\<`TItem`\>

##### grid?

[`ISleekGrid`](ISleekGrid.md)

#### Returns

`string`

#### Deprecated

Use `groupTotalsFormat` with `FormatterContext<IGroupTotals>` signature instead.

***

### headerRowHeight?

> `optional` **headerRowHeight**: `number`

Defined in: [src/core/gridoptions.ts:251](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L251)

Defaults to null, e.g. calculated based on CSS. Height of the header row in pixels.

***

### jQuery?

> `optional` **jQuery**: `object`

Defined in: [src/core/gridoptions.ts:256](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L256)

jQuery object for compatibility or custom integration purposes. Default is `undefined` unless jQuery is available in the global object (e.g. window).

#### fn

> **fn**: `any`

#### ready

> **ready**: `any`

***

### layoutEngine?

> `optional` **layoutEngine**: [`LayoutEngine`](LayoutEngine.md) \| () => [`LayoutEngine`](LayoutEngine.md)

Defined in: [src/core/gridoptions.ts:266](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L266)

Layout engine for custom grid layouts. Default is `BasicLayout`. Use FrozenLayout to enable frozen columns / rows.

***

### leaveSpaceForNewRows?

> `optional` **leaveSpaceForNewRows**: `boolean`

Defined in: [src/core/gridoptions.ts:261](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L261)

Defaults to `false`. If `true`, leaves space for new rows in the DOM visible buffer.

***

### minBuffer?

> `optional` **minBuffer**: `number`

Defined in: [src/core/gridoptions.ts:271](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L271)

Defaults to `3`. Minimum number of rows to keep in the buffer.

***

### multiColumnSort?

> `optional` **multiColumnSort**: `boolean`

Defined in: [src/core/gridoptions.ts:276](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L276)

Defaults to `false`. If `true`, allows sorting by multiple columns simultaneously.

***

### multiSelect?

> `optional` **multiSelect**: `boolean`

Defined in: [src/core/gridoptions.ts:281](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L281)

Defaults to `true`. If `true`, enables multiple cell selection.

***

### ~~preHeaderPanelHeight?~~

> `optional` **preHeaderPanelHeight**: `number`

Defined in: [src/core/gridoptions.ts:286](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L286)

#### Deprecated

Use groupingPanelHeight option instead.

***

### removeNode()?

> `optional` **removeNode**: (`node`) => `void`

Defined in: [src/core/gridoptions.ts:304](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L304)

Function to handle removing a DOM node, used for custom cleanup logic. Default is `null` or jQuery.remove if available.

#### Parameters

##### node

`Element`

#### Returns

`void`

***

### renderAllCells?

> `optional` **renderAllCells**: `boolean`

Defined in: [src/core/gridoptions.ts:291](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L291)

Defaults to `false`. If `true`, renders all cells (row columns) in the viewport, at the cost of higher memory usage and reduced performance.

***

### renderAllRows?

> `optional` **renderAllRows**: `boolean`

Defined in: [src/core/gridoptions.ts:299](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L299)

Defaults to `false`. If `true`, renders all rows in the viewport, at the cost of higher memory usage and reduced performance.
When both renderAllCells and renderAllRows are true, all cells in the grid are rendered (e.g. virtualization is disabled),
which can be very slow for large datasets, but may be desired to keep all rows and cells in the DOM for accessibility purposes,
proper tabbing and screen reader support.

***

### rowHeight?

> `optional` **rowHeight**: `number`

Defined in: [src/core/gridoptions.ts:309](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L309)

Defaults to `30`. Height of rows in pixels.

***

### rtl?

> `optional` **rtl**: `boolean`

Defined in: [src/core/gridoptions.ts:314](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L314)

Default is based on document element's (`<html/>`) `dir` property.. If `true`, enables right-to-left text direction.

***

### sanitizer()?

> `optional` **sanitizer**: (`dirtyHtml`) => `string`

Defined in: [src/core/gridoptions.ts:320](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L320)

Optional function for sanitizing HTML strings to avoid XSS attacks.
Default is `DOMPurify.sanitize` if available globally, otherwise falls back to `basicDOMSanitizer`.

#### Parameters

##### dirtyHtml

`string`

#### Returns

`string`

***

### selectedCellCssClass?

> `optional` **selectedCellCssClass**: `string`

Defined in: [src/core/gridoptions.ts:325](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L325)

CSS class applied to selected cells. Default is `"selected"`.

***

### showCellSelection?

> `optional` **showCellSelection**: `boolean`

Defined in: [src/core/gridoptions.ts:330](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L330)

Defaults to `true`. If `true`, shows cell selection indicators.

***

### showColumnHeader?

> `optional` **showColumnHeader**: `boolean`

Defined in: [src/core/gridoptions.ts:335](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L335)

Defaults to `true`. If `true`, displays the column header.

***

### showFooterRow?

> `optional` **showFooterRow**: `boolean`

Defined in: [src/core/gridoptions.ts:340](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L340)

Defaults to `false`. If `true`, displays the footer row.

***

### showGroupingPanel?

> `optional` **showGroupingPanel**: `boolean`

Defined in: [src/core/gridoptions.ts:345](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L345)

Defaults to `false`. If `true`, displays the grouping panel.

***

### showHeaderRow?

> `optional` **showHeaderRow**: `boolean`

Defined in: [src/core/gridoptions.ts:350](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L350)

Defaults to `false`. If `true`, displays the header row.

***

### ~~showPreHeaderPanel?~~

> `optional` **showPreHeaderPanel**: `boolean`

Defined in: [src/core/gridoptions.ts:355](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L355)

#### Deprecated

Use showGroupingPanel option instead.

***

### showTopPanel?

> `optional` **showTopPanel**: `boolean`

Defined in: [src/core/gridoptions.ts:360](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L360)

Defaults to `false`. If `true`, displays the post-header panel for additional controls or information.

***

### suppressActiveCellChangeOnEdit?

> `optional` **suppressActiveCellChangeOnEdit**: `boolean`

Defined in: [src/core/gridoptions.ts:365](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L365)

Defaults to `false`. If `true`, suppresses the activation of cells when they contain an editor and are clicked.

***

### syncColumnCellResize?

> `optional` **syncColumnCellResize**: `boolean`

Defined in: [src/core/gridoptions.ts:370](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L370)

Defaults to `false`. If `true`, synchronizes column resizing with cell resizing.

***

### topPanelHeight?

> `optional` **topPanelHeight**: `number`

Defined in: [src/core/gridoptions.ts:375](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L375)

Defaults to null which means the top panel height is calculated based on CSS rules.

***

### useCssVars?

> `optional` **useCssVars**: `number` \| `boolean`

Defined in: [src/core/gridoptions.ts:388](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L388)

Defaults to `true` which is equivalent to 50. If `true`, uses CSS variables for styling (for up to 50 cols).
If set to a number, enables CSS variables only if column count is less than or equal to that number.
This is dependent on the stylesheet which only supports up to 50 columns by default.
But if you defined your own stylesheet with more columns, you can set this to a higher number.

***

### ~~useLegacyUI?~~

> `optional` **useLegacyUI**: `boolean`

Defined in: [src/core/gridoptions.ts:380](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L380)

#### Deprecated

This option has no effect.

***

### viewportClass?

> `optional` **viewportClass**: `string`

Defined in: [src/core/gridoptions.ts:393](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/gridoptions.ts#L393)

CSS class applied to the viewport container. Default is `undefined`.
