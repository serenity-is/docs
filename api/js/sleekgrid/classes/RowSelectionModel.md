[@serenity-is/sleekgrid](../README.md) / RowSelectionModel

# Class: RowSelectionModel

## Implements

- [`IPlugin`](../interfaces/IPlugin.md)
- [`SelectionModel`](../interfaces/SelectionModel.md)

## Table of contents

### Constructors

- [constructor](RowSelectionModel.md#constructor)

### Properties

- [onSelectedRangesChanged](RowSelectionModel.md#onselectedrangeschanged)
- [defaults](RowSelectionModel.md#defaults)

### Methods

- [destroy](RowSelectionModel.md#destroy)
- [getSelectedRanges](RowSelectionModel.md#getselectedranges)
- [getSelectedRows](RowSelectionModel.md#getselectedrows)
- [init](RowSelectionModel.md#init)
- [setSelectedRanges](RowSelectionModel.md#setselectedranges)
- [setSelectedRows](RowSelectionModel.md#setselectedrows)

## Constructors

### constructor

• **new RowSelectionModel**(`options?`): [`RowSelectionModel`](RowSelectionModel.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | [`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md) |

#### Returns

[`RowSelectionModel`](RowSelectionModel.md)

#### Defined in

[plugins/rowselectionmodel.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L37)

## Properties

### onSelectedRangesChanged

• **onSelectedRangesChanged**: [`EventEmitter`](EventEmitter.md)\<[`CellRange`](CellRange.md)[], [`IEventData`](../interfaces/IEventData.md)\>

#### Implementation of

[SelectionModel](../interfaces/SelectionModel.md).[onSelectedRangesChanged](../interfaces/SelectionModel.md#onselectedrangeschanged)

#### Defined in

[plugins/rowselectionmodel.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L35)

___

### defaults

▪ `Static` `Readonly` **defaults**: [`RowSelectionModelOptions`](../interfaces/RowSelectionModelOptions.md)

#### Defined in

[plugins/rowselectionmodel.ts:41](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L41)

## Methods

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Implementation of

[SelectionModel](../interfaces/SelectionModel.md).[destroy](../interfaces/SelectionModel.md#destroy)

#### Defined in

[plugins/rowselectionmodel.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L52)

___

### getSelectedRanges

▸ **getSelectedRanges**(): [`CellRange`](CellRange.md)[]

#### Returns

[`CellRange`](CellRange.md)[]

#### Defined in

[plugins/rowselectionmodel.ts:92](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L92)

___

### getSelectedRows

▸ **getSelectedRows**(): `number`[]

#### Returns

`number`[]

#### Defined in

[plugins/rowselectionmodel.ts:76](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L76)

___

### init

▸ **init**(`grid`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`Grid`](Grid.md)\<`any`\> |

#### Returns

`void`

#### Implementation of

[SelectionModel](../interfaces/SelectionModel.md).[init](../interfaces/SelectionModel.md#init)

#### Defined in

[plugins/rowselectionmodel.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L45)

___

### setSelectedRanges

▸ **setSelectedRanges**(`ranges`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ranges` | [`CellRange`](CellRange.md)[] |

#### Returns

`void`

#### Implementation of

[SelectionModel](../interfaces/SelectionModel.md).[setSelectedRanges](../interfaces/SelectionModel.md#setselectedranges)

#### Defined in

[plugins/rowselectionmodel.ts:84](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L84)

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

[plugins/rowselectionmodel.ts:80](https://github.com/serenity-is/sleekgrid/blob/master/src/plugins/rowselectionmodel.ts#L80)
