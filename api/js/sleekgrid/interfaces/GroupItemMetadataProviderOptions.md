[serenity-is/sleekgrid](../README.md) / GroupItemMetadataProviderOptions

# Interface: GroupItemMetadataProviderOptions

Defined in: [src/data/groupitemmetadataprovider.tsx:3](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L3)

## Properties

### enableExpandCollapse?

> `optional` **enableExpandCollapse**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:4](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L4)

***

### groupCellCssClass?

> `optional` **groupCellCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L5)

***

### groupCssClass?

> `optional` **groupCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L6)

***

### groupFocusable?

> `optional` **groupFocusable**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L8)

***

### groupFormat?

> `optional` **groupFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<[`Group`](../classes/Group.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L9)

***

### ~~groupFormatter?~~

> `optional` **groupFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<[`Group`](../classes/Group.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L11)

#### Deprecated

see groupFormat

***

### groupIndentation?

> `optional` **groupIndentation**: `number`

Defined in: [src/data/groupitemmetadataprovider.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L7)

***

### groupLevelPrefix?

> `optional` **groupLevelPrefix**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L12)

***

### groupRowTotals?

> `optional` **groupRowTotals**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L13)

***

### groupTitleCssClass?

> `optional` **groupTitleCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L14)

***

### hasSummaryType()?

> `optional` **hasSummaryType**: (`column`) => `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L15)

#### Parameters

##### column

[`Column`](Column.md)

#### Returns

`boolean`

***

### toggleCollapsedCssClass?

> `optional` **toggleCollapsedCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L18)

***

### toggleCssClass?

> `optional` **toggleCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L16)

***

### toggleExpandedCssClass?

> `optional` **toggleExpandedCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:17](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L17)

***

### totalsCssClass?

> `optional` **totalsCssClass**: `string`

Defined in: [src/data/groupitemmetadataprovider.tsx:19](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L19)

***

### totalsFocusable?

> `optional` **totalsFocusable**: `boolean`

Defined in: [src/data/groupitemmetadataprovider.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L20)

***

### totalsFormat?

> `optional` **totalsFormat**: [`ColumnFormat`](../type-aliases/ColumnFormat.md)\<[`IGroupTotals`](IGroupTotals.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:21](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L21)

***

### ~~totalsFormatter?~~

> `optional` **totalsFormatter**: [`CompatFormatter`](../type-aliases/CompatFormatter.md)\<[`IGroupTotals`](IGroupTotals.md)\<`any`\>\>

Defined in: [src/data/groupitemmetadataprovider.tsx:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/data/groupitemmetadataprovider.tsx#L23)

#### Deprecated

use totalsFormat
