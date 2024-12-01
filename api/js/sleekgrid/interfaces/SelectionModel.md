[@serenity-is/sleekgrid](../README.md) / SelectionModel

# Interface: SelectionModel

## Extends

- [`IPlugin`](IPlugin.md)

## Properties

### destroy()?

> `optional` **destroy**: () => `void`

#### Returns

`void`

#### Inherited from

[`IPlugin`](IPlugin.md).[`destroy`](IPlugin.md#destroy)

#### Defined in

[grid/types.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L7)

***

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`CellRange`](../classes/CellRange.md)[], [`IEventData`](IEventData.md)\>

#### Defined in

[grid/types.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L27)

***

### pluginName?

> `optional` **pluginName**: `string`

#### Inherited from

[`IPlugin`](IPlugin.md).[`pluginName`](IPlugin.md#pluginname)

#### Defined in

[grid/types.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L6)

## Methods

### init()

> **init**(`grid`): `void`

#### Parameters

##### grid

[`Grid`](../classes/Grid.md)\<`any`\>

#### Returns

`void`

#### Inherited from

[`IPlugin`](IPlugin.md).[`init`](IPlugin.md#init)

#### Defined in

[grid/types.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L5)

***

### refreshSelections()?

> `optional` **refreshSelections**(): `void`

#### Returns

`void`

#### Defined in

[grid/types.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L28)

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

#### Parameters

##### ranges

[`CellRange`](../classes/CellRange.md)[]

#### Returns

`void`

#### Defined in

[grid/types.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/types.ts#L26)
