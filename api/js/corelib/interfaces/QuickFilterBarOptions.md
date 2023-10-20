[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / QuickFilterBarOptions

# Interface: QuickFilterBarOptions

## Table of contents

### Properties

- [filters](QuickFilterBarOptions.md#filters)
- [getTitle](QuickFilterBarOptions.md#gettitle)
- [idPrefix](QuickFilterBarOptions.md#idprefix)

## Properties

### filters

• **filters**: [`QuickFilter`](QuickFilter.md)<[`Widget`](../classes/Widget.md)<`any`\>, `any`\>[]

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L11)

___

### getTitle

• `Optional` **getTitle**: (`filter`: [`QuickFilter`](QuickFilter.md)<[`Widget`](../classes/Widget.md)<`any`\>, `any`\>) => `string`

#### Type declaration

▸ (`filter`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`QuickFilter`](QuickFilter.md)<[`Widget`](../classes/Widget.md)<`any`\>, `any`\> |

##### Returns

`string`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L12)

___

### idPrefix

• `Optional` **idPrefix**: `string`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L13)
