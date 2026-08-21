[@serenity-is/sleekgrid](../README.md) / FrozenLayout

# Class: FrozenLayout

Defined in: [src/layouts/frozen-layout.tsx:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L12)

Frozen/pinned layout providing pinned columns and frozen top panes.
Renders `start`/`main` bands with `top`/`body` panes and handles
`frozenRows`/`frozenBottom` and legacy `frozenColumns` options.

## Implements

- [`LayoutEngine`](../interfaces/LayoutEngine.md)

## Constructors

### Constructor

> **new FrozenLayout**(): `FrozenLayout`

#### Returns

`FrozenLayout`

## Properties

### layoutName

> `readonly` **layoutName**: `"FrozenLayout"` = `"FrozenLayout"`

Defined in: [src/layouts/frozen-layout.tsx:91](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L91)

Layout identifier.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`layoutName`](../interfaces/LayoutEngine.md#layoutname)

***

### supportFrozenRows

> **supportFrozenRows**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L96)

Indicates this layout supports top-frozen rows.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportFrozenRows`](../interfaces/LayoutEngine.md#supportfrozenrows)

***

### supportPinnedCols

> **supportPinnedCols**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:94](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L94)

Indicates this layout supports pinned columns.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportPinnedCols`](../interfaces/LayoutEngine.md#supportpinnedcols)

## Methods

### adjustFrozenRowsOption()

> **adjustFrozenRowsOption**(): `void`

Defined in: [src/layouts/frozen-layout.tsx:78](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L78)

Syncs `refs.config.frozenTopRows` from `frozenRows`/`frozenBottom` grid options.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`adjustFrozenRowsOption`](../interfaces/LayoutEngine.md#adjustfrozenrowsoption)

***

### afterSetOptions()

> **afterSetOptions**(`arg`): `void`

Defined in: [src/layouts/frozen-layout.tsx:65](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L65)

Reacts to grid option changes (frozen rows/columns).

#### Parameters

##### arg

[`GridOptions`](../interfaces/GridOptions.md)

Options delta from `grid.setOptions()`.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`afterSetOptions`](../interfaces/LayoutEngine.md#aftersetoptions)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/layouts/frozen-layout.tsx:86](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L86)

Clears the host reference.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`destroy`](../interfaces/LayoutEngine.md#destroy)

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/frozen-layout.tsx:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L23)

Builds the frozen layout DOM (headers, header rows, viewports, footer rows)
across `start`/`main` bands and top/body panes.

#### Parameters

##### host

[`LayoutHost`](../interfaces/LayoutHost.md)

Layout host.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`init`](../interfaces/LayoutEngine.md#init)

***

### reorderViewColumns()

> **reorderViewColumns**(`viewCols`, `refs`): [`Column`](../interfaces/Column.md)\<`any`\>[]

Defined in: [src/layouts/frozen-layout.tsx:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L53)

Reorders visible columns so that pinned (non-`"end"`) columns come first.
Also writes `refs.config.pinnedStartCols` for later layout calculations.

#### Parameters

##### viewCols

[`Column`](../interfaces/Column.md)\<`any`\>[]

Visible columns in current order.

##### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

Mutable layout refs to update.

#### Returns

[`Column`](../interfaces/Column.md)\<`any`\>[]

Reordered columns when pinning exists, `null` otherwise.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`reorderViewColumns`](../interfaces/LayoutEngine.md#reorderviewcolumns)
