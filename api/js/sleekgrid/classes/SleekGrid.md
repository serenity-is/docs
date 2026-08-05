[@serenity-is/sleekgrid](../README.md) / SleekGrid

# Class: SleekGrid\<TItem\>

Defined in: [src/grid/sleekgrid.tsx:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L34)

## Type Parameters

### TItem

`TItem` = `any`

## Implements

- [`ISleekGrid`](../interfaces/ISleekGrid.md)\<`TItem`\>

## Constructors

### Constructor

> **new SleekGrid**\<`TItem`\>(`container`, `data`, `columns`, `options`): `SleekGrid`\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L166)

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

`SleekGrid`\<`TItem`\>

## Properties

### onActiveCellChanged

> `readonly` **onActiveCellChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md)\>

Defined in: [src/grid/sleekgrid.tsx:127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L127)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onActiveCellChanged`](../interfaces/ISleekGrid.md#onactivecellchanged)

***

### onActiveCellPositionChanged

> `readonly` **onActiveCellPositionChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L128)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onActiveCellPositionChanged`](../interfaces/ISleekGrid.md#onactivecellpositionchanged)

***

### onAddNewRow

> `readonly` **onAddNewRow**: [`EventEmitter`](EventEmitter.md)\<[`ArgsAddNewRow`](../interfaces/ArgsAddNewRow.md)\>

Defined in: [src/grid/sleekgrid.tsx:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L129)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onAddNewRow`](../interfaces/ISleekGrid.md#onaddnewrow)

***

### onAfterInit

> `readonly` **onAfterInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:131](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L131)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onAfterInit`](../interfaces/ISleekGrid.md#onafterinit)

***

### onBeforeCellEditorDestroy

> `readonly` **onBeforeCellEditorDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsEditorDestroy`](../interfaces/ArgsEditorDestroy.md)\>

Defined in: [src/grid/sleekgrid.tsx:132](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L132)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeCellEditorDestroy`](../interfaces/ISleekGrid.md#onbeforecelleditordestroy)

***

### onBeforeDestroy

> `readonly` **onBeforeDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:133](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L133)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeDestroy`](../interfaces/ISleekGrid.md#onbeforedestroy)

***

### onBeforeEditCell

> `readonly` **onBeforeEditCell**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellEdit`](../interfaces/ArgsCellEdit.md)\>

