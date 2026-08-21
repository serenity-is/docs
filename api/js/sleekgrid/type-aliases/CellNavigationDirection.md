[@serenity-is/sleekgrid](../README.md) / CellNavigationDirection

# Type Alias: CellNavigationDirection

> **CellNavigationDirection** = `"up"` \| `"down"` \| `"left"` \| `"right"` \| `"next"` \| `"prev"` \| `"home"` \| `"end"`

Defined in: [src/core/cellnavigation.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L7)

Discrete directions that the active cell can be moved programmatically.
Values map to arrow keys and special keys: `home`/`end` for row boundaries,
`next`/`prev` for tab-like sequential navigation, and `up`/`down`/`left`/`right`
for arrow-key navigation.
