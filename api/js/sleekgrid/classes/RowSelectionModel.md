[serenity-is/sleekgrid](../README.md) / RowSelectionModel

# Class: RowSelectionModel

Defined in: [src/plugins/rowselectionmodel.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L28)

## Implements

- [`GridPlugin`](../interfaces/GridPlugin.md)
- [`SelectionModel`](../interfaces/SelectionModel.md)

## Constructors

### Constructor

> **new RowSelectionModel**(`options?`): `RowSelectionModel`

Defined in: [src/plugins/rowselectionmodel.ts:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L35)

#### Parameters

##### options?

[`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

#### Returns

`RowSelectionModel`

## Properties

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](EventEmitter.md)\<[`CellRange`](CellRange.md)[], \{ \}\>

Defined in: [src/plugins/rowselectionmodel.ts:33](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L33)

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`onSelectedRangesChanged`](../interfaces/SelectionModel.md#onselectedrangeschanged)

***

### defaults

> `readonly` `static` **defaults**: [`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

Defined in: [src/plugins/rowselectionmodel.ts:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L39)

## Methods

### destroy()

> **destroy**(): `void`

Defined in: [src/plugins/rowselectionmodel.ts:50](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L50)

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`destroy`](../interfaces/SelectionModel.md#destroy)

***

### getSelectedRanges()

> **getSelectedRanges**(): [`CellRange`](CellRange.md)[]

Defined in: [src/plugins/rowselectionmodel.ts:90](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L90)

#### Returns

[`CellRange`](CellRange.md)[]

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

Defined in: [src/plugins/rowselectionmodel.ts:74](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L74)

#### Returns

`number`[]

***

### init()

> **init**(`grid`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L43)

#### Parameters

##### grid

[`ISleekGrid`](../interfaces/ISleekGrid.md)

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`init`](../interfaces/SelectionModel.md#init)

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L82)

#### Parameters

##### ranges

[`CellRange`](CellRange.md)[]

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`setSelectedRanges`](../interfaces/SelectionModel.md#setselectedranges)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

Defined in: [src/plugins/rowselectionmodel.ts:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowselectionmodel.ts#L78)

#### Parameters

##### rows

`number`[]

#### Returns

`void`
