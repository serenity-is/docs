[@serenity-is/sleekgrid](../README.md) / ISleekGrid

# Interface: ISleekGrid\<TItem\>

Defined in: [src/core/isleekgrid.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L16)

Full grid surface exposed to plugins, editors and external code.

## Extends

- [`CellNavigation`](CellNavigation.md).[`EditorHost`](EditorHost.md).[`GridPluginHost`](GridPluginHost.md)

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Properties

### onActiveCellChanged

> `readonly` **onActiveCellChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md)\>

Defined in: [src/core/isleekgrid.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L18)

Fired when the active cell changes. [ArgsCell](ArgsCell.md) payload.

***

### onActiveCellPositionChanged

> `readonly` **onActiveCellPositionChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L20)

Fired when the active cell's pixel position changes (e.g. after scrolling). [ArgsGrid](ArgsGrid.md) payload.

***

### onAddNewRow

> `readonly` **onAddNewRow**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsAddNewRow`](ArgsAddNewRow.md)\>

Defined in: [src/core/isleekgrid.ts:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L22)

Fired when a new row is about to be added via the add-new-row row. [ArgsAddNewRow](ArgsAddNewRow.md) payload.

***

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L24)

Fired once after `init()` completes. [ArgsGrid](ArgsGrid.md) payload.

***

### onBeforeCellEditorDestroy

> `readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsEditorDestroy`](ArgsEditorDestroy.md)\>

Defined in: [src/core/isleekgrid.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L26)

Fired before a cell editor is destroyed; allows handlers to intercept. [ArgsEditorDestroy](ArgsEditorDestroy.md) payload.

***

### onBeforeDestroy

> `readonly` **onBeforeDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L28)

Fired before the grid is destroyed. [ArgsGrid](ArgsGrid.md) payload.

***

### onBeforeEditCell

> `readonly` **onBeforeEditCell**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCellEdit`](ArgsCellEdit.md)\>

Defined in: [src/core/isleekgrid.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L30)

Fired before a cell enters edit mode; cancel with `e.preventDefault()`. [ArgsCellEdit](ArgsCellEdit.md) payload.

***

### onBeforeFooterRowCellDestroy

> `readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L32)

Fired before a footer row cell is destroyed. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onBeforeHeaderCellDestroy

> `readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L34)

Fired before a header cell is destroyed. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onBeforeHeaderRowCellDestroy

> `readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L36)

Fired before a header-row (filter) cell is destroyed. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onCellChange

> `readonly` **onCellChange**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCellChange`](ArgsCellChange.md)\>

Defined in: [src/core/isleekgrid.ts:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L38)

Fired after a cell value has changed and been committed. [ArgsCellChange](ArgsCellChange.md) payload.

***

### onCellCssStylesChanged

> `readonly` **onCellCssStylesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCssStyle`](ArgsCssStyle.md)\>

Defined in: [src/core/isleekgrid.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L40)

Fired when per-cell CSS styles change. [ArgsCssStyle](ArgsCssStyle.md) payload.

***

### onClick

> `readonly` **onClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L42)

Click on a body cell. [ArgsCell](ArgsCell.md), native `MouseEvent`.

***

### onColumnsReordered

> `readonly` **onColumnsReordered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L44)

Fired after columns are reordered. [ArgsGrid](ArgsGrid.md) payload.

***

### onColumnsResized

> `readonly` **onColumnsResized**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L46)

Fired after columns are resized. [ArgsGrid](ArgsGrid.md) payload.

***

### onCompositeEditorChange

> **onCompositeEditorChange**: [`EventEmitter`](../classes/EventEmitter.md)\<`any`\>

Defined in: [src/core/editing.ts:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L55)

Emits when a composite-editor field value changes; editors forward changes through this.

#### Inherited from

[`EditorHost`](EditorHost.md).[`onCompositeEditorChange`](EditorHost.md#oncompositeeditorchange)

***

### onContextMenu

> `readonly` **onContextMenu**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L48)

Context-menu event on the grid canvas. [ArgsGrid](ArgsGrid.md), native `UIEvent`.

***

### onDblClick

> `readonly` **onDblClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L50)

Double-click on a body cell. [ArgsCell](ArgsCell.md), native `MouseEvent`.

***

### onDrag

> `readonly` **onDrag**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L52)

Ongoing drag within the grid. [ArgsDrag](ArgsDrag.md), native `UIEvent`.

***

### onDragEnd

> `readonly` **onDragEnd**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L54)

Drag finished. [ArgsDrag](ArgsDrag.md), native `UIEvent`.

***

### onDragInit

> `readonly` **onDragInit**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:56](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L56)

Drag initialized (mousedown on a draggable surface). [ArgsDrag](ArgsDrag.md), native `UIEvent`.

***

### onDragStart

> `readonly` **onDragStart**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsDrag`](ArgsDrag.md), `UIEvent`\>

Defined in: [src/core/isleekgrid.ts:58](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L58)

Drag started (after minimum movement threshold). [ArgsDrag](ArgsDrag.md), native `UIEvent`.

***

### onFooterRowCellRendered

> `readonly` **onFooterRowCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L60)

Fired after a footer row cell is rendered. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onHeaderCellRendered