Defined in: [src/grid/sleekgrid.tsx:134](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L134)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeEditCell`](../interfaces/ISleekGrid.md#onbeforeeditcell)

***

### onBeforeFooterRowCellDestroy

> `readonly` **onBeforeFooterRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:135](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L135)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeFooterRowCellDestroy`](../interfaces/ISleekGrid.md#onbeforefooterrowcelldestroy)

***

### onBeforeHeaderCellDestroy

> `readonly` **onBeforeHeaderCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:136](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L136)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeHeaderCellDestroy`](../interfaces/ISleekGrid.md#onbeforeheadercelldestroy)

***

### onBeforeHeaderRowCellDestroy

> `readonly` **onBeforeHeaderRowCellDestroy**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:137](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L137)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onBeforeHeaderRowCellDestroy`](../interfaces/ISleekGrid.md#onbeforeheaderrowcelldestroy)

***

### onCellChange

> `readonly` **onCellChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCellChange`](../interfaces/ArgsCellChange.md)\>

Defined in: [src/grid/sleekgrid.tsx:138](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L138)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCellChange`](../interfaces/ISleekGrid.md#oncellchange)

***

### onCellCssStylesChanged

> `readonly` **onCellCssStylesChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCssStyle`](../interfaces/ArgsCssStyle.md)\>

Defined in: [src/grid/sleekgrid.tsx:139](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L139)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCellCssStylesChanged`](../interfaces/ISleekGrid.md#oncellcssstyleschanged)

***

### onClick

> `readonly` **onClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:140](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L140)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onClick`](../interfaces/ISleekGrid.md#onclick)

***

### onColumnsReordered

> `readonly` **onColumnsReordered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:141](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L141)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onColumnsReordered`](../interfaces/ISleekGrid.md#oncolumnsreordered)

***

### onColumnsResized

> `readonly` **onColumnsResized**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:142](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L142)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onColumnsResized`](../interfaces/ISleekGrid.md#oncolumnsresized)

***

### onCompositeEditorChange

> `readonly` **onCompositeEditorChange**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:143](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L143)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onCompositeEditorChange`](../interfaces/ISleekGrid.md#oncompositeeditorchange)

***

### onContextMenu

> `readonly` **onContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:144](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L144)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onContextMenu`](../interfaces/ISleekGrid.md#oncontextmenu)

***

### onDblClick

> `readonly` **onDblClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:145](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L145)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDblClick`](../interfaces/ISleekGrid.md#ondblclick)

***

### onDrag

> `readonly` **onDrag**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:146](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L146)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDrag`](../interfaces/ISleekGrid.md#ondrag)

***

### onDragEnd

> `readonly` **onDragEnd**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:147](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L147)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragEnd`](../interfaces/ISleekGrid.md#ondragend)

***

### onDragInit

> `readonly` **onDragInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:148](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L148)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragInit`](../interfaces/ISleekGrid.md#ondraginit)

***

### onDragStart

> `readonly` **onDragStart**: [`EventEmitter`](EventEmitter.md)\<[`ArgsDrag`](../interfaces/ArgsDrag.md), `UIEvent`\>

Defined in: [src/grid/sleekgrid.tsx:149](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L149)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onDragStart`](../interfaces/ISleekGrid.md#ondragstart)

***

### onFooterRowCellRendered

> `readonly` **onFooterRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L150)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onFooterRowCellRendered`](../interfaces/ISleekGrid.md#onfooterrowcellrendered)

***

### onHeaderCellRendered

> `readonly` **onHeaderCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:151](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L151)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderCellRendered`](../interfaces/ISleekGrid.md#onheadercellrendered)

***

### onHeaderClick

> `readonly` **onHeaderClick**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:152](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L152)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderClick`](../interfaces/ISleekGrid.md#onheaderclick)

***

### onHeaderContextMenu

> `readonly` **onHeaderContextMenu**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:153](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L153)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderContextMenu`](../interfaces/ISleekGrid.md#onheadercontextmenu)

***

### onHeaderMouseEnter

> `readonly` **onHeaderMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:154](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L154)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderMouseEnter`](../interfaces/ISleekGrid.md#onheadermouseenter)

***

### onHeaderMouseLeave

> `readonly` **onHeaderMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumn`](../interfaces/ArgsColumn.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:155](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L155)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderMouseLeave`](../interfaces/ISleekGrid.md#onheadermouseleave)

***

### onHeaderRowCellRendered

> `readonly` **onHeaderRowCellRendered**: [`EventEmitter`](EventEmitter.md)\<[`ArgsColumnNode`](../interfaces/ArgsColumnNode.md)\>

Defined in: [src/grid/sleekgrid.tsx:156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L156)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onHeaderRowCellRendered`](../interfaces/ISleekGrid.md#onheaderrowcellrendered)

***

### onKeyDown

> `readonly` **onKeyDown**: [`EventEmitter`](EventEmitter.md)\<[`ArgsCell`](../interfaces/ArgsCell.md), `KeyboardEvent`\>

Defined in: [src/grid/sleekgrid.tsx:157](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L157)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onKeyDown`](../interfaces/ISleekGrid.md#onkeydown)

***

### onMouseEnter

> `readonly` **onMouseEnter**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:158](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L158)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onMouseEnter`](../interfaces/ISleekGrid.md#onmouseenter)

***

### onMouseLeave

> `readonly` **onMouseLeave**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md), `MouseEvent`\>

