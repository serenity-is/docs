[@serenity-is/sleekgrid](../README.md) / SleekGrid

# Class: SleekGrid\<TItem\>

Defined in: [src/grid/sleekgrid.tsx:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L40)

Main virtualized grid implementation. Handles viewport layout, column
sizing, keyboard/cell navigation, editing, selection, and async post rendering.
Implements [ISleekGrid](../interfaces/ISleekGrid.md).

## Type Parameters

### TItem

`TItem` = `any`

Data item type.

## Implements

- [`ISleekGrid`](../interfaces/ISleekGrid.md)\<`TItem`\>

## Constructors

### Constructor

> **new SleekGrid**\<`TItem`\>(`container`, `data`, `columns`, `options`): `SleekGrid`\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:218](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L218)

Constructs and initializes a new SleekGrid inside `container`.
Auto-initializes unless `explicitInitialization` is set.

#### Parameters

##### container

Selector, element or jQuery/array-like container.

`string` | `HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### data

`any`

DataView or plain array of items.

##### columns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

Initial column definitions.

##### options

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

Grid options merged with [gridDefaults](../variables/gridDefaults.md).

#### Returns

`SleekGrid`\<`TItem`\>

## Properties

### onActiveCellChanged

> `readonly` **onActiveCellChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md)\>

Defined in: [src/grid/sleekgrid.tsx:134](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L134)

Fired when the active cell changes ([ArgsCell](../interfaces/ArgsCell.md)).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onActiveCellChanged`](../interfaces/ISleekGrid.md#onactivecellchanged)

***

### onActiveCellPositionChanged

> `readonly` **onActiveCellPositionChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:136](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L136)

Fired when the active cell's box/position changes (scroll/ancestor scroll).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onActiveCellPositionChanged`](../interfaces/ISleekGrid.md#onactivecellpositionchanged)

***

### onAddNewRow

> `readonly` **onAddNewRow**: [`EventEmitter`](EventEmitter.md)\<[`ArgsAddNewRow`](../interfaces/ArgsAddNewRow.md)\>

Defined in: [src/grid/sleekgrid.tsx:138](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L138)

Fired when the Add-New row attempts to create a new item.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onAddNewRow`](../interfaces/ISleekGrid.md#onaddnewrow)

***

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:142](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L142)

Fired after [SleekGrid.init](#init) completes for this instance.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onAfterInit`](../interfaces/ISleekGrid.md#onafterinit)

***

### onBeforeCellEditorDestroy

> `readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsEditorDestroy`](../interfaces/ArgsEditorDestroy.md)\>

Defined in: [src/grid/sleekgrid.tsx:144](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L144)

Before a cell editor is destroyed (allows intercept).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeCellEditorDestroy`](../interfaces/ISleekGrid.md#onbeforecelleditordestroy)

***

### onBeforeDestroy

> `readonly` **onBeforeDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:146](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L146)

Before the grid is destroyed.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeDestroy`](../interfaces/ISleekGrid.md#onbeforedestroy)

***

### onBeforeEditCell

> `readonly` **onBeforeEditCell**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellEdit`](../interfaces/ArgsCellEdit.md)\>

Defined in: [src/grid/sleekgrid.tsx:148](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L148)

Cancelable; before a cell becomes editable.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeEditCell`](../interfaces/ISleekGrid.md#onbeforeeditcell)

***

### onBeforeFooterRowCellDestroy

> `readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L150)

Before a footer-row column node is removed.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeFooterRowCellDestroy`](../interfaces/ISleekGrid.md#onbeforefooterrowcelldestroy)

***

### onBeforeHeaderCellDestroy

> `readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:152](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L152)

Before a header column node is removed.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeHeaderCellDestroy`](../interfaces/ISleekGrid.md#onbeforeheadercelldestroy)

***

### onBeforeHeaderRowCellDestroy

> `readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:154](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L154)

Before a header-row column node is removed.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeHeaderRowCellDestroy`](../interfaces/ISleekGrid.md#onbeforeheaderrowcelldestroy)

***

### onCellChange

> `readonly` **onCellChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellChange`](../interfaces/ArgsCellChange.md)\>

Defined in: [src/grid/sleekgrid.tsx:156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L156)

After an editor commits a cell change.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCellChange`](../interfaces/ISleekGrid.md#oncellchange)

***

### onCellCssStylesChanged

> `readonly` **onCellCssStylesChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCssStyle`](../interfaces/ArgsCssStyle.md)\>

Defined in: [src/grid/sleekgrid.tsx:158](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L158)

After `setCellCssStyles`/`addCellCssStyles`/`removeCellCssStyles`.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCellCssStylesChanged`](../interfaces/ISleekGrid.md#oncellcssstyleschanged)

***

### onClick

> `readonly` **onClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:160](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L160)

Click on a cell's canvas.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onClick`](../interfaces/ISleekGrid.md#onclick)

***

### onColumnsReordered

> `readonly` **onColumnsReordered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:162](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L162)

After columns are reordered (drag or API).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onColumnsReordered`](../interfaces/ISleekGrid.md#oncolumnsreordered)

***

### onColumnsResized

> `readonly` **onColumnsResized**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L164)

After columns are resized.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onColumnsResized`](../interfaces/ISleekGrid.md#oncolumnsresized)

***

### onCompositeEditorChange

> `readonly` **onCompositeEditorChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L166)

Forwarded by editors in composite-edit mode when a field value changes.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCompositeEditorChange`](../interfaces/ISleekGrid.md#oncompositeeditorchange)

***

### onContextMenu

> `readonly` **onContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:168](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L168)

Context menu on the grid canvas (opportunity to suppress/override).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onContextMenu`](../interfaces/ISleekGrid.md#oncontextmenu)

***

### onDblClick

> `readonly` **onDblClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:170](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L170)

Double-click on a cell.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDblClick`](../interfaces/ISleekGrid.md#ondblclick)

***

### onDrag

> `readonly` **onDrag**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:172](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L172)

Ongoing drag (after threshold).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDrag`](../interfaces/ISleekGrid.md#ondrag)

***

### onDragEnd

> `readonly` **onDragEnd**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:174](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L174)

