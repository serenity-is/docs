[@serenity-is/sleekgrid](../README.md) / SelectionModel

# Interface: SelectionModel

Defined in: [src/core/selection-model.ts:4](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L4)

## Extends

- [`GridPlugin`](GridPlugin.md)

## Properties

### destroy()?

> `optional` **destroy**: () => `void`

Defined in: [src/core/grid-plugin.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L6)

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`destroy`](GridPlugin.md#destroy)

***

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`CellRange`](../classes/CellRange.md)[]\>

Defined in: [src/core/selection-model.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L6)

***

### pluginName?

> `optional` **pluginName**: `string`

Defined in: [src/core/grid-plugin.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L5)

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`pluginName`](GridPlugin.md#pluginname)

## Methods

### init()

> **init**(`grid`): `void`

Defined in: [src/core/grid-plugin.ts:4](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L4)

#### Parameters

##### grid

[`ISleekGrid`](ISleekGrid.md)

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`init`](GridPlugin.md#init)

***

### refreshSelections()?

> `optional` **refreshSelections**(): `void`

Defined in: [src/core/selection-model.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L7)

#### Returns

`void`

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

Defined in: [src/core/selection-model.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L5)

#### Parameters

##### ranges

[`CellRange`](../classes/CellRange.md)[]

#### Returns

`void`
