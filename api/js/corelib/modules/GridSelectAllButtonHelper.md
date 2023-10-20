[@serenity-is/corelib](../README.md) / GridSelectAllButtonHelper

# Namespace: GridSelectAllButtonHelper

## Table of contents

### Functions

- [define](GridSelectAllButtonHelper.md#define)
- [update](GridSelectAllButtonHelper.md#update)

## Functions

### define

▸ **define**(`getGrid`, `getId`, `getSelected`, `setSelected`, `text?`, `onClick?`): [`ToolButton`](../interfaces/ToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `getGrid` | () => [`IDataGrid`](../interfaces/IDataGrid.md) |
| `getId` | (`p1`: `any`) => `any` |
| `getSelected` | (`p1`: `any`) => `boolean` |
| `setSelected` | (`p1`: `any`, `p2`: `boolean`) => `void` |
| `text?` | `string` |
| `onClick?` | () => `void` |

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L297)

___

### update

▸ **update**(`grid`, `getSelected`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `getSelected` | (`p1`: `any`) => `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L285)
