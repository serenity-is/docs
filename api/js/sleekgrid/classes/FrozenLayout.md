[@serenity-is/sleekgrid](../README.md) / FrozenLayout

# Class: FrozenLayout

Defined in: [src/layouts/frozen-layout.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L13)

Frozen/pinned layout providing pinned columns and frozen top panes.
Renders `start`/`main` bands with `top`/`body` panes and handles
`frozenRows` and legacy `frozenColumns` options.
Bottom-frozen rows are unsupported; when requested, `frozenRows` are left unfrozen.

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

Defined in: [src/layouts/frozen-layout.tsx:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L93)

Layout identifier.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`layoutName`](../interfaces/LayoutEngine.md#layoutname)

***

### supportFrozenRows

> **supportFrozenRows**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:98](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L98)

Indicates this layout supports top-frozen rows.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportFrozenRows`](../interfaces/LayoutEngine.md#supportfrozenrows)

***

### supportPinnedCols

> **supportPinnedCols**: `true` = `true`

Defined in: [src/layouts/frozen-layout.tsx:96](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L96)

Indicates this layout supports pinned columns.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`supportPinnedCols`](../interfaces/LayoutEngine.md#supportpinnedcols)

## Methods

### adjustFrozenRowsOption()

> **adjustFrozenRowsOption**(): `void`

Defined in: [src/layouts/frozen-layout.tsx:80](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L80)

Syncs `refs.config.frozenTopRows` from `frozenRows`, leaving rows unfrozen
when bottom-freezing is requested because this layout has no bottom pane.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`adjustFrozenRowsOption`](../interfaces/LayoutEngine.md#adjustfrozenrowsoption)

***

### afterSetOptions()

> **afterSetOptions**(`arg`): `void`

Defined in: [src/layouts/frozen-layout.tsx:66](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L66)

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

Defined in: [src/layouts/frozen-layout.tsx:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L88)

Clears the host reference.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`destroy`](../interfaces/LayoutEngine.md#destroy)

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/frozen-layout.tsx:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L24)

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

Defined in: [src/layouts/frozen-layout.tsx:54](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/frozen-layout.tsx#L54)

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