> `readonly` **onHeaderCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:62](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L62)

Fired after a header cell is rendered. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onHeaderClick

> `readonly` **onHeaderClick**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L64)

Click on a header cell. [ArgsColumn](ArgsColumn.md), native `MouseEvent`.

***

### onHeaderContextMenu

> `readonly` **onHeaderContextMenu**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L66)

Context menu on a header cell. [ArgsColumn](ArgsColumn.md), native `MouseEvent`.

***

### onHeaderMouseEnter

> `readonly` **onHeaderMouseEnter**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:68](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L68)

Pointer entered a header cell. [ArgsColumn](ArgsColumn.md), native `MouseEvent`.

***

### onHeaderMouseLeave

> `readonly` **onHeaderMouseLeave**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumn`](ArgsColumn.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L70)

Pointer left a header cell. [ArgsColumn](ArgsColumn.md), native `MouseEvent`.

***

### onHeaderRowCellRendered

> `readonly` **onHeaderRowCellRendered**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsColumnNode`](ArgsColumnNode.md)\>

Defined in: [src/core/isleekgrid.ts:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L72)

Fired after a header-row (filter) cell is rendered. [ArgsColumnNode](ArgsColumnNode.md) payload.

***

### onKeyDown

> `readonly` **onKeyDown**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsCell`](ArgsCell.md), `KeyboardEvent`\>

Defined in: [src/core/isleekgrid.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L74)

Key down while a body cell is active. [ArgsCell](ArgsCell.md), native `KeyboardEvent`.

***

### onMouseEnter

> `readonly` **onMouseEnter**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:76](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L76)

Pointer entered the grid. [ArgsGrid](ArgsGrid.md), native `MouseEvent`.

***

### onMouseLeave

> `readonly` **onMouseLeave**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md), `MouseEvent`\>

Defined in: [src/core/isleekgrid.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L78)

Pointer left the grid. [ArgsGrid](ArgsGrid.md), native `MouseEvent`.

***

### onScroll

> `readonly` **onScroll**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsScroll`](ArgsScroll.md)\>

Defined in: [src/core/isleekgrid.ts:80](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L80)

Grid scrolled. [ArgsScroll](ArgsScroll.md) payload.

***

### onSelectedRowsChanged

> `readonly` **onSelectedRowsChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsSelectedRowsChange`](ArgsSelectedRowsChange.md)\>

Defined in: [src/core/isleekgrid.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L82)

Selected rows changed. [ArgsSelectedRowsChange](ArgsSelectedRowsChange.md) payload.

***

### onSort

> `readonly` **onSort**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsSort`](ArgsSort.md)\>

Defined in: [src/core/isleekgrid.ts:84](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L84)

Sorted columns changed. [ArgsSort](ArgsSort.md) payload.

***

### onValidationError