Defined in: [src/grid/sleekgrid.tsx:159](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L159)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onMouseLeave`](../interfaces/ISleekGrid.md#onmouseleave)

***

### onScroll

> `readonly` **onScroll**: [`EventEmitter`](EventEmitter.md)\<[`ArgsScroll`](../interfaces/ArgsScroll.md)\>

Defined in: [src/grid/sleekgrid.tsx:160](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L160)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onScroll`](../interfaces/ISleekGrid.md#onscroll)

***

### onSelectedRowsChanged

> `readonly` **onSelectedRowsChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSelectedRowsChange`](../interfaces/ArgsSelectedRowsChange.md)\>

Defined in: [src/grid/sleekgrid.tsx:161](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L161)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onSelectedRowsChanged`](../interfaces/ISleekGrid.md#onselectedrowschanged)

***

### onSort

> `readonly` **onSort**: [`EventEmitter`](EventEmitter.md)\<[`ArgsSort`](../interfaces/ArgsSort.md)\>

Defined in: [src/grid/sleekgrid.tsx:162](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L162)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onSort`](../interfaces/ISleekGrid.md#onsort)

***

### onValidationError

> `readonly` **onValidationError**: [`EventEmitter`](EventEmitter.md)\<[`ArgsValidationError`](../interfaces/ArgsValidationError.md)\>

Defined in: [src/grid/sleekgrid.tsx:163](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L163)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onValidationError`](../interfaces/ISleekGrid.md#onvalidationerror)

***

### onViewportChanged

> `readonly` **onViewportChanged**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L164)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`onViewportChanged`](../interfaces/ISleekGrid.md#onviewportchanged)

***

### onAfterInit

> `readonly` `static` **onAfterInit**: [`EventEmitter`](EventEmitter.md)\<[`ArgsGrid`](../interfaces/ArgsGrid.md)\>

Defined in: [src/grid/sleekgrid.tsx:130](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L130)

## Methods

### addCellCssStyles()

> **addCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/grid/sleekgrid.tsx:2853](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2853)

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`addCellCssStyles`](../interfaces/ISleekGrid.md#addcellcssstyles)

***

### autosizeColumns()

> **autosizeColumns**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1210](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1210)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`autosizeColumns`](../interfaces/ISleekGrid.md#autosizecolumns)

***

### cancelCurrentEdit()

> **cancelCurrentEdit**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:4011](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4011)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`cancelCurrentEdit`](../interfaces/ISleekGrid.md#cancelcurrentedit)

***

### canCellBeActive()

> **canCellBeActive**(`row`, `cell`, `tab?`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3840](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3840)

#### Parameters

##### row

`number`

##### cell

`number`

##### tab?

`boolean`

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`canCellBeActive`](../interfaces/ISleekGrid.md#cancellbeactive)

***

### canCellBeSelected()

> **canCellBeSelected**(`row`, `cell`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3887](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3887)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`canCellBeSelected`](../interfaces/ISleekGrid.md#cancellbeselected)

***

### clearTextSelection()

> **clearTextSelection**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3380](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3380)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`clearTextSelection`](../interfaces/ISleekGrid.md#cleartextselection)

***

### columnsResized()

> **columnsResized**(`invalidate`): `void`

Defined in: [src/grid/sleekgrid.tsx:1050](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1050)

#### Parameters

##### invalidate

`boolean` = `true`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`columnsResized`](../interfaces/ISleekGrid.md#columnsresized)

***

### commitCurrentEdit()

> **commitCurrentEdit**(`opt?`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3932](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3932)

#### Parameters

##### opt?

###### forceValueChange?

`boolean`

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`commitCurrentEdit`](../interfaces/ISleekGrid.md#commitcurrentedit)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1127](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1127)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`destroy`](../interfaces/ISleekGrid.md#destroy)

***

### editActiveCell()

> **editActiveCell**(`editor?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3437](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3437)

#### Parameters

##### editor?

[`EditorClass`](../interfaces/EditorClass.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`editActiveCell`](../interfaces/ISleekGrid.md#editactivecell)

***

### flashCell()

> **flashCell**(`row`, `cell`, `speed?`): `void`

Defined in: [src/grid/sleekgrid.tsx:2888](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2888)

#### Parameters

##### row

`number`

##### cell

`number`

##### speed?

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`flashCell`](../interfaces/ISleekGrid.md#flashcell)

***

### focus()

> **focus**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3283](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3283)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`focus`](../interfaces/ISleekGrid.md#focus)

***

### getAbsoluteColumnMinWidth()

> **getAbsoluteColumnMinWidth**(): `number`

Defined in: [src/grid/sleekgrid.tsx:498](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L498)

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getAbsoluteColumnMinWidth`](../interfaces/ISleekGrid.md#getabsolutecolumnminwidth)

***

### getActiveCanvasNode()

> **getActiveCanvasNode**(`e?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:550](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L550)

#### Parameters

##### e?

###### target

`EventTarget`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCanvasNode`](../interfaces/ISleekGrid.md#getactivecanvasnode)

***

### getActiveCell()

> **getActiveCell**(): [`RowCell`](../interfaces/RowCell.md)

Defined in: [src/grid/sleekgrid.tsx:3561](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3561)

#### Returns

[`RowCell`](../interfaces/RowCell.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCell`](../interfaces/ISleekGrid.md#getactivecell)

***

### getActiveCellNode()

> **getActiveCellNode**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:3569](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3569)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveCellNode`](../interfaces/ISleekGrid.md#getactivecellnode)

***

### getActiveViewportNode()

> **getActiveViewportNode**(`e?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:569](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L569)

#### Parameters

##### e?

###### target

`EventTarget`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getActiveViewportNode`](../interfaces/ISleekGrid.md#getactiveviewportnode)

***

### getAllColumns()

> **getAllColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Defined in: [src/grid/sleekgrid.tsx:1337](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1337)

Returns all columns in the grid, including hidden ones, the order might not match visible columns due to pinning, ordering etc.

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getAllColumns`](../interfaces/ISleekGrid.md#getallcolumns)

***

### getCanvases()

> **getCanvases**(): `any`

Defined in: [src/grid/sleekgrid.tsx:545](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L545)

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCanvases`](../interfaces/ISleekGrid.md#getcanvases)

***

### getCanvasNode()

> **getCanvasNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:532](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L532)

#### Parameters

##### row?

`number`

##### cell?

`number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCanvasNode`](../interfaces/ISleekGrid.md#getcanvasnode)

***

### getCellCssStyles()

> **getCellCssStyles**(`key`): [`CellStylesHash`](../type-aliases/CellStylesHash.md)

Defined in: [src/grid/sleekgrid.tsx:2884](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2884)

#### Parameters

##### key

`string`

#### Returns

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellCssStyles`](../interfaces/ISleekGrid.md#getcellcssstyles)

***

### getCellEditor()

> **getCellEditor**(): [`Editor`](../interfaces/Editor.md)

Defined in: [src/grid/sleekgrid.tsx:3557](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3557)

#### Returns

[`Editor`](../interfaces/Editor.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellEditor`](../interfaces/ISleekGrid.md#getcelleditor)

***

### getCellFromEvent()

> **getCellFromEvent**(`e`): `object`

Defined in: [src/grid/sleekgrid.tsx:3226](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3226)

#### Parameters

##### e

`any`

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

Defined in: [src/grid/sleekgrid.tsx:3185](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3185)

#### Parameters

##### cellNode

`Element`

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellFromNode`](../interfaces/ISleekGrid.md#getcellfromnode)

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): `object`

Defined in: [src/grid/sleekgrid.tsx:3168](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3168)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellFromPoint`](../interfaces/ISleekGrid.md#getcellfrompoint)

***

### getCellNode()

> **getCellNode**(`row`, `cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:3805](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3805)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellNode`](../interfaces/ISleekGrid.md#getcellnode)

***

### getCellNodeBox()

> **getCellNodeBox**(`row`, `cell`): `object`

Defined in: [src/grid/sleekgrid.tsx:3246](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3246)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getCellNodeBox`](../interfaces/ISleekGrid.md#getcellnodebox)

***

### getColspan()

> **getColspan**(`row`, `cell`): `number`

Defined in: [src/grid/sleekgrid.tsx:3694](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3694)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColspan`](../interfaces/ISleekGrid.md#getcolspan)

***

### getColumnById()

> **getColumnById**(`id`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1202](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1202)

Gets a column by its ID. May also return hidden columns.

#### Parameters

##### id

`string`

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnById`](../interfaces/ISleekGrid.md#getcolumnbyid)

***

### getColumnFromNode()

> **getColumnFromNode**(`cellNode`): [`Column`](../interfaces/Column.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:3201](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3201)

#### Parameters

##### cellNode

`Element`

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnFromNode`](../interfaces/ISleekGrid.md#getcolumnfromnode)

***

### getColumnIndex()

> **getColumnIndex**(`id`, `opt?`): `number`

Defined in: [src/grid/sleekgrid.tsx:1206](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1206)

Returns a column's index in the visible columns list by its column ID. If opt.inAll is true, it will return index in all columns.

#### Parameters

##### id

`string`

##### opt?

###### inAll?

`boolean`

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumnIndex`](../interfaces/ISleekGrid.md#getcolumnindex)

***

### getColumns()

> **getColumns**(): [`Column`](../interfaces/Column.md)\<`TItem`\>[]

Defined in: [src/grid/sleekgrid.tsx:1341](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1341)

Returns only the visible columns in order

#### Returns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getColumns`](../interfaces/ISleekGrid.md#getcolumns)

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:1682](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1682)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getContainerNode`](../interfaces/ISleekGrid.md#getcontainernode)

***

### getData()

> **getData**(): `any`

Defined in: [src/grid/sleekgrid.tsx:1612](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1612)

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getData`](../interfaces/ISleekGrid.md#getdata)

***

### getDataItem()

> **getDataItem**(`row`): `TItem`

Defined in: [src/grid/sleekgrid.tsx:1629](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1629)

#### Parameters

##### row

`number`

#### Returns

`TItem`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataItem`](../interfaces/ISleekGrid.md#getdataitem)

***

### getDataItemValueForColumn()

> **getDataItemValueForColumn**(`item`, `columnDef`): `any`

Defined in: [src/grid/sleekgrid.tsx:1835](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1835)

#### Parameters

##### item

`TItem`

##### columnDef

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Returns

`any`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataItemValueForColumn`](../interfaces/ISleekGrid.md#getdataitemvalueforcolumn)

***

### getDataLength()

> **getDataLength**(): `number`

Defined in: [src/grid/sleekgrid.tsx:1616](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1616)

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDataLength`](../interfaces/ISleekGrid.md#getdatalength)

***

### getDisplayedScrollbarDimensions()

> **getDisplayedScrollbarDimensions**(): `object`

Defined in: [src/grid/sleekgrid.tsx:491](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L491)

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getDisplayedScrollbarDimensions`](../interfaces/ISleekGrid.md#getdisplayedscrollbardimensions)

***

### getEditController()

> **getEditController**(): [`EditController`](../interfaces/EditController.md)

Defined in: [src/grid/sleekgrid.tsx:1198](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1198)

#### Returns

[`EditController`](../interfaces/EditController.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditController`](../interfaces/ISleekGrid.md#geteditcontroller)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](../interfaces/EditorFactory.md)

Defined in: [src/grid/sleekgrid.tsx:1190](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1190)

#### Returns

[`EditorFactory`](../interfaces/EditorFactory.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditorFactory`](../interfaces/ISleekGrid.md#geteditorfactory)

***

### getEditorLock()

> **getEditorLock**(): [`EditorLock`](EditorLock.md)

Defined in: [src/grid/sleekgrid.tsx:1194](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1194)

#### Returns

[`EditorLock`](EditorLock.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getEditorLock`](../interfaces/ISleekGrid.md#geteditorlock)

***

### getFooterRow()

> **getFooterRow**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:788](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L788)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFooterRow`](../interfaces/ISleekGrid.md#getfooterrow)

***

### getFooterRowColumn()

> **getFooterRowColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:792](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L792)

#### Parameters

##### cell

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFooterRowColumn`](../interfaces/ISleekGrid.md#getfooterrowcolumn)

***

### getFormatter()

> **getFormatter**(`row`, `column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1737](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1737)

#### Parameters

##### row

`number`

##### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFormatter`](../interfaces/ISleekGrid.md#getformatter)

***

### getFormatterContext()

> **getFormatterContext**(`row`, `cell`): [`FormatterContext`](../interfaces/FormatterContext.md)

Defined in: [src/grid/sleekgrid.tsx:1790](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1790)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

[`FormatterContext`](../interfaces/FormatterContext.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getFormatterContext`](../interfaces/ISleekGrid.md#getformattercontext)

***

### getGridPosition()

> **getGridPosition**(): [`Position`](../interfaces/Position.md)

Defined in: [src/grid/sleekgrid.tsx:3530](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3530)

#### Returns

[`Position`](../interfaces/Position.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getGridPosition`](../interfaces/ISleekGrid.md#getgridposition)

***

### getGroupingPanel()

> **getGroupingPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:765](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L765)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getGroupingPanel`](../interfaces/ISleekGrid.md#getgroupingpanel)

***

### getHeader()

> **getHeader**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:750](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L750)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeader`](../interfaces/ISleekGrid.md#getheader)

***

### getHeaderColumn()

> **getHeaderColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:754](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L754)

#### Parameters

##### cell

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderColumn`](../interfaces/ISleekGrid.md#getheadercolumn)

***

### getHeaderRow()

> **getHeaderRow**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:773](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L773)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderRow`](../interfaces/ISleekGrid.md#getheaderrow)

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`cell`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:777](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L777)

#### Parameters

##### cell

`string` | `number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getHeaderRowColumn`](../interfaces/ISleekGrid.md#getheaderrowcolumn)

***

### getLayoutInfo()

> **getLayoutInfo**(): [`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

Defined in: [src/grid/sleekgrid.tsx:517](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L517)

#### Returns

[`GridLayoutInfo`](../type-aliases/GridLayoutInfo.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getLayoutInfo`](../interfaces/ISleekGrid.md#getlayoutinfo)

***

### getOptions()

> **getOptions**(): [`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1500](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1500)

#### Returns

[`GridOptions`](../interfaces/GridOptions.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getOptions`](../interfaces/ISleekGrid.md#getoptions)

***

### getPluginByName()

> **getPluginByName**(`name`): [`GridPlugin`](../interfaces/GridPlugin.md)

Defined in: [src/grid/sleekgrid.tsx:462](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L462)

#### Parameters

##### name

`string`

#### Returns

[`GridPlugin`](../interfaces/GridPlugin.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getPluginByName`](../interfaces/ISleekGrid.md#getpluginbyname)

***

### getPreHeaderPanel()

> **getPreHeaderPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:769](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L769)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getPreHeaderPanel`](../interfaces/ISleekGrid.md#getpreheaderpanel)

***

### getRenderedRange()

> **getRenderedRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2191](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2191)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getRenderedRange`](../interfaces/ISleekGrid.md#getrenderedrange)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

Defined in: [src/grid/sleekgrid.tsx:3212](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3212)

#### Parameters

##### rowNode

`Element`

#### Returns

`number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getRowFromNode`](../interfaces/ISleekGrid.md#getrowfromnode)

***

### getScrollBarDimensions()

> **getScrollBarDimensions**(): `object`

Defined in: [src/grid/sleekgrid.tsx:487](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L487)

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getScrollBarDimensions`](../interfaces/ISleekGrid.md#getscrollbardimensions)

***

### getScrollContainerX()

> **getScrollContainerX**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:2065](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2065)

#### Returns

`HTMLElement`

***

### getScrollContainerY()

> **getScrollContainerY**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:2069](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2069)

#### Returns

`HTMLElement`

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/grid/sleekgrid.tsx:4025](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4025)

#### Returns

`number`[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSelectedRows`](../interfaces/ISleekGrid.md#getselectedrows)

***

### getSelectionModel()

> **getSelectionModel**(): [`SelectionModel`](../interfaces/SelectionModel.md)

Defined in: [src/grid/sleekgrid.tsx:502](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L502)

#### Returns

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSelectionModel`](../interfaces/ISleekGrid.md#getselectionmodel)

***

### getSortColumns()

> **getSortColumns**(): [`ColumnSort`](../interfaces/ColumnSort.md)[]

Defined in: [src/grid/sleekgrid.tsx:1276](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1276)

#### Returns

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getSortColumns`](../interfaces/ISleekGrid.md#getsortcolumns)

***

### getTopPanel()

> **getTopPanel**(): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:1637](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1637)

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getTopPanel`](../interfaces/ISleekGrid.md#gettoppanel)

***

### getTotalsFormatter()

> **getTotalsFormatter**(`column`): [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

Defined in: [src/grid/sleekgrid.tsx:1803](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1803)

#### Parameters

##### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

#### Returns

[`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`TItem`\>

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getTotalsFormatter`](../interfaces/ISleekGrid.md#gettotalsformatter)

***

### getUID()

> **getUID**(): `string`

Defined in: [src/grid/sleekgrid.tsx:1686](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1686)

#### Returns

`string`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getUID`](../interfaces/ISleekGrid.md#getuid)

***

### getViewport()

> **getViewport**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2169](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2169)

Gets the viewport range

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getViewport`](../interfaces/ISleekGrid.md#getviewport)

***

### getViewportNode()

> **getViewportNode**(`row?`, `cell?`): `HTMLElement`

Defined in: [src/grid/sleekgrid.tsx:557](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L557)

#### Parameters

##### row?

`number`

##### cell?

`number`

#### Returns

`HTMLElement`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getViewportNode`](../interfaces/ISleekGrid.md#getviewportnode)

***

### getVisibleRange()

> **getVisibleRange**(`viewportTop?`, `viewportLeft?`): [`ViewRange`](../interfaces/ViewRange.md)

Defined in: [src/grid/sleekgrid.tsx:2173](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2173)

#### Parameters

##### viewportTop?

`number`

##### viewportLeft?

`number`

#### Returns

[`ViewRange`](../interfaces/ViewRange.md)

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`getVisibleRange`](../interfaces/ISleekGrid.md#getvisiblerange)

***

### gotoCell()

> **gotoCell**(`row`, `cell`, `forceEdit?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3906](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3906)

#### Parameters

##### row

`number`

##### cell

`number`

##### forceEdit?

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`gotoCell`](../interfaces/ISleekGrid.md#gotocell)

***

### init()

> **init**(): `void`

Defined in: [src/grid/sleekgrid.tsx:327](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L327)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`init`](../interfaces/ISleekGrid.md#init)

***

### invalidate()

> **invalidate**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1853](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1853)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidate`](../interfaces/ISleekGrid.md#invalidate)

***

### invalidateAllRows()

> **invalidateAllRows**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1860](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1860)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateAllRows`](../interfaces/ISleekGrid.md#invalidateallrows)

***

### invalidateColumns()

> **invalidateColumns**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1479](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1479)

Invalidates various elements after properties of columns have changed.
Call this if you change columns properties that don't require a full setColumns call (e.g. width, name, visible etc.)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateColumns`](../interfaces/ISleekGrid.md#invalidatecolumns)

***

### invalidateRow()

> **invalidateRow**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:1949](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1949)