End of drag lifecycle.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragEnd`](../interfaces/ISleekGrid.md#ondragend)

***

### onDragInit

> `readonly` **onDragInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:176](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L176)

Initial drag attempt (cancelable via `stopImmediatePropagation`).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragInit`](../interfaces/ISleekGrid.md#ondraginit)

***

### onDragStart

> `readonly` **onDragStart**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:178](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L178)

When drag start threshold is passed.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragStart`](../interfaces/ISleekGrid.md#ondragstart)

***

### onFooterRowCellRendered

> `readonly` **onFooterRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:180](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L180)

After a footer-row cell is created.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onFooterRowCellRendered`](../interfaces/ISleekGrid.md#onfooterrowcellrendered)

***

### onHeaderCellRendered

> `readonly` **onHeaderCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:182](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L182)

After a header cell is created.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderCellRendered`](../interfaces/ISleekGrid.md#onheadercellrendered)

***

### onHeaderClick

> `readonly` **onHeaderClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:184](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L184)

Click on a header column.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderClick`](../interfaces/ISleekGrid.md#onheaderclick)

***

### onHeaderContextMenu

> `readonly` **onHeaderContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:186](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L186)

Context menu on a header column.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderContextMenu`](../interfaces/ISleekGrid.md#onheadercontextmenu)

***

### onHeaderMouseEnter

> `readonly` **onHeaderMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:188](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L188)

Mouse entered a header column.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderMouseEnter`](../interfaces/ISleekGrid.md#onheadermouseenter)

***

### onHeaderMouseLeave

> `readonly` **onHeaderMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:190](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L190)

Mouse left a header column.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderMouseLeave`](../interfaces/ISleekGrid.md#onheadermouseleave)

***

### onHeaderRowCellRendered

> `readonly` **onHeaderRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:192](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L192)

After a header-row (filter) cell is created.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderRowCellRendered`](../interfaces/ISleekGrid.md#onheaderrowcellrendered)

***

### onKeyDown

> `readonly` **onKeyDown**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `KeyboardEvent`\>

Defined in: [src/grid/sleekgrid.tsx:194](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L194)

Keydown forwarded from focus sinks/canvases.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onKeyDown`](../interfaces/ISleekGrid.md#onkeydown)

***

### onMouseEnter

> `readonly` **onMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:196](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L196)

Mouse entered a cell's canvas target.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onMouseEnter`](../interfaces/ISleekGrid.md#onmouseenter)

***

### onMouseLeave

> `readonly` **onMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:198](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L198)

Mouse left a cell (entering the canvas background).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onMouseLeave`](../interfaces/ISleekGrid.md#onmouseleave)

***

### onScroll

> `readonly` **onScroll**: [`EventEmitter`](EventEmitter.md)\<[`ArgsScroll`](../interfaces/ArgsScroll.md)\>

Defined in: [src/grid/sleekgrid.tsx:200](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L200)

Raw scroll offsets after `handleScroll` (viewport and H-sync applied).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onScroll`](../interfaces/ISleekGrid.md#onscroll)

***

### onSelectedRowsChanged

> `readonly` **onSelectedRowsChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSelectedRowsChange`](../interfaces/ArgsSelectedRowsChange.md)\>

Defined in: [src/grid/sleekgrid.tsx:202](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L202)

After the selected-rows set changes (via selection model).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onSelectedRowsChanged`](../interfaces/ISleekGrid.md#onselectedrowschanged)

***

### onSort

> `readonly` **onSort**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSort`](../interfaces/ArgsSort.md)\>

Defined in: [src/grid/sleekgrid.tsx:204](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L204)

After header-driven sort toggling (single or multi).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onSort`](../interfaces/ISleekGrid.md#onsort)

***

### onValidationError

> `readonly` **onValidationError**: [`EventEmitter`](EventEmitter.md)\<[`ArgsValidationError`](../interfaces/ArgsValidationError.md)\>

Defined in: [src/grid/sleekgrid.tsx:206](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L206)

When `commitCurrentEdit()` fails validation.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onValidationError`](../interfaces/ISleekGrid.md#onvalidationerror)

***

### onViewportChanged

> `readonly` **onViewportChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:208](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L208)

After the viewport is re-rendered following a scroll.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onViewportChanged`](../interfaces/ISleekGrid.md#onviewportchanged)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:140](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L140)

Static emitter also fired after any grid is initialized.

## Methods

### addCellCssStyles()

> **addCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/grid/sleekgrid.tsx:3218](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3218)

Adds a per-cell CSS hash under `key` and applies it to rendered rows.

#### Parameters

##### key

`string`

Namespace key.

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

Hash of `row -> columnId -> cssClass`.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`addCellCssStyles`](../interfaces/ISleekGrid.md#addcellcssstyles)

***

### autosizeColumns()

> **autosizeColumns**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1391](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1391)

Auto-fits resizable column widths to the available viewport width.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`autosizeColumns`](../interfaces/ISleekGrid.md#autosizecolumns)

***

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4559](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4559)

Cancels the active editor (if any) by delegating to `makeActiveCellNormal()`.

#### Returns

`boolean`

Always `true`.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`cancelCurrentEdit`](../interfaces/ISleekGrid.md#cancelcurrentedit)

***

### canCellBeActive()

> **canCellBeActive**(`row`, `cell`, `tab?`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4367](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4367)

Checks whether `row`/`cell` may become the active (focusable) cell.
Consults row/column metadata and `focusable` flags.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell index.

##### tab?

`boolean`

When `true`, additionally checks `tabbable`.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`canCellBeActive`](../interfaces/ISleekGrid.md#cancellbeactive)

***

### canCellBeSelected()

> **canCellBeSelected**(`row`, `cell`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4419](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4419)

Checks whether `row`/`cell` is selectable (from row/column metadata `selectable`).

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell index.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`canCellBeSelected`](../interfaces/ISleekGrid.md#cancellbeselected)

***

### clearTextSelection()

> **clearTextSelection**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3806](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3806)

