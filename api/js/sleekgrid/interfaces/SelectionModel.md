[@serenity-is/sleekgrid](../README.md) / SelectionModel

# Interface: SelectionModel

Defined in: [src/core/selection-model.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L8)

Contract for a grid selection model (e.g. `CellSelectionModel`, `RowSelectionModel`).
Implements [GridPlugin](GridPlugin.md) so it can be registered via `grid.setSelectionModel()`.

## Extends

- [`GridPlugin`](GridPlugin.md)

## Properties

### destroy()?

> `optional` **destroy**: () => `void`

Defined in: [src/core/grid-plugin.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L15)

Optional teardown hook; called when the grid or plugin is unregistered.

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`destroy`](GridPlugin.md#destroy)

***

### onSelectedRangesChanged

> **onSelectedRangesChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<[`CellRange`](../classes/CellRange.md)[]\>

Defined in: [src/core/selection-model.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L15)

Emits when the selected ranges change; payload is the new `CellRange[]`.

***

### pluginName?

> `optional` **pluginName**: `string`

Defined in: [src/core/grid-plugin.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L13)

Optional unique name used by [GridPluginHost.getPluginByName](GridPluginHost.md#getpluginbyname) for lookup.

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`pluginName`](GridPlugin.md#pluginname)

## Methods

### init()

> **init**(`grid`): `void`

Defined in: [src/core/grid-plugin.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/grid-plugin.ts#L11)

Called by the grid when the plugin is registered.

#### Parameters

##### grid

[`ISleekGrid`](ISleekGrid.md)

Host grid instance the plugin attaches to.

#### Returns

`void`

#### Inherited from

[`GridPlugin`](GridPlugin.md).[`init`](GridPlugin.md#init)

***

### refreshSelections()?

> `optional` **refreshSelections**(): `void`

Defined in: [src/core/selection-model.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L20)

Optional hook invoked when the grid re-renders rows; selection models can
re-apply visual selection state here.

#### Returns

`void`

***

### setSelectedRanges()

> **setSelectedRanges**(`ranges`): `void`

Defined in: [src/core/selection-model.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/selection-model.ts#L13)

Sets the current selection to the given cell ranges.

#### Parameters

##### ranges

[`CellRange`](../classes/CellRange.md)[]

New selected ranges; implementations should normalize/clamp them.

#### Returns

`void`
