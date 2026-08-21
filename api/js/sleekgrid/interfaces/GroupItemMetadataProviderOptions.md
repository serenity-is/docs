[@serenity-is/sleekgrid](../README.md) / GroupItemMetadataProviderOptions

# Interface: GroupItemMetadataProviderOptions

Defined in: [src/data/groupitemmetadataprovider.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L6)

Options controlling how [GroupItemMetadataProvider](../classes/GroupItemMetadataProvider.md) renders group and totals rows.

## Properties

### enableExpandCollapse?

> `optional` **enableExpandCollapse**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L8)

Whether group rows show an expand/collapse toggle and respond to clicks/keys. Defaults to `true`.

***

### groupCellCssClass?

> `optional` **groupCellCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L10)

CSS class applied to the group cell (the spanned cell). Defaults to `"slick-group-cell"`.

***

### groupCssClass?

> `optional` **groupCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L12)

CSS class applied to the entire group row. Defaults to `"slick-group"`.

***

### groupFocusable?

> `optional` **groupFocusable**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L16)

Whether group rows can receive focus. Defaults to `true`.

***

### groupFormat?

> `optional` **groupFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<[`Group`](../classes/Group.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L18)

Modern formatter for the group title/aggregated content.

***

### ~~groupFormatter?~~

> `optional` **groupFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<[`Group`](../classes/Group.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L23)

Legacy formatter for group rows.

#### Deprecated

Use [GroupItemMetadataProviderOptions.groupFormat](#groupformat) instead.

***

### groupIndentation?

> `optional` **groupIndentation**: `number`

Defined in: [src/data/groupitemmetadataprovider.tsx:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L14)

Indentation in pixels per grouping level for the toggle. Defaults to `15`.

***

### groupLevelPrefix?

> `optional` **groupLevelPrefix**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L25)

CSS class prefix for grouping level (appended with level number). Defaults to `"slick-group-level-"`.

***

### groupRowTotals?

> `optional` **groupRowTotals**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L27)

Whether totals rows should be considered part of the group row span calculation.

***

### groupTitleCssClass?

> `optional` **groupTitleCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L29)

CSS class applied to the title span inside the group cell. Defaults to `"slick-group-title"`.

***

### hasSummaryType()?

> `optional` **hasSummaryType**: (`column`) => `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L36)

Predicate determining whether a column has a summary/aggregate.
Used to locate the spanned group cell position.

#### Parameters

##### column

[`Column`](Column.md)

Column to test.

#### Returns

`boolean`

`true` if the column contributes a total/summary.

***

### toggleCollapsedCssClass?

> `optional` **toggleCollapsedCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:42](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L42)

CSS class added when the toggle represents a collapsed group. Defaults to `"collapsed"`.

***

### toggleCssClass?

> `optional` **toggleCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L38)

CSS class for the expand/collapse toggle element. Defaults to `"slick-group-toggle"`.

***

### toggleExpandedCssClass?

> `optional` **toggleExpandedCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:40](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L40)

CSS class added when the toggle represents an expanded group. Defaults to `"expanded"`.

***

### totalsCssClass?

> `optional` **totalsCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L44)

CSS class applied to totals rows. Defaults to `"slick-group-totals"`.

***

### totalsFocusable?

> `optional` **totalsFocusable**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L46)

Whether totals rows can receive focus. Defaults to `false`.

***

### totalsFormat?

> `optional` **totalsFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<[`IGroupTotals`](IGroupTotals.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L48)

Modern formatter for totals rows.

***

### ~~totalsFormatter?~~

> `optional` **totalsFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<[`IGroupTotals`](IGroupTotals.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L53)

Legacy formatter for totals rows.

#### Deprecated

Use [GroupItemMetadataProviderOptions.totalsFormat](#totalsformat) instead.