Clears any active text selection, handling IE `selection` when present.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`clearTextSelection`](../interfaces/ISleekGrid.md#cleartextselection)

***

### columnsResized()

> **columnsResized**(`invalidate`): `void`

Defined in: [src/grid/sleekgrid.tsx:1204](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1204)

Notifies the grid that column widths changed externally; updates limits,
re-applies column widths and re-renders as needed.

#### Parameters

##### invalidate

`boolean` = `true`

When `true`, invalidates and re-renders visible rows.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`columnsResized`](../interfaces/ISleekGrid.md#columnsresized)

***

### commitCurrentEdit()

> **commitCurrentEdit**(`opt?`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4476](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4476)

Commits the active editor value (if any), running validation and either
executing an [EditCommand](../interfaces/EditCommand.md) via `editCommandHandler` or directly.

#### Parameters

##### opt?

###### forceValueChange?

`boolean`

When `true`, treats unchanged values as changed.

#### Returns

`boolean`

`true` when the commit succeeds (or no edit was active).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`commitCurrentEdit`](../interfaces/ISleekGrid.md#commitcurrentedit)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1285](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1285)

Tears down the grid, unbinding events, destroying plugins and removing DOM.
Clears all `on*` emitters and instance-owned properties.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`destroy`](../interfaces/ISleekGrid.md#destroy)

***

### editActiveCell()

> **editActiveCell**(`editor?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3867](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3867)

Forces the active cell into edit mode (or keeps it active) using `editor` when provided.

#### Parameters

##### editor?

[`EditorClass`](../interfaces/EditorClass.md)

Optional editor class override.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`editActiveCell`](../interfaces/ISleekGrid.md#editactivecell)

***

### flashCell()

> **flashCell**(`row`, `cell`, `speed?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3272](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3272)

Briefly toggles the `cellFlashingCssClass` on `row`/`cell` for animation.

#### Parameters

##### row

`number`

View row index.

##### cell

`number`

Cell/column index.

##### speed?

`number`

Millisecond interval between toggles.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`flashCell`](../interfaces/ISleekGrid.md#flashcell)

***

### focus()

> **focus**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3696](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3696)

Focuses the active focus sink so subsequent keystrokes reach the grid.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`focus`](../interfaces/ISleekGrid.md#focus)

***

### getAbsoluteColumnMinWidth()

> **getAbsoluteColumnMinWidth**(): `number`

Defined in: [src/grid/sleekgrid.tsx:584](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L584)

Returns the absolute minimum column width derived from header/cell box sizing.

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getAbsoluteColumnMinWidth`](../interfaces/ISleekGrid.md#getabsolutecolumnminwidth)

***

### getActiveCanvasNode()

> **getActiveCanvasNode**(`e?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:657](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L657)

Returns the canvas that last received focus/interaction, optionally
resolving from an event for plugin compatibility.

#### Parameters

##### e?

Optional event whose target is used to resolve the canvas.

###### target

`EventTarget`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCanvasNode`](../interfaces/ISleekGrid.md#getactivecanvasnode)

***

### getActiveCell()

> **getActiveCell**(): [`RowCell`](../interfaces/RowCell.md)

Defined in: [src/grid/sleekgrid.tsx:4000](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4000)

Returns the active `row`/`cell`, or `null` when none is active.

#### Returns

[`RowCell`](../interfaces/RowCell.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCell`](../interfaces/ISleekGrid.md#getactivecell)

***

### getActiveCellNode()

> **getActiveCellNode**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:4011](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4011)

Returns the DOM node for the active cell, or `null`.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCellNode`](../interfaces/ISleekGrid.md#getactivecellnode)

***

### getActiveViewportNode()

> **getActiveViewportNode**(`e?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:685](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L685)

Returns the active viewport, optionally resolving from an event for plugin compat.

#### Parameters

##### e?

Optional event whose target is used to resolve the viewport.

###### target