> `readonly` **onValidationError**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsValidationError`](ArgsValidationError.md)\>

Defined in: [src/core/isleekgrid.ts:86](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L86)

Editor validation failed. [ArgsValidationError](ArgsValidationError.md) payload.

***

### onViewportChanged

> `readonly` **onViewportChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`ArgsGrid`](ArgsGrid.md)\>

Defined in: [src/core/isleekgrid.ts:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L88)

Visible viewport changed (scroll or resize). [ArgsGrid](ArgsGrid.md) payload.

***

### render()

> **render**: () => `void`

Defined in: [src/core/isleekgrid.ts:399](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L399)

Immediately renders the grid (row/cell DOM), synchronizing canvases and headers.
Usually called internally via `invalidate()` + animation frame; call manually after batch updates.

#### Returns

`void`

***

### resizeCanvas()

> **resizeCanvas**: () => `void`

Defined in: [src/core/isleekgrid.ts:412](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L412)

Recalculates canvas/viewport sizes and re-renders headers and rows. Call after external
container resize when `autoHeight` is off.

#### Returns

`void`

## Methods

### addCellCssStyles()

> **addCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/core/isleekgrid.ts:99](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L99)

Adds per-cell CSS styles under the given key; multiple callers can coexist via different keys.

#### Parameters

##### key

`string`

Bucket name to group styles so callers can later remove only their own styles.

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

Map of `row -> columnId -> cssClass`.

#### Returns

`void`

***

### autosizeColumns()

> **autosizeColumns**(): `void`

Defined in: [src/core/isleekgrid.ts:103](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L103)

Auto-sizes columns to fit the container width, honouring `minWidth`/`maxWidth` and `forceFitColumns`.

#### Returns

`void`

***

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/core/isleekgrid.ts:108](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L108)

Cancels the current cell edit without saving.

#### Returns

`boolean`

`true` if cancelled (or no edit was active).

***

### canCellBeActive()

> **canCellBeActive**(`row`, `cell`, `tab?`): `boolean`

Defined in: [src/core/isleekgrid.ts:116](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L116)

Checks whether a cell can become the active cell (focusable and selectable).

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

##### tab?

`boolean`

Whether the check is for tab navigation (affects `tabbable` handling).

#### Returns

`boolean`

`true` if the cell may become active.

***

### canCellBeSelected()

> **canCellBeSelected**(`row`, `cell`): `boolean`

Defined in: [src/core/isleekgrid.ts:123](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L123)

Checks whether a cell may be selected.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

`boolean`

`true` if the cell is selectable.

***

### clearTextSelection()

> **clearTextSelection**(): `void`

Defined in: [src/core/isleekgrid.ts:125](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L125)

Clears any browser text selection within the grid.

#### Returns

`void`

***

### columnsResized()

> **columnsResized**(`invalidate?`): `void`

Defined in: [src/core/isleekgrid.ts:130](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L130)

Notifies the grid that column sizes have changed externally.

#### Parameters

##### invalidate?

`boolean`

Whether to invalidate and re-render visible rows (default `true` behaviour).

#### Returns

`void`

***

### commitCurrentEdit()

> **commitCurrentEdit**(`opt?`): `boolean`

Defined in: [src/core/isleekgrid.ts:136](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L136)

Commits the current edit, running validation.

#### Parameters

##### opt?

Options; set `{ forceValueChange: true }` to force `onCellChange` even when the value did not appear to change.

###### forceValueChange?

`boolean`

#### Returns

`boolean`

`true` if committed (or no edit was active), `false` if validation failed.

***

### destroy()

> **destroy**(): `void`

Defined in: [src/core/isleekgrid.ts:138](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L138)

Destroys the grid, removing DOM and event listeners.

#### Returns

`void`

***

### editActiveCell()

> **editActiveCell**(`editor?`): `void`

Defined in: [src/core/isleekgrid.ts:143](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L143)

Activates the editor on the currently active cell.

#### Parameters

##### editor?

[`EditorClass`](EditorClass.md)

Optional editor class override; defaults to the column's editor.

#### Returns

`void`

***

### flashCell()

> **flashCell**(`row`, `cell`, `speed?`): `void`

Defined in: [src/core/isleekgrid.ts:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L150)

Flashes a cell briefly for visual feedback (e.g. successful update).

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

##### speed?

`number`

Flash duration in milliseconds; defaults to grid's configured speed.

#### Returns

`void`

***

### focus()

> **focus**(): `void`

Defined in: [src/core/isleekgrid.ts:154](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L154)

Focuses the grid's viewport so keyboard navigation works.

#### Returns

`void`

***

### getAbsoluteColumnMinWidth()

> **getAbsoluteColumnMinWidth**(): `number`

Defined in: [src/core/isleekgrid.ts:156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L156)

Returns the minimum allowed column width, considering absolute minima.

#### Returns

`number`

***

### getActiveCanvasNode()

> **getActiveCanvasNode**(`e?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:161](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L161)

Gets the scrollable canvas node that is active for the given event target.

#### Parameters

##### e?

Optional event target hint for viewport disambiguation.

###### target

`EventTarget`

#### Returns

`HTMLElement`

***

### getActiveCell()

> **getActiveCell**(): [`RowCell`](RowCell.md)

Defined in: [src/core/editing.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L49)

Returns the currently active cell, or `null` when no cell is active.

#### Returns

[`RowCell`](RowCell.md)

#### Inherited from

[`EditorHost`](EditorHost.md).[`getActiveCell`](EditorHost.md#getactivecell)

***

### getActiveCellNode()

> **getActiveCellNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:163](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L163)

Gets the DOM node for the currently active cell, if any.

#### Returns

`HTMLElement`

***

### getActiveViewportNode()

