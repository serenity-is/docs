[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / GridSelectAllButtonHelper

# Namespace: GridSelectAllButtonHelper

[corelib](corelib.md).GridSelectAllButtonHelper

## Table of contents

### Functions

- [define](corelib.GridSelectAllButtonHelper.md#define)
- [update](corelib.GridSelectAllButtonHelper.md#update)

## Functions

### define

▸ **define**(`getGrid`, `getId`, `getSelected`, `setSelected`, `text?`, `onClick?`): [`ToolButton`](../interfaces/corelib.ToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getGrid` | () => [`IDataGrid`](../interfaces/corelib.IDataGrid.md) |
| `getId` | (`p1`: `any`) => `any` |
| `getSelected` | (`p1`: `any`) => `boolean` |
| `setSelected` | (`p1`: `any`, `p2`: `boolean`) => `void` |
| `text?` | `string` |
| `onClick?` | () => `void` |

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L297)

___

### update

▸ **update**(`grid`, `getSelected`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/corelib.IDataGrid.md) |
| `getSelected` | (`p1`: `any`) => `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L285)