`EventTarget`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveViewportNode`](../interfaces/ISleekGrid.md#getactiveviewportnode)

***

### getAllColumns()

> **getAllColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Defined in: [src/grid/sleekgrid.tsx:1533](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1533)

Returns all columns including hidden ones (in `setColumns` order).

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getAllColumns`](../interfaces/ISleekGrid.md#getallcolumns)

***

### getCanvases()

> **getCanvases**(): `any`

Defined in: [src/grid/sleekgrid.tsx:647](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L647)

Returns all rendered canvases across bands/panes (jQuery-wrapped when available).

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCanvases`](../interfaces/ISleekGrid.md#getcanvases)

***

### getCanvasNode()

> **getCanvasNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:631](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L631)

Returns the canvas element for the band/pane that owns `row`/`cell`.

#### Parameters

##### row?

`number`

Optional view row hint for frozen-pane disambiguation.

##### cell?

`number`

Optional cell hint for pinned-band disambiguation.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCanvasNode`](../interfaces/ISleekGrid.md#getcanvasnode)

***

### getCellCssStyles()

> **getCellCssStyles**(`key`): [`CellStylesHash`](../type-aliases/CellStylesHash.md)

Defined in: [src/grid/sleekgrid.tsx:3262](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3262)

Returns the hash for `key` as stored by `setCellCssStyles`/`addCellCssStyles`.

#### Parameters

##### key

`string`

Namespace key.

#### Returns

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellCssStyles`](../interfaces/ISleekGrid.md#getcellcssstyles)

***

### getCellEditor()

> **getCellEditor**(): [`Editor`](../interfaces/Editor.md)

Defined in: [src/grid/sleekgrid.tsx:3993](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3993)

Returns the currently active editor, if any.

#### Returns

[`Editor`](../interfaces/Editor.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellEditor`](../interfaces/ISleekGrid.md#getcelleditor)

***

### getCellFromEvent()

> **getCellFromEvent**(`e`): `object`

Defined in: [src/grid/sleekgrid.tsx:3628](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3628)

Resolves `row`/`cell` for an event targeting a cell.

#### Parameters

##### e

`any`

DOM event whose `target` lies inside the desired cell.

#### Returns

`object`

##### cell

> **cell**: `number`

##### row

> **row**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellFromEvent`](../interfaces/ISleekGrid.md#getcellfromevent)

***

### getCellFromNode()

> **getCellFromNode**(`cellNode`): `number`

Defined in: [src/grid/sleekgrid.tsx:3575](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3575)

Reads the column index from a cell's `data-c` or legacy `.l#` class.

#### Parameters

##### cellNode

`Element`

Cell element.

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellFromNode`](../interfaces/ISleekGrid.md#getcellfromnode)

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): `object`

Defined in: [src/grid/sleekgrid.tsx:3554](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3554)

Resolves a `row`/`cell` for the given content-space point.

#### Parameters

##### x

`number`

Horizontal pixel offset from the canvas origin.

##### y

`number`

Vertical pixel offset.

#### Returns

`object`

##### cell

> **cell**: `number`

##### row

> **row**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellFromPoint`](../interfaces/ISleekGrid.md#getcellfrompoint)

***

### getCellNode()

> **getCellNode**(`row`, `cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:4314](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4314)

Returns the cell DOM node for `row`/`cell` if rendered (`rowsCache` hit).

#### Parameters

##### row

`number`

View row index.

##### cell

`number`

Cell index.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellNode`](../interfaces/ISleekGrid.md#getcellnode)

***

### getCellNodeBox()

> **getCellNodeBox**(`row`, `cell`): `object`

Defined in: [src/grid/sleekgrid.tsx:3653](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3653)

Returns the pixel bounds of a cell's box in canvas coordinates.

#### Parameters

##### row

`number`

Row index.

##### cell

`number`

Cell index.

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellNodeBox`](../interfaces/ISleekGrid.md#getcellnodebox)

***

### getColspan()

> **getColspan**(`row`, `cell`): `number`

Defined in: [src/grid/sleekgrid.tsx:4170](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4170)

Returns column span for `row`/`cell` via row metadata (`colspan`), or `1`.

#### Parameters

##### row

`number`

View row index.

##### cell

`number`

Cell index.

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColspan`](../interfaces/ISleekGrid.md#getcolspan)

***

### getColumnById()

> **getColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1374](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1374)

Finds a column by its `id` including hidden columns.

#### Parameters

##### id

`string`

Column id.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

Matching column or `null`.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnById`](../interfaces/ISleekGrid.md#getcolumnbyid)

***

### getColumnFromNode()

> **getColumnFromNode**(`cellNode`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:3595](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3595)

Resolves the column definition from a cell's node.

#### Parameters

##### cellNode

`Element`

Cell element.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnFromNode`](../interfaces/ISleekGrid.md#getcolumnfromnode)

***

### getColumnIndex()

> **getColumnIndex**(`id`, `opt?`): `number`

Defined in: [src/grid/sleekgrid.tsx:1384](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1384)

Returns the column index for `id`.

#### Parameters

##### id

`string`

Column id.

##### opt?

###### inAll?

`boolean`

When `true`, searches all columns; otherwise visible columns.

#### Returns

`number`

Column index or `null` when not found.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnIndex`](../interfaces/ISleekGrid.md#getcolumnindex)

***

### getColumns()

> **getColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Defined in: [src/grid/sleekgrid.tsx:1540](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1540)

Returns only the currently visible columns in display order.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumns`](../interfaces/ISleekGrid.md#getcolumns)

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:1958](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1958)

Returns the grid's container element.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getContainerNode`](../interfaces/ISleekGrid.md#getcontainernode)

***

### getData()

> **getData**(): `any`

Defined in: [src/grid/sleekgrid.tsx:1851](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1851)

Returns the current data source (DataView or array).

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getData`](../interfaces/ISleekGrid.md#getdata)

***

### getDataItem()

> **getDataItem**(`row`): `TItem`

Defined in: [src/grid/sleekgrid.tsx:1875](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1875)

Returns the data item for a view row (group/totals rows may be `Group`/`IGroupTotals`).

#### Parameters

##### row

`number`

View row index.

#### Returns

`TItem`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataItem`](../interfaces/ISleekGrid.md#getdataitem)

***

### getDataItemValueForColumn()

> **getDataItemValueForColumn**(`item`, `columnDef`): `any`

Defined in: [src/grid/sleekgrid.tsx:2135](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2135)

Extracts the raw cell value for `columnDef` from `item` (or via
`dataItemColumnValueExtractor` when configured).

#### Parameters

##### item

`TItem`

Row data item.

##### columnDef

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column definition.

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataItemValueForColumn`](../interfaces/ISleekGrid.md#getdataitemvalueforcolumn)

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/grid/sleekgrid.tsx:1858](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1858)

Returns view length (via `getLength()` when a DataView is attached).

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataLength`](../interfaces/ISleekGrid.md#getdatalength)

***

### getDisplayedScrollbarDimensions()

> **getDisplayedScrollbarDimensions**(): `object`

Defined in: [src/grid/sleekgrid.tsx:574](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L574)

Returns the currently displayed (reserved) scrollbar space, accounting
for auto/hidden scrollbars.

#### Returns

`object`

Object with `width` and `height` of displayed scrollbar area.

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDisplayedScrollbarDimensions`](../interfaces/ISleekGrid.md#getdisplayedscrollbardimensions)

***

### getEditController()

> **getEditController**(): [`EditController`](../interfaces/EditController.md)

Defined in: [src/grid/sleekgrid.tsx:1365](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1365)

Returns the grid's internal `EditController` (commit/cancel) bound to this instance.

#### Returns

[`EditController`](../interfaces/EditController.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditController`](../interfaces/ISleekGrid.md#geteditcontroller)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](../interfaces/EditorFactory.md)

Defined in: [src/grid/sleekgrid.tsx:1351](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1351)

Returns the `editorFactory` from current grid options.

#### Returns

[`EditorFactory`](../interfaces/EditorFactory.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditorFactory`](../interfaces/ISleekGrid.md#geteditorfactory)

***

### getEditorLock()

> **getEditorLock**(): [`EditorLock`](EditorLock.md)

Defined in: [src/grid/sleekgrid.tsx:1358](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1358)

Returns the current `EditorLock` controlling concurrent edits.

#### Returns

[`EditorLock`](EditorLock.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditorLock`](../interfaces/ISleekGrid.md#geteditorlock)

***

### getFooterRow()

> **getFooterRow**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:933](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L933)

Returns the footer-row container for the main band.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFooterRow`](../interfaces/ISleekGrid.md#getfooterrow)

***

### getFooterRowColumn()

> **getFooterRowColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:941](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L941)

Returns the footer-row cell node for `cell`.

#### Parameters

##### cell

Visible column index or column id.

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFooterRowColumn`](../interfaces/ISleekGrid.md#getfooterrowcolumn)

***

### getFormatter()

> **getFormatter**(`row`, `column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:2022](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2022)

Resolves the formatter for a cell, accounting for row/column metadata,
`formatterFactory` and fallbacks (`defaultFormat`/`defaultFormatter`).

#### Parameters

##### row

`number`

View row index.

##### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column definition.

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFormatter`](../interfaces/ISleekGrid.md#getformatter)

***

### getFormatterContext()

> **getFormatterContext**(`row`, `cell`): [`FormatterContext`](../interfaces/FormatterContext.md)

Defined in: [src/grid/sleekgrid.tsx:2080](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2080)

Creates a [FormatterContext](../interfaces/FormatterContext.md) for the given `row`/`cell`.

#### Parameters

##### row

`number`

View row index.

##### cell

`number`

Cell/column index.

#### Returns

[`FormatterContext`](../interfaces/FormatterContext.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFormatterContext`](../interfaces/ISleekGrid.md#getformattercontext)

***

### getGridPosition()

> **getGridPosition**(): [`Position`](../interfaces/Position.md)

Defined in: [src/grid/sleekgrid.tsx:3963](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3963)

Returns the absolute box of the grid container (for editor positioning).

#### Returns

[`Position`](../interfaces/Position.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getGridPosition`](../interfaces/ISleekGrid.md#getgridposition)

***

### getGroupingPanel()

> **getGroupingPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:897](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L897)

Returns the grouping panel container, if created.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getGroupingPanel`](../interfaces/ISleekGrid.md#getgroupingpanel)

***

### getHeader()

> **getHeader**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:875](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L875)

Returns the header column container for the main band.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeader`](../interfaces/ISleekGrid.md#getheader)

***

### getHeaderColumn()

> **getHeaderColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:883](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L883)

Returns the header cell node for `cell` (id or visible index).

#### Parameters

##### cell

Visible column index or column id.

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderColumn`](../interfaces/ISleekGrid.md#getheadercolumn)

***

### getHeaderRow()

> **getHeaderRow**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:911](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L911)

Returns the header-row (filter row) container for the main band.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderRow`](../interfaces/ISleekGrid.md#getheaderrow)

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:919](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L919)

