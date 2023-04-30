[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / SlickTreeHelper

# Namespace: SlickTreeHelper

[corelib](corelib.md).SlickTreeHelper

## Table of contents

### Functions

- [filterById](corelib.SlickTreeHelper.md#filterbyid)
- [filterCustom](corelib.SlickTreeHelper.md#filtercustom)
- [setCollapsed](corelib.SlickTreeHelper.md#setcollapsed)
- [setCollapsedFlag](corelib.SlickTreeHelper.md#setcollapsedflag)
- [setIndents](corelib.SlickTreeHelper.md#setindents)
- [toggleClick](corelib.SlickTreeHelper.md#toggleclick)

## Functions

### filterById

▸ **filterById**<`TItem`\>(`item`, `view`, `getParentId`): `boolean`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TItem`\> |
| `getParentId` | (`x`: `TItem`) => `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L721)

___

### filterCustom

▸ **filterCustom**<`TItem`\>(`item`, `getParent`): `boolean`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `getParent` | (`x`: `TItem`) => `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L705)

___

### setCollapsed

▸ **setCollapsed**<`TItem`\>(`items`, `collapsed`): `void`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |
| `collapsed` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:732](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L732)

___

### setCollapsedFlag

▸ **setCollapsedFlag**<`TItem`\>(`item`, `collapsed`): `void`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `collapsed` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L740)

___

### setIndents

▸ **setIndents**<`TItem`\>(`items`, `getId`, `getParentId`, `setCollapsed?`): `void`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `TItem`[] |
| `getId` | (`x`: `TItem`) => `any` |
| `getParentId` | (`x`: `TItem`) => `any` |
| `setCollapsed?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:744](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L744)

___

### toggleClick

▸ **toggleClick**<`TItem`\>(`e`, `row`, `cell`, `view`, `getId`): `void`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |
| `row` | `number` |
| `cell` | `number` |
| `view` | [`RemoteView`](../classes/corelib_slick.RemoteView.md)<`TItem`\> |
| `getId` | (`x`: `TItem`) => `any` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:775](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L775)