> **getActiveViewportNode**(`e?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:168](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L168)

Gets the viewport node that is active for the given event target.

#### Parameters

##### e?

Optional event target hint for viewport disambiguation.

###### target

`EventTarget`

#### Returns

`HTMLElement`

***

### getAllColumns()

> **getAllColumns**(): [`Column`](Column.md)\<`TItem`\>[]

Defined in: [src/core/isleekgrid.ts:170](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L170)

Returns all columns in the grid, including hidden ones; order may differ from visible columns due to pinning/reordering.

#### Returns

[`Column`](Column.md)\<`TItem`\>[]

***

### getCanvases()

> **getCanvases**(): `any`

Defined in: [src/core/isleekgrid.ts:172](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L172)

Returns the grid's canvas elements (one per viewport when frozen rows/cols are used).

#### Returns

`any`

***

### getCanvasNode()

> **getCanvasNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:178](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L178)

Gets the canvas element for the given row/cell viewport.

#### Parameters

##### row?

`number`

Optional row hint for viewport selection.

##### cell?

`number`

Optional cell hint for viewport selection.

#### Returns

`HTMLElement`

***

### getCellCssStyles()

> **getCellCssStyles**(`key`): [`CellStylesHash`](../type-aliases/CellStylesHash.md)

Defined in: [src/core/isleekgrid.ts:184](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L184)

Gets the cell CSS styles hash associated with the given key.

#### Parameters

##### key

`string`

Style bucket name.

#### Returns

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

Hash of `row -> columnId -> cssClass`.

***

### getCellEditor()

> **getCellEditor**(): [`Editor`](Editor.md)

Defined in: [src/core/isleekgrid.ts:186](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L186)

Returns the currently active editor instance, if any.

#### Returns

[`Editor`](Editor.md)

***

### getCellFromEvent()

> **getCellFromEvent**(`e`): `object`

Defined in: [src/core/isleekgrid.ts:192](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L192)

Resolves a row/cell coordinate from a mouse or keyboard event.

#### Parameters

##### e

`any`

Native event with target coordinates.

#### Returns

`object`

Row/cell indexes.

##### cell

> **cell**: `number`

##### row

> **row**: `number`

***

### getCellFromNode()

> **getCellFromNode**(`cellNode`): `number`

Defined in: [src/core/isleekgrid.ts:197](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L197)

Resolves the cell/column index from a cell DOM node.

#### Parameters

##### cellNode

`Element`

Cell element.

#### Returns

`number`

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): `object`

Defined in: [src/core/isleekgrid.ts:204](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L204)

Resolves a row/cell from pixel coordinates relative to the canvas.

#### Parameters

##### x

`number`

Horizontal pixel offset.

##### y

`number`

Vertical pixel offset.

#### Returns

`object`

Row/cell indexes.

##### cell

> **cell**: `number`

##### row

> **row**: `number`

***

### getCellNode()

> **getCellNode**(`row`, `cell`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:211](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L211)

Gets the DOM node for a specific cell.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

`HTMLElement`

Cell element, or `null` when not rendered.

***

### getCellNodeBox()

> **getCellNodeBox**(`row`, `cell`): `object`

Defined in: [src/core/isleekgrid.ts:218](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L218)

Gets the bounding rectangle for a specific cell.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

`object`

Box with `top`, `right`, `bottom`, `left` in pixels.

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

Defined in: [src/core/isleekgrid.ts:225](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L225)

Gets the column span for the cell at the given row/col, taking `colspan` metadata into account.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

`number`

Number of columns spanned (at least `1`).

***

### getColumnById()

> **getColumnById**(`id`): [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:231](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L231)

Gets a column by its id; may return hidden columns.

#### Parameters

##### id

`string`

Column id.

#### Returns

[`Column`](Column.md)\<`TItem`\>

Matching column definition or `undefined`.

***

### getColumnFromNode()

> **getColumnFromNode**(`cellNode`): [`Column`](Column.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:237](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L237)

Resolves the column definition from a cell DOM node.

#### Parameters

##### cellNode

`Element`

Cell element.

#### Returns

[`Column`](Column.md)\<`TItem`\>

Corresponding column definition.

***

### getColumnIndex()

> **getColumnIndex**(`id`, `opt?`): `number`

Defined in: [src/core/isleekgrid.ts:244](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L244)

Gets the index of a column by its id.

#### Parameters

##### id

`string`

Column id.

##### opt?

When `opt.inAll` is `true`, searches all columns; otherwise only visible columns.

###### inAll?

`boolean`

#### Returns

`number`

Column index or `-1` when not found.

***

### getColumns()

> **getColumns**(): [`Column`](Column.md)\<`TItem`\>[]

Defined in: [src/core/isleekgrid.ts:246](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L246)

Returns only the visible columns in display order.

#### Returns

[`Column`](Column.md)\<`TItem`\>[]

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:248](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L248)

Returns the root container element of the grid.

#### Returns

`HTMLElement`

***

### getData()

> **getData**(): `any`

Defined in: [src/core/isleekgrid.ts:250](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L250)

Returns the data source / `DataView` attached to the grid.

#### Returns

`any`

***

### getDataItem()

> **getDataItem**(`row`): `TItem`

Defined in: [src/core/isleekgrid.ts:256](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L256)

Returns the data item at the given view row.

#### Parameters

##### row

`number`

View row index.

#### Returns

`TItem`

Data item for that row (or `Group`/`GroupTotals` for group rows).

***

### getDataItemValueForColumn()

> **getDataItemValueForColumn**(`item`, `columnDef`): `any`

Defined in: [src/core/isleekgrid.ts:263](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L263)

Extracts the raw cell value for a given column and item.

#### Parameters

##### item

`TItem`

Row data item.

##### columnDef

[`Column`](Column.md)\<`TItem`\>

Column definition.

#### Returns

`any`

Cell value.

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/core/isleekgrid.ts:265](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L265)

Returns the number of rows in the grid's data source/view.

#### Returns

`number`

***

### getDisplayedScrollbarDimensions()

> **getDisplayedScrollbarDimensions**(): `object`

Defined in: [src/core/isleekgrid.ts:267](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L267)

Returns the currently displayed scrollbar dimensions (accounts for auto-hiding etc.).

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

***

### getEditController()

> **getEditController**(): [`EditController`](EditController.md)

Defined in: [src/core/isleekgrid.ts:269](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L269)

Returns the edit controller that manages the active editor lock.

#### Returns

[`EditController`](EditController.md)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](EditorFactory.md)

Defined in: [src/core/editing.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L57)

Resolves the editor factory for a given column/row.

#### Returns

[`EditorFactory`](EditorFactory.md)

#### Inherited from

[`EditorHost`](EditorHost.md).[`getEditorFactory`](EditorHost.md#geteditorfactory)

***

### getEditorLock()

> **getEditorLock**(): [`EditorLock`](../classes/EditorLock.md)

Defined in: [src/core/isleekgrid.ts:271](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L271)

Returns the `EditorLock` instance controlling concurrent edits.

#### Returns

[`EditorLock`](../classes/EditorLock.md)

***

### getFooterRow()

> **getFooterRow**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:273](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L273)

Returns the footer row container element.

#### Returns

`HTMLElement`

***

### getFooterRowColumn()

> **getFooterRowColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:278](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L278)

Returns the footer row cell element for the given column.

#### Parameters

##### columnIdOrIdx

Column id or visible index.

`string` | `number`

#### Returns

`HTMLElement`

***

### getFormatter()

> **getFormatter**(`row`, `column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:285](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L285)