Returns the header-row cell node for `cell`.

#### Parameters

##### cell

Visible column index or column id.

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderRowColumn`](../interfaces/ISleekGrid.md#getheaderrowcolumn)

***

### getLayoutInfo()

> **getLayoutInfo**(): [`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

Defined in: [src/grid/sleekgrid.tsx:611](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L611)

Returns summarized layout support/indices for the current layout engine.

#### Returns

[`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

[GridLayoutInfo](../type-aliases/GridLayoutInfo.md) with frozen/pinned counters and capability flags.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getLayoutInfo`](../interfaces/ISleekGrid.md#getlayoutinfo)

***

### getOptions()

> **getOptions**(): [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1723](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1723)

Returns current merged grid options.

#### Returns

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getOptions`](../interfaces/ISleekGrid.md#getoptions)

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](../interfaces/GridPlugin.md)

Defined in: [src/grid/sleekgrid.tsx:532](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L532)

Looks up a registered plugin by its `pluginName`.

#### Parameters

##### name

`string`

Plugin name.

#### Returns

[`GridPlugin`](../interfaces/GridPlugin.md)

Matching plugin or `undefined`.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getPluginByName`](../interfaces/ISleekGrid.md#getpluginbyname)

***

### getPreHeaderPanel()

> **getPreHeaderPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:904](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L904)

Returns the (legacy) pre-header panel node inside the grouping panel.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getPreHeaderPanel`](../interfaces/ISleekGrid.md#getpreheaderpanel)

***

### getRenderedRange()

> **getRenderedRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2547](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2547)

Returns the rendered range including buffers (expanded beyond the viewport).

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getRenderedRange`](../interfaces/ISleekGrid.md#getrenderedrange)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

Defined in: [src/grid/sleekgrid.tsx:3610](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3610)

Resolves the view row index from a row node (`data-row` or cache).

#### Parameters

##### rowNode

`Element`

Row element.

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getRowFromNode`](../interfaces/ISleekGrid.md#getrowfromnode)

***

### getScrollBarDimensions()

> **getScrollBarDimensions**(): `object`

Defined in: [src/grid/sleekgrid.tsx:565](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L565)

Returns native scrollbar thickness for the current environment.

#### Returns

`object`

Object with `width` and `height` in pixels.

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getScrollBarDimensions`](../interfaces/ISleekGrid.md#getscrollbardimensions)

***

### getScrollContainerX()

> **getScrollContainerX**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:2399](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2399)

Returns the horizontal scroll container (main body viewport).

#### Returns

`HTMLElement`

***

### getScrollContainerY()

> **getScrollContainerY**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:2406](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2406)

Returns the vertical scroll container (main body viewport).

#### Returns

`HTMLElement`

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/grid/sleekgrid.tsx:4577](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4577)

Returns selected view rows (delegates to the attached selection model).

#### Returns

`number`[]

#### Throws

When no selection model is attached.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSelectedRows`](../interfaces/ISleekGrid.md#getselectedrows)

***

### getSelectionModel()

> **getSelectionModel**(): [`SelectionModel`](../interfaces/SelectionModel.md)

Defined in: [src/grid/sleekgrid.tsx:592](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L592)

Returns the currently attached selection model, if any.

#### Returns

[`SelectionModel`](../interfaces/SelectionModel.md)

The active [SelectionModel](../interfaces/SelectionModel.md).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSelectionModel`](../interfaces/ISleekGrid.md#getselectionmodel)

***

### getSortColumns()

> **getSortColumns**(): [`ColumnSort`](../interfaces/ColumnSort.md)[]

Defined in: [src/grid/sleekgrid.tsx:1469](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1469)

Returns the active sort descriptors.

#### Returns

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSortColumns`](../interfaces/ISleekGrid.md#getsortcolumns)

***

### getTopPanel()

> **getTopPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:1886](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1886)

Returns the top panel container element.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getTopPanel`](../interfaces/ISleekGrid.md#gettoppanel)

***

### getTotalsFormatter()

> **getTotalsFormatter**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:2097](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2097)

