[@serenity-is/sleekgrid](../README.md) / Header

# Function: Header()

> **Header**(`__namedParameters`): `JSXElement`

Defined in: [src/layouts/layout-components.tsx:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-components.tsx#L32)

Header shell component for a single band. Hosts the column-header container
and hides automatically when the band is empty or the header is hidden.

## Parameters

### \_\_namedParameters

#### band

[`BandKey`](../type-aliases/BandKey.md)

#### refs

[`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

#### signals

`Pick`\<[`GridSignals`](../interfaces/GridSignals.md), `"hideColumnHeader"` \| `"pinnedStartCols"` \| `"pinnedEndCols"`\>

## Returns

`JSXElement`
