[@serenity-is/sleekgrid](../README.md) / Viewport

# Function: Viewport()

> **Viewport**(`__namedParameters`): `JSXElement`

Defined in: [src/layouts/layout-components.tsx:83](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-components.tsx#L83)

Scrollable viewport + canvas pair for a single `band`/`pane` cell.
Hidden when the corresponding frozen/pinned count is `0`.

## Parameters

### \_\_namedParameters

#### band

[`BandKey`](../type-aliases/BandKey.md)

#### pane

[`PaneKey`](../type-aliases/PaneKey.md)

#### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

#### signals

`Pick`\<[`GridSignals`](../interfaces/GridSignals.md), `"frozenTopRows"` \| `"frozenBottomRows"` \| `"pinnedStartCols"` \| `"pinnedEndCols"`\>

## Returns

`JSXElement`