Resolves the group-totals formatter for a column (or its totals variant).

#### Parameters

##### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column whose totals representation is needed.

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getTotalsFormatter`](../interfaces/ISleekGrid.md#gettotalsformatter)

***

### getUID()

> **getUID**(): `string`

Defined in: [src/grid/sleekgrid.tsx:1965](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1965)

Returns the unique CSS-namespace UID for this grid instance.

#### Returns

`string`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getUID`](../interfaces/ISleekGrid.md#getuid)

***

### getViewport()

> **getViewport**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2515](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2515)

Returns the current visible viewport range.

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getViewport`](../interfaces/ISleekGrid.md#getviewport)

***

### getViewportNode()

> **getViewportNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:669](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L669)

Returns the viewport that owns `row`/`cell` (the canvas's parent).

#### Parameters

##### row?

`number`

Optional row hint.

##### cell?

`number`

Optional cell hint.

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getViewportNode`](../interfaces/ISleekGrid.md#getviewportnode)

***

### getVisibleRange()

> **getVisibleRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2524](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2524)

Returns the visible (clipped to viewport) range.

#### Parameters

##### viewportTop?

`number`

Optional scroll top override.

##### viewportLeft?

`number`

Optional scroll left override.

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getVisibleRange`](../interfaces/ISleekGrid.md#getvisiblerange)

***

### gotoCell()

> **gotoCell**(`row`, `cell`, `forceEdit?`): `void`

Defined in: [src/grid/sleekgrid.tsx:4444](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4444)

Navigates to `row`/`cell`, optionally forcing edit mode.

#### Parameters

##### row

`number`

Target row.

##### cell

`number`

Target cell.

##### forceEdit?

`boolean`

When `true`, forces editor activation.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`gotoCell`](../interfaces/ISleekGrid.md#gotocell)

***

### init()

> **init**(): `void`

Defined in: [src/grid/sleekgrid.tsx:384](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L384)

Performs one-time DOM and event binding after construction. No-ops if
already initialized. Computes sizes, creates headers/footers and binds
scroll/keyboard/mouse handlers.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`init`](../interfaces/ISleekGrid.md#init)

***

### invalidate()

> **invalidate**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2156)

Invalidates and re-renders the entire grid (rows and totals).

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidate`](../interfaces/ISleekGrid.md#invalidate)

***

### invalidateAllRows()

> **invalidateAllRows**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2166)

Invalidates all cached rows, forcing a full re-render of visible rows.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateAllRows`](../interfaces/ISleekGrid.md#invalidateallrows)

***

### invalidateColumns()

> **invalidateColumns**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1699](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1699)

Invalidates column chrome and virtualization state after column changes.
Recomputes pinning, re-creates headers/footers, rebuilds CSS rules and re-renders.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateColumns`](../interfaces/ISleekGrid.md#invalidatecolumns)

***

### invalidateRow()

> **invalidateRow**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:2263](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2263)

Invalidates a single view row.

#### Parameters

##### row

`number`

View row index.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateRow`](../interfaces/ISleekGrid.md#invalidaterow)

***

### invalidateRows()

> **invalidateRows**(`rows`): `void`

Defined in: [src/grid/sleekgrid.tsx:2241](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2241)

Invalidates specific view rows so they are re-rendered.

#### Parameters

##### rows

`number`[]

View row indices to invalidate.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateRows`](../interfaces/ISleekGrid.md#invalidaterows)

***

### navigate()

> **navigate**(`dir`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4260](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4260)

Generic navigation dispatcher used by the key handler.

#### Parameters

##### dir

`string`

Direction (`"up"`, `"down"`, `"left"`, `"right"`, `"next"`, `"prev"`, `"home"`, `"end"`).

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigate`](../interfaces/ISleekGrid.md#navigate)

***

### navigateBottom()

> **navigateBottom**(): `void`

Defined in: [src/grid/sleekgrid.tsx:4123](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4123)

Navigates to the last data row.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateBottom`](../interfaces/ISleekGrid.md#navigatebottom)

***

### navigateDown()

> **navigateDown**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4205](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4205)

Navigates one row downward.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateDown`](../interfaces/ISleekGrid.md#navigatedown)

***

### navigateLeft()

> **navigateLeft**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4198](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4198)

Navigates one cell to the left.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateLeft`](../interfaces/ISleekGrid.md#navigateleft)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4219](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4219)

Navigates to the next tabbable cell (including next row wrap).

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateNext`](../interfaces/ISleekGrid.md#navigatenext)

***

### navigatePageDown()

> **navigatePageDown**(): `void`

Defined in: [src/grid/sleekgrid.tsx:4102](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4102)

Scrolls by one page downward (or paging gap) and updates active cell if navigable.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePageDown`](../interfaces/ISleekGrid.md#navigatepagedown)

***

### navigatePageUp()

> **navigatePageUp**(): `void`

Defined in: [src/grid/sleekgrid.tsx:4109](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4109)

Scrolls by one page upward and updates active cell if navigable.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePageUp`](../interfaces/ISleekGrid.md#navigatepageup)

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4226](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4226)

Navigates to the previous tabbable cell (including wrap to prior row).

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePrev`](../interfaces/ISleekGrid.md#navigateprev)

***

### navigateRight()

> **navigateRight**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4191](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4191)

Navigates one cell to the right.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRight`](../interfaces/ISleekGrid.md#navigateright)

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4240](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4240)

Navigates to the last focusable cell in the active row.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRowEnd`](../interfaces/ISleekGrid.md#navigaterowend)

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4233](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4233)

Navigates to the first focusable cell in the active row.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRowStart`](../interfaces/ISleekGrid.md#navigaterowstart)

***

### navigateTop()

> **navigateTop**(): `void`

Defined in: [src/grid/sleekgrid.tsx:4116](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4116)

Navigates to the first data row.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateTop`](../interfaces/ISleekGrid.md#navigatetop)

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4132](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4132)

Navigates to a specific row, preserving current column when possible.

#### Parameters

##### row

`number`

Target row index.

#### Returns

`boolean`