#### Parameters

##### row

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateRow`](../interfaces/ISleekGrid.md#invalidaterow)

***

### invalidateRows()

> **invalidateRows**(`rows`): `void`

Defined in: [src/grid/sleekgrid.tsx:1931](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1931)

#### Parameters

##### rows

`number`[]

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`invalidateRows`](../interfaces/ISleekGrid.md#invalidaterows)

***

### navigate()

> **navigate**(`dir`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3756](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3756)

Navigate the active cell in the specified direction.

#### Parameters

##### dir

`string`

Navigation direction.

#### Returns

`boolean`

Whether navigation resulted in a change of active cell.

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigate`](../interfaces/ISleekGrid.md#navigate)

***

### navigateBottom()

> **navigateBottom**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3657](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3657)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateBottom`](../interfaces/ISleekGrid.md#navigatebottom)

***

### navigateDown()

> **navigateDown**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3720](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3720)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateDown`](../interfaces/ISleekGrid.md#navigatedown)

***

### navigateLeft()

> **navigateLeft**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3716](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3716)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateLeft`](../interfaces/ISleekGrid.md#navigateleft)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3728](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3728)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateNext`](../interfaces/ISleekGrid.md#navigatenext)

***

### navigatePageDown()

> **navigatePageDown**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3645](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3645)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePageDown`](../interfaces/ISleekGrid.md#navigatepagedown)

***

### navigatePageUp()

> **navigatePageUp**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3649](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3649)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePageUp`](../interfaces/ISleekGrid.md#navigatepageup)

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3732](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3732)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigatePrev`](../interfaces/ISleekGrid.md#navigateprev)

***

### navigateRight()

> **navigateRight**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3712](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3712)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRight`](../interfaces/ISleekGrid.md#navigateright)

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3740](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3740)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRowEnd`](../interfaces/ISleekGrid.md#navigaterowend)

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3736](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3736)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateRowStart`](../interfaces/ISleekGrid.md#navigaterowstart)

***

### navigateTop()

> **navigateTop**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3653](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3653)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateTop`](../interfaces/ISleekGrid.md#navigatetop)

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3661](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3661)

#### Parameters

##### row

`number`

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateToRow`](../interfaces/ISleekGrid.md#navigatetorow)

***

### navigateUp()

> **navigateUp**(): `boolean`

Defined in: [src/grid/sleekgrid.tsx:3724](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3724)

#### Returns

`boolean`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`navigateUp`](../interfaces/ISleekGrid.md#navigateup)

***

### prepareForOptionsChange()

> `protected` **prepareForOptionsChange**(): `void`

Defined in: [src/grid/sleekgrid.tsx:1504](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1504)

#### Returns

`void`

***

### registerPlugin()

> **registerPlugin**(`plugin`): `void`

Defined in: [src/grid/sleekgrid.tsx:445](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L445)

#### Parameters

##### plugin

[`GridPlugin`](../interfaces/GridPlugin.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`registerPlugin`](../interfaces/ISleekGrid.md#registerplugin)

***

### removeCellCssStyles()

> **removeCellCssStyles**(`key`): `void`

Defined in: [src/grid/sleekgrid.tsx:2864](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2864)

#### Parameters

##### key

`string`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`removeCellCssStyles`](../interfaces/ISleekGrid.md#removecellcssstyles)

***

### render()

> **render**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2574](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2574)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`render`](../interfaces/ISleekGrid.md#render)

***

### reorderColumns()

> **reorderColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1456](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1456)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`reorderColumns`](../interfaces/ISleekGrid.md#reordercolumns)

***

### resetActiveCell()

> **resetActiveCell**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3279](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3279)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`resetActiveCell`](../interfaces/ISleekGrid.md#resetactivecell)

***

### resizeCanvas()

> **resizeCanvas**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2037](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2037)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`resizeCanvas`](../interfaces/ISleekGrid.md#resizecanvas)

***

### scrollActiveCellIntoView()

> **scrollActiveCellIntoView**(): `void`

Defined in: [src/grid/sleekgrid.tsx:3573](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3573)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollActiveCellIntoView`](../interfaces/ISleekGrid.md#scrollactivecellintoview)

***

### scrollCellIntoView()

> **scrollCellIntoView**(`row`, `cell`, `doPaging?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3295](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3295)