Resolves the formatter to use for a body cell, considering column, row metadata and factory.

#### Parameters

##### row

`number`

Row index.

##### column

[`Column`](Column.md)\<`TItem`\>

Column definition.

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Formatter function for that cell.

***

### getFormatterContext()

> **getFormatterContext**(`row`, `cell`): [`FormatterContext`](FormatterContext.md)

Defined in: [src/core/isleekgrid.ts:292](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L292)

Creates a formatter context for a body cell.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

[`FormatterContext`](FormatterContext.md)

Populated [FormatterContext](FormatterContext.md).

***

### getGridPosition()

> **getGridPosition**(): [`Position`](Position.md)

Defined in: [src/core/isleekgrid.ts:294](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L294)

Returns the grid container's bounding position (as used for editor placement).

#### Returns

[`Position`](Position.md)

***

### getGroupingPanel()

> **getGroupingPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:296](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L296)

Returns the grouping panel container, if enabled.

#### Returns

`HTMLElement`

***

### getHeader()

> **getHeader**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:298](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L298)

Returns the header row container element.

#### Returns

`HTMLElement`

***

### getHeaderColumn()

> **getHeaderColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:303](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L303)

Returns the header cell element for the given column.

#### Parameters

##### columnIdOrIdx

Column id or visible index.

`string` | `number`

#### Returns

`HTMLElement`

***

### getHeaderRow()

> **getHeaderRow**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:305](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L305)

Returns the header-row (filter row) container element.

#### Returns

`HTMLElement`

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`columnIdOrIdx`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:310](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L310)

Returns the header-row cell element for the given column.

#### Parameters

##### columnIdOrIdx

Column id or visible index.

`string` | `number`

#### Returns

`HTMLElement`

***

### getLayoutInfo()

> **getLayoutInfo**(): [`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

Defined in: [src/core/isleekgrid.ts:312](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L312)

Returns summarized layout/pinning information for the current grid configuration.

#### Returns

[`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

***

### getOptions()

> **getOptions**(): [`GridOptions`](GridOptions.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:314](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L314)

Returns the current grid options.

#### Returns

[`GridOptions`](GridOptions.md)\<`TItem`\>

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](GridPlugin.md)

Defined in: [src/core/grid-plugin.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L35)

Retrieves a plugin by its [GridPlugin.pluginName](GridPlugin.md#pluginname).

#### Parameters

##### name

`string`

Plugin name to look up.

#### Returns

[`GridPlugin`](GridPlugin.md)

The plugin instance, or `null`/`undefined` when not found.

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`getPluginByName`](GridPluginHost.md#getpluginbyname)

***

### getPreHeaderPanel()

> **getPreHeaderPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:316](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L316)

Returns the pre-header panel element (grouping panel alternative).

#### Returns

`HTMLElement`

***

### getRenderedRange()

> **getRenderedRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:322](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L322)

Returns the currently rendered view range as managed by the render loop.

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](ViewRange.md)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

Defined in: [src/core/isleekgrid.ts:327](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L327)

Resolves the view row index from a row DOM node.

#### Parameters

##### rowNode

`Element`

Row element.

#### Returns

`number`

***

### getScrollBarDimensions()

> **getScrollBarDimensions**(): `object`

Defined in: [src/core/isleekgrid.ts:329](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L329)

Returns the native scrollbar width/height for the grid, measured from the layout.

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/core/isleekgrid.ts:331](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L331)

Returns the currently selected row indices.

#### Returns

`number`[]

***

### getSelectionModel()

> **getSelectionModel**(): [`SelectionModel`](SelectionModel.md)

Defined in: [src/core/isleekgrid.ts:333](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L333)

Returns the active selection model plugin, if any.

#### Returns

[`SelectionModel`](SelectionModel.md)

***

### getSortColumns()

> **getSortColumns**(): [`ColumnSort`](ColumnSort.md)[]

Defined in: [src/core/isleekgrid.ts:335](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L335)

Returns the active sort column descriptors.

#### Returns

[`ColumnSort`](ColumnSort.md)[]

***

### getTopPanel()

> **getTopPanel**(): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:337](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L337)

Returns the top panel container element.

#### Returns

`HTMLElement`

***

### getTotalsFormatter()

> **getTotalsFormatter**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/core/isleekgrid.ts:343](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L343)

Resolves the group-totals formatter for a column.

#### Parameters

##### column

[`Column`](Column.md)\<`TItem`\>

Column to resolve a totals formatter for.

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Formatter for that column's totals row.

***

### getUID()

> **getUID**(): `string`

Defined in: [src/core/isleekgrid.ts:345](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L345)

Returns the unique identifier assigned to this grid instance.