`true` (always reported as handled).

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateToRow`](../interfaces/ISleekGrid.md#navigatetorow)

***

### navigateUp()

> **navigateUp**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4212](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4212)

Navigates one row upward.

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateUp`](../interfaces/ISleekGrid.md#navigateup)

***

### prepareForOptionsChange()

> `protected` **prepareForOptionsChange**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1727](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1727)

#### Returns

`void`

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/grid/sleekgrid.tsx:506](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L506)

Prepend-registers a plugin and calls its `init(this)` immediately.

#### Parameters

##### plugin

[`GridPlugin`](../interfaces/GridPlugin.md)

Grid plugin to add.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`registerPlugin`](../interfaces/ISleekGrid.md#registerplugin)

***

### removeCellCssStyles()

> **removeCellCssStyles**(`key`): `void`

Defined in: [src/grid/sleekgrid.tsx:3233](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3233)

Removes styles previously added via [SleekGrid.addCellCssStyles](#addcellcssstyles).

#### Parameters

##### key

`string`

Namespace key.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`removeCellCssStyles`](../interfaces/ISleekGrid.md#removecellcssstyles)

***

### render()

> **render**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2934](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2934)

Synchronously renders rows/cells for the current viewport, with throttling.
Coalesces calls via a pending `_hRender` timeout when scrolling fast.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`render`](../interfaces/ISleekGrid.md#render)

***

### reorderColumns()

> **reorderColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1666](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1666)

Reorders columns by `columnIds` to become the new visible order.

#### Parameters

##### columnIds

`string`[]

Desired column id order.

##### opt?

###### notify?

`boolean`

Whether to emit `onColumnsReordered` (default `true`).

###### setVisible?

`string`[]

When provided, visibility is set to these ids before reorder.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`reorderColumns`](../interfaces/ISleekGrid.md#reordercolumns)

***

### resetActiveCell()

> **resetActiveCell**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3689](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3689)

Clears the currently active cell (without scrolling).

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`resetActiveCell`](../interfaces/ISleekGrid.md#resetactivecell)

***

### resizeCanvas()

> **resizeCanvas**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2364](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2364)

Recalculates viewport size and updates virtual height/scroll bounds.
Call when the container size changes externally.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`resizeCanvas`](../interfaces/ISleekGrid.md#resizecanvas)

***

### scrollActiveCellIntoView()

> **scrollActiveCellIntoView**(): `void`

Defined in: [src/grid/sleekgrid.tsx:4018](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4018)

Scrolls the active cell into view if one exists.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollActiveCellIntoView`](../interfaces/ISleekGrid.md#scrollactivecellintoview)

***

### scrollCellIntoView()

> **scrollCellIntoView**(`row`, `cell`, `doPaging?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3714](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3714)

Ensures `row`/`cell` is visible, paging when needed.

#### Parameters

##### row

`number`

Target view row.

##### cell

`number`

Target cell.

##### doPaging?

`boolean`

When `true`, pages before scrolling.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollCellIntoView`](../interfaces/ISleekGrid.md#scrollcellintoview)

***

### scrollColumnIntoView()

> **scrollColumnIntoView**(`cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:3729](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3729)

Horizontally scrolls `cell` into view.

#### Parameters

##### cell

`number`

Target visible cell index.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollColumnIntoView`](../interfaces/ISleekGrid.md#scrollcolumnintoview)

***

### scrollRowIntoView()

> **scrollRowIntoView**(`row`, `doPaging?`): `void`

Defined in: [src/grid/sleekgrid.tsx:4029](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4029)

Vertically scrolls `row` into view (pads for frozen rows).

#### Parameters

##### row

`number`

View row index.

##### doPaging?

`boolean`

When `true`, page-bumps instead of minimal scroll.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollRowIntoView`](../interfaces/ISleekGrid.md#scrollrowintoview)

***

### scrollRowToTop()

> **scrollRowToTop**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:4061](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4061)

Scrolls so that `row` is at the top of the viewport.

#### Parameters

##### row

`number`

Target row.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollRowToTop`](../interfaces/ISleekGrid.md#scrollrowtotop)

***

### setActiveCell()

> **setActiveCell**(`row`, `cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:4327](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4327)

Activates the cell at `row`/`cell` (no-op if un-navigable or out of bounds).

#### Parameters

##### row

`number`

Target row.

##### cell

`number`

Target cell.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setActiveCell`](../interfaces/ISleekGrid.md#setactivecell)

***

### setActiveRow()

> **setActiveRow**(`row`, `cell`, `suppressScrollIntoView?`): `void`

Defined in: [src/grid/sleekgrid.tsx:4348](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4348)

Marks a row as active (for row-selection integration) without necessarily changing the active cell DOM.

#### Parameters

##### row

`number`

Row to activate.

##### cell

`number`

Preferred cell to anchor on.

##### suppressScrollIntoView?

`boolean`

When `true`, does not scroll the row/cell into view.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setActiveRow`](../interfaces/ISleekGrid.md#setactiverow)

***

### setCellCssStyles()

> **setCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/grid/sleekgrid.tsx:3249](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3249)

Replaces styles for `key` and notifies `onCellCssStylesChanged`.

#### Parameters

##### key

`string`

Namespace key.

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

New hash.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setCellCssStyles`](../interfaces/ISleekGrid.md#setcellcssstyles)

***

### setColumnHeaderVisibility()

> **setColumnHeaderVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1905](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1905)

Shows or hides column headers.

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setColumnHeaderVisibility`](../interfaces/ISleekGrid.md#setcolumnheadervisibility)

***

### setColumns()

> **setColumns**(`columns`): `void`

Defined in: [src/grid/sleekgrid.tsx:1627](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1627)

Replaces the column set and invalidates layout. Tries to preserve
identity when called with a permutation of `getColumns()`.

#### Parameters

##### columns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

New columns in desired order.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setColumns`](../interfaces/ISleekGrid.md#setcolumns)

***

### setData()

> **setData**(`newData`, `scrollToTop?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1837](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1837)

Replaces the data source and rebinds view events.

#### Parameters

##### newData

`any`

New DataView or plain array.

##### scrollToTop?

`boolean`

