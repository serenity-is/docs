[@serenity-is/sleekgrid](../README.md) / SelectionModel

# Interface: SelectionModel

## Hierarchy

- [`IPlugin`](IPlugin.md)

  ↳ **`SelectionModel`**

## Implemented by

- [`RowSelectionModel`](../classes/RowSelectionModel.md)

## Table of contents

### Properties

- [destroy](SelectionModel.md#destroy)
- [onSelectedRangesChanged](SelectionModel.md#onselectedrangeschanged)
- [pluginName](SelectionModel.md#pluginname)

### Methods

- [init](SelectionModel.md#init)
- [refreshSelections](SelectionModel.md#refreshselections)
- [setSelectedRanges](SelectionModel.md#setselectedranges)

## Properties

### destroy

• `Optional` **destroy**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Inherited from

[IPlugin](IPlugin.md).[destroy](IPlugin.md#destroy)

#### Defined in

[grid/types.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L7)

___

### onSelectedRangesChanged

• **onSelectedRangesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`CellRange`](../classes/CellRange.md)[], [`IEventData`](IEventData.md)\>

#### Defined in

[grid/types.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L27)

___

### pluginName

• `Optional` **pluginName**: `string`

#### Inherited from

[IPlugin](IPlugin.md).[pluginName](IPlugin.md#pluginname)

#### Defined in

[grid/types.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L6)

## Methods

### init

▸ **init**(`grid`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`Grid`](../classes/Grid.md)\<`any`\> |

#### Returns

`void`

#### Inherited from

[IPlugin](IPlugin.md).[init](IPlugin.md#init)

#### Defined in

[grid/types.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L5)

___

### refreshSelections

▸ **refreshSelections**(): `void`

#### Returns

`void`

#### Defined in

[grid/types.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L28)

___

### setSelectedRanges

▸ **setSelectedRanges**(`ranges`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ranges` | [`CellRange`](../classes/CellRange.md)[] |

#### Returns

`void`

#### Defined in

[grid/types.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L26)