#### Returns

`string`

***

### getViewport()

> **getViewport**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:351](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L351)

Gets the viewport range for the active viewports.

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](ViewRange.md)

***

### getViewportNode()

> **getViewportNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/core/isleekgrid.ts:357](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L357)

Gets the viewport container node for the given row/cell.

#### Parameters

##### row?

`number`

Optional row hint for viewport selection.

##### cell?

`number`

Optional cell hint for viewport selection.

#### Returns

`HTMLElement`

***

### getVisibleRange()

> **getVisibleRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](ViewRange.md)

Defined in: [src/core/isleekgrid.ts:363](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L363)

Gets the visible (fully within viewport) row/cell range.

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](ViewRange.md)

***

### gotoCell()

> **gotoCell**(`row`, `cell`, `forceEdit?`): `void`

Defined in: [src/core/isleekgrid.ts:370](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L370)

Scrolls to and optionally edits the given cell.

#### Parameters

##### row

`number`

Row index to go to.

##### cell

`number`

Cell/column index to go to.

##### forceEdit?

`boolean`

Whether to immediately enter edit mode.

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/core/isleekgrid.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L93)

Initializes the grid DOM, binds events and performs the first render.
Called automatically on construction unless `explicitInitialization` is set.

#### Returns

`void`

***

### invalidate()

> **invalidate**(): `void`

Defined in: [src/core/isleekgrid.ts:372](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L372)

Invalidates the entire grid, requiring a full re-render on the next frame.

#### Returns

`void`

***

### invalidateAllRows()

> **invalidateAllRows**(): `void`

Defined in: [src/core/isleekgrid.ts:374](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L374)

Invalidates all rows, forcing them to be re-rendered.

#### Returns

`void`

***

### invalidateColumns()

> **invalidateColumns**(): `void`

Defined in: [src/core/isleekgrid.ts:379](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L379)

Invalidates header/column chrome after column properties change without a full `setColumns()` call
(e.g. width, name, `visible` etc.). Forces header/footer re-rendering.

#### Returns

`void`

***

### invalidateRow()

> **invalidateRow**(`row`): `void`

Defined in: [src/core/isleekgrid.ts:384](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L384)

Invalidates a single row so it is re-rendered on the next frame.

#### Parameters

##### row

`number`

View row index to invalidate.

#### Returns

`void`

***

### invalidateRows()

> **invalidateRows**(`rows`): `void`

Defined in: [src/core/isleekgrid.ts:389](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L389)

Invalidates multiple rows so they are re-rendered on the next frame.

#### Parameters

##### rows

`number`[]

View row indices to invalidate.

#### Returns

`void`

***

### navigate()

> **navigate**(`dir`): `boolean`

Defined in: [src/core/cellnavigation.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L95)

Navigate the active cell in the specified direction.

#### Parameters

##### dir

[`CellNavigationDirection`](../type-aliases/CellNavigationDirection.md)

Navigation direction.

#### Returns

`boolean`