When `true`, scrolls to `y = 0`.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setData`](../interfaces/ISleekGrid.md#setdata)

***

### setFooterRowVisibility()

> **setFooterRowVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1916](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1916)

Shows or hides the footer row and updates grand totals when becoming visible.

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setFooterRowVisibility`](../interfaces/ISleekGrid.md#setfooterrowvisibility)

***

### setGroupingPanelVisibility()

> **setGroupingPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1928](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1928)

Shows or hides the grouping panel.

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setGroupingPanelVisibility`](../interfaces/ISleekGrid.md#setgroupingpanelvisibility)

***

### setHeaderRowVisibility()

> **setHeaderRowVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1948](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1948)

Shows or hides the header row (filter row).

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setHeaderRowVisibility`](../interfaces/ISleekGrid.md#setheaderrowvisibility)

***

### setOptions()

> **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1745](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1745)

Merges `args` into options, validates/updates layout signals and optionally
re-renders. Commits or cancels the active edit before changing options.

#### Parameters

##### args

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

Partial options to merge.

##### suppressRender?

`boolean`

When `true`, suppresses render pass after set.

##### suppressColumnSet?

`boolean`

When `true`, suppresses `setColumns` from `args.columns`.

##### suppressSetOverflow?

`boolean`

When `true`, suppresses `setOverflow()` adjustment.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setOptions`](../interfaces/ISleekGrid.md#setoptions)

***

### setPreHeaderPanelVisibility()

> **setPreHeaderPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1940](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1940)

Legacy alias for [SleekGrid.setGroupingPanelVisibility](#setgroupingpanelvisibility).

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setPreHeaderPanelVisibility`](../interfaces/ISleekGrid.md#setpreheaderpanelvisibility)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/grid/sleekgrid.tsx:4589](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4589)

Sets selection from view row indices via the attached selection model.

#### Parameters

##### rows

`number`[]

Row indices to select.

#### Returns

`void`

#### Throws

When no selection model is attached.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSelectedRows`](../interfaces/ISleekGrid.md#setselectedrows)

***

### setSelectionModel()

> **setSelectionModel**(`model`): `void`

Defined in: [src/grid/sleekgrid.tsx:543](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L543)

Attaches a selection model, unregistering any previous one.

#### Parameters

##### model

[`SelectionModel`](../interfaces/SelectionModel.md)

The new selection model, or `null` to detach.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSelectionModel`](../interfaces/ISleekGrid.md#setselectionmodel)

***

### setSortColumn()

> **setSortColumn**(`columnId`, `ascending`): `void`

Defined in: [src/grid/sleekgrid.tsx:1427](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1427)

Sets single-column sorting state.

#### Parameters

##### columnId

`string`

Column id to sort by.

##### ascending

`boolean`

Whether ascending.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSortColumn`](../interfaces/ISleekGrid.md#setsortcolumn)

***

### setSortColumns()

> **setSortColumns**(`cols`): `void`

Defined in: [src/grid/sleekgrid.tsx:1435](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1435)

Sets multi-column sorting state and updates header sort indicators.

#### Parameters

##### cols

[`ColumnSort`](../interfaces/ColumnSort.md)[]

Sort descriptors (`columnId` + `sortAsc`).

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSortColumns`](../interfaces/ISleekGrid.md#setsortcolumns)

***

### setTopPanelVisibility()

> **setTopPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1894](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1894)

Shows or hides the top panel.

#### Parameters

##### visible

`boolean`

Whether to show.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setTopPanelVisibility`](../interfaces/ISleekGrid.md#settoppanelvisibility)

***

### setVisibleColumns()

> **setVisibleColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1682](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1682)

Shows only the columns whose ids are in `columnIds`, optionally reordering them.

#### Parameters

##### columnIds

`string`[]

Ids of columns to make visible, in desired order.

##### opt?

###### notify?

`boolean`

Whether to emit `onColumnsReordered`.

###### reorder?

`boolean`

When `true` (default), reorders to `columnIds` order.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setVisibleColumns`](../interfaces/ISleekGrid.md#setvisiblecolumns)

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/grid/sleekgrid.tsx:515](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L515)

Unregisters a plugin by identity, calling `destroy()` when available.

#### Parameters

##### plugin

[`GridPlugin`](../interfaces/GridPlugin.md)

Plugin instance previously passed to [SleekGrid.registerPlugin](#registerplugin).

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`unregisterPlugin`](../interfaces/ISleekGrid.md#unregisterplugin)

***

### updateCell()

> **updateCell**(`row`, `cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:2272](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2272)

Re-renders a single cell via the cell's formatter and invalidates async post results.

#### Parameters

##### row

`number`

View row index.

##### cell

`number`

Cell/column index.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateCell`](../interfaces/ISleekGrid.md#updatecell)

***

### updateColumnHeader()

> **updateColumnHeader**(`columnId`, `title?`, `toolTip?`): `void`

Defined in: [src/grid/sleekgrid.tsx:819](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L819)

Updates a header's title/tooltip in place, re-triggering header lifecycle events.

#### Parameters

##### columnId

`string`

Target column id.

##### title?

New title text or formatter.

`string` | [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`any`\>

##### toolTip?

`string`

New title attribute.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateColumnHeader`](../interfaces/ISleekGrid.md#updatecolumnheader)

***

### updatePagingStatusFromView()

> **updatePagingStatusFromView**(`pagingInfo`): `void`

Defined in: [src/grid/sleekgrid.tsx:2391](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2391)

Updates add-new-row paging state from a paging descriptor.

#### Parameters

##### pagingInfo

Page size/num/totalPages.

###### pageNum

`number`

###### pageSize

`number`

###### totalPages

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updatePagingStatusFromView`](../interfaces/ISleekGrid.md#updatepagingstatusfromview)

***

### updateRow()

> **updateRow**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:2302](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2302)

Re-renders all cells of the given row.

#### Parameters

##### row

`number`

View row index.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateRow`](../interfaces/ISleekGrid.md#updaterow)

***

### updateRowCount()

> **updateRowCount**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2414](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2414)

Recomputes virtual/real scroll heights, page offsets and active cell state
after row count or scrollbar visibility changes.

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateRowCount`](../interfaces/ISleekGrid.md#updaterowcount)
