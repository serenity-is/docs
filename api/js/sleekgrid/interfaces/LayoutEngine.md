[@serenity-is/sleekgrid](../README.md) / LayoutEngine

# Interface: LayoutEngine

Defined in: [src/layouts/layout-engine.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L11)

Pluggable layout strategy responsible for creating DOM panes and responding
to grid option changes. The grid instantiates one engine (typically
[BasicLayout](../classes/BasicLayout.md) or [FrozenLayout](../classes/FrozenLayout.md)).

## Properties

### layoutName

> **layoutName**: `string`

Defined in: [src/layouts/layout-engine.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L13)

Human-readable layout name (e.g. `"BasicLayout"`).

***

### supportFrozenBottom?

> `optional` **supportFrozenBottom**: `boolean`

Defined in: [src/layouts/layout-engine.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L46)

Whether the engine supports bottom-frozen rows.

***

### supportFrozenRows?

> `optional` **supportFrozenRows**: `boolean`

Defined in: [src/layouts/layout-engine.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L44)

Whether the engine supports top-frozen rows.

***

### supportPinnedCols?

> `optional` **supportPinnedCols**: `boolean`

Defined in: [src/layouts/layout-engine.ts:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L40)

Whether the engine supports pinned (frozen) columns.

***

### supportPinnedEnd?

> `optional` **supportPinnedEnd**: `boolean`

Defined in: [src/layouts/layout-engine.ts:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L42)

Whether the engine supports end-pinned columns.

## Methods

### adjustFrozenRowsOption()?

> `optional` **adjustFrozenRowsOption**(): `void`

Defined in: [src/layouts/layout-engine.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L25)

Adjusts the frozen-row refs from the current grid options without a
full re-layout. Called when `frozenRows` / `frozenBottom` change.

#### Returns

`void`

***

### afterSetOptions()

> **afterSetOptions**(`args`): `void`

Defined in: [src/layouts/layout-engine.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L30)

Called after `grid.setOptions(args)` merges new options.

#### Parameters

##### args

[`GridOptions`](GridOptions.md)

Options delta passed to `setOptions`.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/layouts/layout-engine.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L20)

Tears down DOM and listeners created by [LayoutEngine.init](#init).

#### Returns

`void`

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/layout-engine.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L18)

Initializes the layout, creating DOM inside `host.getContainerNode()`.

#### Parameters

##### host

[`LayoutHost`](LayoutHost.md)

Layout host providing grid state, signals and refs.

#### Returns

`void`

***

### reorderViewColumns()?

> `optional` **reorderViewColumns**(`viewCols`, `refs`): [`Column`](Column.md)\<`any`\>[]

Defined in: [src/layouts/layout-engine.ts:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-engine.ts#L38)

Optionally reorders the visible columns before they are laid out.
May be called before [LayoutEngine.init](#init) during early option setup.

#### Parameters

##### viewCols

[`Column`](Column.md)\<`any`\>[]

Current visible columns in display order.

##### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

Mutable layout refs whose config may be updated.

#### Returns

[`Column`](Column.md)\<`any`\>[]

Reordered columns, or `null` when no reorder is needed.