Whether navigation resulted in a change of the active cell.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigate`](CellNavigation.md#navigate)

***

### navigateBottom()

> **navigateBottom**(): `void`

Defined in: [src/core/cellnavigation.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L18)

Moves the active cell to the last row of the data set.

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateBottom`](CellNavigation.md#navigatebottom)

***

### navigateDown()

> **navigateDown**(): `boolean`

Defined in: [src/core/cellnavigation.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L24)

Moves the active cell one row down.

#### Returns

`boolean`

`true` if the active cell changed, `false` if already at the bottom or blocked.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateDown`](CellNavigation.md#navigatedown)

***

### navigateLeft()

> **navigateLeft**(): `boolean`

Defined in: [src/core/cellnavigation.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L30)

Moves the active cell one column to the left.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateLeft`](CellNavigation.md#navigateleft)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/core/cellnavigation.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L36)

Moves the active cell to the next focusable cell (row-major order, wrapping rows).

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateNext`](CellNavigation.md#navigatenext)

***

### navigatePageDown()

> **navigatePageDown**(): `void`

Defined in: [src/core/cellnavigation.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L41)

Scrolls one page down and moves the active cell accordingly.

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePageDown`](CellNavigation.md#navigatepagedown)

***

### navigatePageUp()

> **navigatePageUp**(): `void`

Defined in: [src/core/cellnavigation.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L46)

Scrolls one page up and moves the active cell accordingly.

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePageUp`](CellNavigation.md#navigatepageup)

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/core/cellnavigation.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L52)

Moves the active cell to the previous focusable cell (reverse row-major order).

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigatePrev`](CellNavigation.md#navigateprev)

***

### navigateRight()

> **navigateRight**(): `boolean`

Defined in: [src/core/cellnavigation.ts:58](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L58)

Moves the active cell one column to the right.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRight`](CellNavigation.md#navigateright)

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

Defined in: [src/core/cellnavigation.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L64)

Moves the active cell to the last cell of the current row.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRowEnd`](CellNavigation.md#navigaterowend)

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

Defined in: [src/core/cellnavigation.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L70)

Moves the active cell to the first cell of the current row.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateRowStart`](CellNavigation.md#navigaterowstart)

***

### navigateTop()

> **navigateTop**(): `void`

Defined in: [src/core/cellnavigation.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L75)

Moves the active cell to the first row of the data set.

#### Returns

`void`

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateTop`](CellNavigation.md#navigatetop)

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

Defined in: [src/core/cellnavigation.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L82)

Moves the active cell to the specified row, keeping the current column if possible.

#### Parameters

##### row

`number`

Zero-based row index to navigate to.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateToRow`](CellNavigation.md#navigatetorow)

***

### navigateUp()

> **navigateUp**(): `boolean`

Defined in: [src/core/cellnavigation.ts:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L88)

Moves the active cell one row up.

#### Returns

`boolean`

`true` if the active cell changed.

#### Inherited from

[`CellNavigation`](CellNavigation.md).[`navigateUp`](CellNavigation.md#navigateup)

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L40)

Registers a plugin and calls its [GridPlugin.init](GridPlugin.md#init).

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

Plugin to register.

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`registerPlugin`](GridPluginHost.md#registerplugin)

***

### removeCellCssStyles()

> **removeCellCssStyles**(`key`): `void`

Defined in: [src/core/isleekgrid.ts:394](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L394)

Removes all cell CSS styles associated with the given key.

#### Parameters

##### key

`string`

Style bucket name.

#### Returns

`void`

***

### reorderColumns()

> **reorderColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/core/isleekgrid.ts:405](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L405)

Reorders columns based on their ids and optionally updates visibility.

#### Parameters

##### columnIds

`string`[]

Ordered list of column ids to become the new visible order.

##### opt?

When `opt.notify` is `false`, suppresses `onColumnsReordered`; when `opt.setVisible` is provided, visible columns are set to that list.

###### notify?

`boolean`

###### setVisible?

`string`[]

#### Returns

`void`

***

### resetActiveCell()

> **resetActiveCell**(): `void`

Defined in: [src/core/isleekgrid.ts:407](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L407)

Clears the active cell without scrolling.

#### Returns

`void`

***

### scrollActiveCellIntoView()

> **scrollActiveCellIntoView**(): `void`

Defined in: [src/core/isleekgrid.ts:414](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L414)

Scrolls the viewport so the active cell is visible.

#### Returns

`void`

***

### scrollCellIntoView()

> **scrollCellIntoView**(`row`, `cell`, `doPaging?`): `void`

Defined in: [src/core/isleekgrid.ts:421](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L421)

Scrolls a specific cell into view.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

##### doPaging?

`boolean`

Whether to page the view when the row is far outside the viewport.

#### Returns

`void`

***

### scrollColumnIntoView()

> **scrollColumnIntoView**(`cell`): `void`

Defined in: [src/core/isleekgrid.ts:426](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L426)

Scrolls a column into view without changing the active row.

#### Parameters

##### cell

`number`

Visible column index to bring into view.

#### Returns

`void`

***

### scrollRowIntoView()

> **scrollRowIntoView**(`row`, `doPaging?`): `void`

Defined in: [src/core/isleekgrid.ts:432](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L432)

Scrolls a row into view.

#### Parameters

##### row

`number`

Row index.

##### doPaging?

`boolean`

Whether to page the view when the row is far outside the viewport.

#### Returns

`void`

***

### scrollRowToTop()

> **scrollRowToTop**(`row`): `void`

Defined in: [src/core/isleekgrid.ts:437](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L437)

Scrolls so that the given row is at the top of the viewport.

#### Parameters

##### row

`number`

Row index to position at the top.

#### Returns

`void`

***

### setActiveCell()

> **setActiveCell**(`row`, `cell`): `void`

Defined in: [src/core/isleekgrid.ts:443](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L443)

Sets the active cell, committing or cancelling any pending edit as needed.

#### Parameters

##### row

`number`

Row index to activate.

##### cell

`number`

Cell/column index to activate.

#### Returns

`void`

***

### setActiveRow()

> **setActiveRow**(`row`, `cell`, `suppressScrollIntoView?`): `void`

Defined in: [src/core/isleekgrid.ts:450](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L450)

Sets the active row, optionally suppressing the automatic scroll into view.

#### Parameters

##### row

`number`

Row index to become active.

##### cell

`number`

Cell/column index to become active.

##### suppressScrollIntoView?

`boolean`

When `true`, the grid does not scroll to show the cell.

#### Returns

`void`

***

### setCellCssStyles()

> **setCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/core/isleekgrid.ts:456](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L456)

Sets per-cell CSS styles under the given key, replacing any previous styles for that key.

#### Parameters

##### key

`string`

Bucket name.

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

Map of `row -> columnId -> cssClass`.

#### Returns

`void`

***

### setColumnHeaderVisibility()

> **setColumnHeaderVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:461](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L461)

Shows or hides the column header row.

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setColumns()

> **setColumns**(`columns`): `void`

Defined in: [src/core/isleekgrid.ts:466](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L466)

Replaces the column set and re-renders headers/rows.

#### Parameters

##### columns

[`Column`](Column.md)\<`TItem`\>[]

New ordered list of column definitions.

#### Returns

`void`

***

### setData()

> **setData**(`newData`, `scrollToTop?`): `void`

Defined in: [src/core/isleekgrid.ts:478](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L478)

Replaces the data source and refreshes the view.

#### Parameters

##### newData

`any`

New data array or `DataView`-like object.

##### scrollToTop?

`boolean`

Whether to scroll to the top after the replacement.

#### Returns

`void`

***

### setFooterRowVisibility()

> **setFooterRowVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:483](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L483)

Shows or hides the footer row.

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setGroupingPanelVisibility()

> **setGroupingPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:488](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L488)

Shows or hides the grouping panel.

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setHeaderRowVisibility()

> **setHeaderRowVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:493](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L493)

Shows or hides the header row (filter row).

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setOptions()

> **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

Defined in: [src/core/isleekgrid.ts:501](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L501)

Merges the given options into the current options and optionally re-renders.

#### Parameters

##### args

[`GridOptions`](GridOptions.md)\<`TItem`\>

Options to merge.

##### suppressRender?

`boolean`

When `true`, no render is triggered.

##### suppressColumnSet?

`boolean`

When `true`, columns are not re-set from `args.columns`.

##### suppressSetOverflow?

`boolean`

When `true`, the canvas overflow recalculation is skipped.

#### Returns

`void`

***

### setPreHeaderPanelVisibility()

> **setPreHeaderPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:506](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L506)

Shows or hides the pre-header panel (deprecated grouping-panel variant).

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/core/isleekgrid.ts:511](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L511)

Selects the given rows (used by legacy row-selection integration).

#### Parameters

##### rows

`number`[]

Row indices to select.

#### Returns

`void`

***

### setSelectionModel()

> **setSelectionModel**(`model`): `void`

Defined in: [src/core/isleekgrid.ts:516](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L516)

Attaches a selection-model plugin.

#### Parameters

##### model

[`SelectionModel`](SelectionModel.md)

Selection model to activate.

#### Returns

`void`

***

### setSortColumn()

> **setSortColumn**(`columnId`, `ascending`): `void`

Defined in: [src/core/isleekgrid.ts:522](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L522)

Sets single-column sort state.

#### Parameters

##### columnId

`string`

Column id to sort by.

##### ascending

`boolean`

`true` for ascending, `false` for descending.

#### Returns

`void`

***

### setSortColumns()

> **setSortColumns**(`cols`): `void`

Defined in: [src/core/isleekgrid.ts:527](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L527)

Sets multi-column sort state.

#### Parameters

##### cols

[`ColumnSort`](ColumnSort.md)[]

Array of sort descriptors.

#### Returns

`void`

***

### setTopPanelVisibility()

> **setTopPanelVisibility**(`visible`): `void`

Defined in: [src/core/isleekgrid.ts:532](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L532)

Shows or hides the top panel.

#### Parameters

##### visible

`boolean`

`true` to show, `false` to hide.

#### Returns

`void`

***

### setVisibleColumns()

> **setVisibleColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/core/isleekgrid.ts:472](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L472)

Sets the visible columns by id and optionally reorders them.

#### Parameters

##### columnIds

`string`[]

Ids of columns to make visible, in desired order.

##### opt?

When `opt.reorder` is `false`, current order is preserved; when `opt.notify` is `false`, `onColumnsReordered` is suppressed.

###### notify?

`boolean`

###### reorder?

`boolean`

#### Returns

`void`

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/core/grid-plugin.ts:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L45)

Unregisters a plugin, calling [GridPlugin.destroy](GridPlugin.md#destroy) if defined.

#### Parameters

##### plugin

[`GridPlugin`](GridPlugin.md)

Plugin to remove.

#### Returns

`void`

#### Inherited from

[`GridPluginHost`](GridPluginHost.md).[`unregisterPlugin`](GridPluginHost.md#unregisterplugin)

***

### updateCell()

> **updateCell**(`row`, `cell`): `void`

Defined in: [src/core/isleekgrid.ts:538](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L538)

Invalidates and re-renders a single cell.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell/column index.

#### Returns

`void`

***

### updateColumnHeader()

> **updateColumnHeader**(`columnId`, `title?`, `toolTip?`): `void`

Defined in: [src/core/isleekgrid.ts:545](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L545)

Updates a header cell's title/tooltip in place without a full column reset.

#### Parameters

##### columnId

`string`

Column id whose header should be updated.

##### title?

New title text or header formatter.

`string` | [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`any`\>

##### toolTip?

`string`

New tooltip text.

#### Returns

`void`

***

### updatePagingStatusFromView()

> **updatePagingStatusFromView**(`pagingInfo`): `void`

Defined in: [src/core/isleekgrid.ts:550](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L550)

Updates the grid's paging UI from a view/page change.

#### Parameters

##### pagingInfo

Paging descriptor with `pageSize`, `pageNum` and `totalPages`.

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

Defined in: [src/core/isleekgrid.ts:555](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L555)

Invalidates and re-renders an entire row.

#### Parameters

##### row

`number`

View row index to update.

#### Returns

`void`

***

### updateRowCount()

> **updateRowCount**(): `void`

Defined in: [src/core/isleekgrid.ts:557](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/isleekgrid.ts#L557)

Recalculates row count after the data view changes and re-renders as needed.

#### Returns

`void`