#### Parameters

##### row

`number`

##### cell

`number`

##### doPaging?

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollCellIntoView`](../interfaces/ISleekGrid.md#scrollcellintoview)

***

### scrollColumnIntoView()

> **scrollColumnIntoView**(`cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:3306](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3306)

#### Parameters

##### cell

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollColumnIntoView`](../interfaces/ISleekGrid.md#scrollcolumnintoview)

***

### scrollRowIntoView()

> **scrollRowIntoView**(`row`, `doPaging?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3579](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3579)

#### Parameters

##### row

`number`

##### doPaging?

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollRowIntoView`](../interfaces/ISleekGrid.md#scrollrowintoview)

***

### scrollRowToTop()

> **scrollRowToTop**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:3607](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3607)

#### Parameters

##### row

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`scrollRowToTop`](../interfaces/ISleekGrid.md#scrollrowtotop)

***

### setActiveCell()

> **setActiveCell**(`row`, `cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:3813](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3813)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setActiveCell`](../interfaces/ISleekGrid.md#setactivecell)

***

### setActiveRow()

> **setActiveRow**(`row`, `cell`, `suppressScrollIntoView?`): `void`

Defined in: [src/grid/sleekgrid.tsx:3828](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L3828)

#### Parameters

##### row

`number`

##### cell

`number`

##### suppressScrollIntoView?

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setActiveRow`](../interfaces/ISleekGrid.md#setactiverow)

***

### setCellCssStyles()

> **setCellCssStyles**(`key`, `hash`): `void`

Defined in: [src/grid/sleekgrid.tsx:2875](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2875)

#### Parameters

##### key

`string`

##### hash

[`CellStylesHash`](../type-aliases/CellStylesHash.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setCellCssStyles`](../interfaces/ISleekGrid.md#setcellcssstyles)

***

### setColumnHeaderVisibility()

> **setColumnHeaderVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1648](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1648)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setColumnHeaderVisibility`](../interfaces/ISleekGrid.md#setcolumnheadervisibility)

***

### setColumns()

> **setColumns**(`columns`): `void`

Defined in: [src/grid/sleekgrid.tsx:1423](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1423)

#### Parameters

##### columns

[`Column`](../interfaces/Column.md)\<`TItem`\>[]

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setColumns`](../interfaces/ISleekGrid.md#setcolumns)

***

### setData()

> **setData**(`newData`, `scrollToTop?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1601](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1601)

#### Parameters

##### newData

`any`

##### scrollToTop?

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setData`](../interfaces/ISleekGrid.md#setdata)

***

### setFooterRowVisibility()

> **setFooterRowVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1655](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1655)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setFooterRowVisibility`](../interfaces/ISleekGrid.md#setfooterrowvisibility)

***

### setGroupingPanelVisibility()

> **setGroupingPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1663](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1663)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setGroupingPanelVisibility`](../interfaces/ISleekGrid.md#setgroupingpanelvisibility)

***

### setHeaderRowVisibility()

> **setHeaderRowVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1675](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1675)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setHeaderRowVisibility`](../interfaces/ISleekGrid.md#setheaderrowvisibility)

***

### setOptions()

> **setOptions**(`args`, `suppressRender?`, `suppressColumnSet?`, `suppressSetOverflow?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1514](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1514)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setOptions`](../interfaces/ISleekGrid.md#setoptions)

***

### setPreHeaderPanelVisibility()

> **setPreHeaderPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1671](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1671)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setPreHeaderPanelVisibility`](../interfaces/ISleekGrid.md#setpreheaderpanelvisibility)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/grid/sleekgrid.tsx:4032](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L4032)

#### Parameters

##### rows

`number`[]

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSelectedRows`](../interfaces/ISleekGrid.md#setselectedrows)

***

### setSelectionModel()

> **setSelectionModel**(`model`): `void`

Defined in: [src/grid/sleekgrid.tsx:469](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L469)

#### Parameters

##### model

[`SelectionModel`](../interfaces/SelectionModel.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSelectionModel`](../interfaces/ISleekGrid.md#setselectionmodel)

***

### setSortColumn()

> **setSortColumn**(`columnId`, `ascending`): `void`

Defined in: [src/grid/sleekgrid.tsx:1241](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1241)

#### Parameters

##### columnId

`string`

##### ascending

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSortColumn`](../interfaces/ISleekGrid.md#setsortcolumn)

***

### setSortColumns()

> **setSortColumns**(`cols`): `void`

Defined in: [src/grid/sleekgrid.tsx:1245](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1245)

#### Parameters

##### cols

[`ColumnSort`](../interfaces/ColumnSort.md)[]

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setSortColumns`](../interfaces/ISleekGrid.md#setsortcolumns)

***

### setTopPanelVisibility()

> **setTopPanelVisibility**(`visible`): `void`

Defined in: [src/grid/sleekgrid.tsx:1641](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1641)

#### Parameters

##### visible

`boolean`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setTopPanelVisibility`](../interfaces/ISleekGrid.md#settoppanelvisibility)

***

### setVisibleColumns()

> **setVisibleColumns**(`columnIds`, `opt?`): `void`

Defined in: [src/grid/sleekgrid.tsx:1466](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1466)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`setVisibleColumns`](../interfaces/ISleekGrid.md#setvisiblecolumns)

***

### unregisterPlugin()

> **unregisterPlugin**(`plugin`): `void`

Defined in: [src/grid/sleekgrid.tsx:450](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L450)

#### Parameters

##### plugin

[`GridPlugin`](../interfaces/GridPlugin.md)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`unregisterPlugin`](../interfaces/ISleekGrid.md#unregisterplugin)

***

### updateCell()

> **updateCell**(`row`, `cell`): `void`

Defined in: [src/grid/sleekgrid.tsx:1953](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1953)

#### Parameters

##### row

`number`

##### cell

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateCell`](../interfaces/ISleekGrid.md#updatecell)

***

### updateColumnHeader()

> **updateColumnHeader**(`columnId`, `title?`, `toolTip?`): `void`

Defined in: [src/grid/sleekgrid.tsx:697](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L697)

#### Parameters

##### columnId

`string`

##### title?

`string` | [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<`any`\>

##### toolTip?

`string`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateColumnHeader`](../interfaces/ISleekGrid.md#updatecolumnheader)

***

### updatePagingStatusFromView()

> **updatePagingStatusFromView**(`pagingInfo`): `void`

Defined in: [src/grid/sleekgrid.tsx:2060](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2060)

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

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updatePagingStatusFromView`](../interfaces/ISleekGrid.md#updatepagingstatusfromview)

***

### updateRow()

> **updateRow**(`row`): `void`

Defined in: [src/grid/sleekgrid.tsx:1979](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L1979)

#### Parameters

##### row

`number`

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateRow`](../interfaces/ISleekGrid.md#updaterow)

***

### updateRowCount()

> **updateRowCount**(): `void`

Defined in: [src/grid/sleekgrid.tsx:2073](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/grid/sleekgrid.tsx#L2073)

#### Returns

`void`

#### Implementation of

[`ISleekGrid`](../interfaces/ISleekGrid.md).[`updateRowCount`](../interfaces/ISleekGrid.md#updaterowcount)
