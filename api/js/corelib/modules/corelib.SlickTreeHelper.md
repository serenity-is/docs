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
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TItem`\> |
| `getParentId` | (`x`: `TItem`) => `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:723](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L723)

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

[src/ui/helpers/slickhelpers.ts:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L707)

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

[src/ui/helpers/slickhelpers.ts:734](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L734)

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

[src/ui/helpers/slickhelpers.ts:742](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L742)

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

[src/ui/helpers/slickhelpers.ts:746](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L746)

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
| `view` | [`RemoteView`](../classes/slick.RemoteView.md)<`TItem`\> |
| `getId` | (`x`: `TItem`) => `any` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L777)
