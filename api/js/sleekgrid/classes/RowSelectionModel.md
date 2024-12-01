[@serenity-is/sleekgrid](../README.md) / RowSelectionModel

# Class: RowSelectionModel

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)
- [`SelectionModel`](../interfaces/SelectionModel.md)

## Constructors

### new RowSelectionModel()

> **new RowSelectionModel**(`options`?): [`RowSelectionModel`](RowSelectionModel.md)

#### Parameters

##### options?

[`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

#### Returns

[`RowSelectionModel`](RowSelectionModel.md)

#### Defined in

[plugins/rowselectionmodel.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L36)

## Properties

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](EventEmitter.md)\<[`CellRange`](CellRange.md)[], [`IEventData`](../interfaces/IEventData.md)\>

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`onSelectedRangesChanged`](../interfaces/SelectionModel.md#onselectedrangeschanged)

#### Defined in

[plugins/rowselectionmodel.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L34)

***

### defaults

> `readonly` `static` **defaults**: [`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

#### Defined in

[plugins/rowselectionmodel.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L40)

## Methods

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`destroy`](../interfaces/SelectionModel.md#destroy)

#### Defined in

[plugins/rowselectionmodel.ts:51](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L51)

***

### getSelectedRanges()

> **getSelectedRanges**(): [`CellRange`](CellRange.md)[]

#### Returns

[`CellRange`](CellRange.md)[]

#### Defined in

[plugins/rowselectionmodel.ts:91](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L91)

***

### getSelectedRows()

> **getSelectedRows**(): `number`[]

#### Returns

`number`[]

#### Defined in

[plugins/rowselectionmodel.ts:75](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L75)

***

### init()

> **init**(`grid`): `void`

#### Parameters

##### grid

[`Grid`](Grid.md)\<`any`\>

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`init`](../interfaces/SelectionModel.md#init)

#### Defined in

[plugins/rowselectionmodel.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L44)

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

#### Parameters

##### ranges

[`CellRange`](CellRange.md)[]

#### Returns

`void`

#### Implementation of

[`SelectionModel`](../interfaces/SelectionModel.md).[`setSelectedRanges`](../interfaces/SelectionModel.md#setselectedranges)

#### Defined in

[plugins/rowselectionmodel.ts:83](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L83)

***

### setSelectedRows()

> **setSelectedRows**(`rows`): `void`

#### Parameters

##### rows

`number`[]

#### Returns

`void`

#### Defined in

[plugins/rowselectionmodel.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L79)
