[@serenity-is/sleekgrid](../README.md) / RowSelectionModel

# Class: RowSelectionModel

Defined in: [src/plugins/rowselectionmodel.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L40)

Selection model that treats selection as whole rows (full-width ranges).
Supports ActiveCell-driven selection, Shift+Up/Down range extension and
Ctrl/Meta/Shift-click row toggling. Implements [SelectionModel](../interfaces/SelectionModel.md).

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)
- [`SelectionModel`](../interfaces/SelectionModel.md)

## Constructors

### Constructor

> **new RowSelectionModel**(`options?`): `RowSelectionModel`

Defined in: [src/plugins/rowselectionmodel.ts:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L55)

Creates the selection model.

#### Parameters

##### options?

[`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

Partial options merged with [RowSelectionModel.defaults](#defaults).

#### Returns

`RowSelectionModel`

## Properties

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](EventEmitter.md)\<[`CellRange`](CellRange.md)[]\>

Defined in: [src/plugins/rowselectionmodel.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L49)

Emits when selected ranges change; used by the grid to update UI state.

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`onSelectedRangesChanged`](../interfaces/SelectionModel.md#onselectedrangeschanged)

***

### defaults

> `readonly` `static` **defaults**: [`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

Defined in: [src/plugins/rowselectionmodel.ts:60](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L60)

Default option values.

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/plugins/rowselectionmodel.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L78)

Unsubscribes handlers installed by [RowSelectionModel.init](#init).

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`destroy`](../interfaces/SelectionModel.md#destroy)

***

### getSelectedRanges()

> **getSelectedRanges**(): [`CellRange`](CellRange.md)[]

Defined in: [src/plugins/rowselectionmodel.ts:134](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L134)

Returns the current selection as full-width [CellRange](CellRange.md) objects.

#### Returns

[`CellRange`](CellRange.md)[]

Current selected ranges.

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/plugins/rowselectionmodel.ts:106](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L106)

Returns selected view row indices derived from the internal ranges.

#### Returns

`number`[]

Array of selected row indices.

***

### init()

> **init**(`grid`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:68](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L68)

Attaches to `onActiveCellChanged`, `onKeyDown` and `onClick` on `grid`.

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

Host grid instance.

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`init`](../interfaces/SelectionModel.md#init)

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:122](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L122)

Sets selection from explicit ranges (each range should span the full row width).

#### Parameters

##### ranges

[`CellRange`](CellRange.md)[]

Cell ranges representing row selection.

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`setSelectedRanges`](../interfaces/SelectionModel.md#setselectedranges)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:114](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L114)

Sets selection from a list of row indices.

#### Parameters

##### rows

`number`[]

Row indices to select.

#### Returns

`void`
