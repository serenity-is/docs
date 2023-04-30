[@serenity-is/sleekgrid](../README.md) / GroupItemMetadataProviderOptions

# Interface: GroupItemMetadataProviderOptions

## Table of contents

### Properties

- [enableExpandCollapse](GroupItemMetadataProviderOptions.md#enableexpandcollapse)
- [groupCellCssClass](GroupItemMetadataProviderOptions.md#groupcellcssclass)
- [groupCssClass](GroupItemMetadataProviderOptions.md#groupcssclass)
- [groupFocusable](GroupItemMetadataProviderOptions.md#groupfocusable)
- [groupFormat](GroupItemMetadataProviderOptions.md#groupformat)
- [groupFormatter](GroupItemMetadataProviderOptions.md#groupformatter)
- [groupIndentation](GroupItemMetadataProviderOptions.md#groupindentation)
- [groupLevelPrefix](GroupItemMetadataProviderOptions.md#grouplevelprefix)
- [groupRowTotals](GroupItemMetadataProviderOptions.md#grouprowtotals)
- [groupTitleCssClass](GroupItemMetadataProviderOptions.md#grouptitlecssclass)
- [hasSummaryType](GroupItemMetadataProviderOptions.md#hassummarytype)
- [toggleCollapsedCssClass](GroupItemMetadataProviderOptions.md#togglecollapsedcssclass)
- [toggleCssClass](GroupItemMetadataProviderOptions.md#togglecssclass)
- [toggleExpandedCssClass](GroupItemMetadataProviderOptions.md#toggleexpandedcssclass)
- [totalsCssClass](GroupItemMetadataProviderOptions.md#totalscssclass)
- [totalsFocusable](GroupItemMetadataProviderOptions.md#totalsfocusable)
- [totalsFormat](GroupItemMetadataProviderOptions.md#totalsformat)
- [totalsFormatter](GroupItemMetadataProviderOptions.md#totalsformatter)

## Properties

### enableExpandCollapse

• `Optional` **enableExpandCollapse**: `boolean`

#### Defined in

[data/groupitemmetadataprovider.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L5)

___

### groupCellCssClass

• `Optional` **groupCellCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L6)

___

### groupCssClass

• `Optional` **groupCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L7)

___

### groupFocusable

• `Optional` **groupFocusable**: `boolean`

#### Defined in

[data/groupitemmetadataprovider.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L9)

___

### groupFormat

• `Optional` **groupFormat**: [`ColumnFormat`](../README.md#columnformat)<[`Group`](../classes/Group.md)<`any`\>\>

#### Defined in

[data/groupitemmetadataprovider.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L10)

___

### groupFormatter

• `Optional` **groupFormatter**: [`CompatFormatter`](../README.md#compatformatter)<[`Group`](../classes/Group.md)<`any`\>\>

#### Defined in

[data/groupitemmetadataprovider.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L11)

___

### groupIndentation

• `Optional` **groupIndentation**: `number`

#### Defined in

[data/groupitemmetadataprovider.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L8)

___

### groupLevelPrefix

• `Optional` **groupLevelPrefix**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L12)

___

### groupRowTotals

• `Optional` **groupRowTotals**: `boolean`

#### Defined in

[data/groupitemmetadataprovider.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L13)

___

### groupTitleCssClass

• `Optional` **groupTitleCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L14)

___

### hasSummaryType

• `Optional` **hasSummaryType**: (`column`: [`Column`](Column.md)<`any`\>) => `boolean`

#### Type declaration

▸ (`column`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `column` | [`Column`](Column.md)<`any`\> |

##### Returns

`boolean`

#### Defined in

[data/groupitemmetadataprovider.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L15)

___

### toggleCollapsedCssClass

• `Optional` **toggleCollapsedCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L18)

___

### toggleCssClass

• `Optional` **toggleCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L16)

___

### toggleExpandedCssClass

• `Optional` **toggleExpandedCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L17)

___

### totalsCssClass

• `Optional` **totalsCssClass**: `string`

#### Defined in

[data/groupitemmetadataprovider.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L19)

___

### totalsFocusable

• `Optional` **totalsFocusable**: `boolean`

#### Defined in

[data/groupitemmetadataprovider.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L20)

___

### totalsFormat

• `Optional` **totalsFormat**: [`ColumnFormat`](../README.md#columnformat)<[`GroupTotals`](../classes/GroupTotals.md)<`any`\>\>

#### Defined in

[data/groupitemmetadataprovider.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L21)

___

### totalsFormatter

• `Optional` **totalsFormatter**: [`CompatFormatter`](../README.md#compatformatter)<[`GroupTotals`](../classes/GroupTotals.md)<`any`\>\>

#### Defined in

[data/groupitemmetadataprovider.ts:22](https://github.com/serenity-is/sleekgrid/blob/master/src/data/groupitemmetadataprovider.ts#L22)
