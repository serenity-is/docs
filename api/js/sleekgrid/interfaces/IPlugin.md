[@serenity-is/sleekgrid](../README.md) / IPlugin

# Interface: IPlugin

## Hierarchy

- **`IPlugin`**

  ↳ [`SelectionModel`](SelectionModel.md)

## Implemented by

- [`AutoTooltips`](../classes/AutoTooltips.md)
- [`RowMoveManager`](../classes/RowMoveManager.md)
- [`RowSelectionModel`](../classes/RowSelectionModel.md)

## Table of contents

### Properties

- [destroy](IPlugin.md#destroy)
- [pluginName](IPlugin.md#pluginname)

### Methods

- [init](IPlugin.md#init)

## Properties

### destroy

• `Optional` **destroy**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[grid/types.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L7)

___

### pluginName

• `Optional` **pluginName**: `string`

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

#### Defined in

[grid/types.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L5)
