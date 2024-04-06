[@serenity-is/corelib](../README.md) / SlickTreeHelper

# Namespace: SlickTreeHelper

## Table of contents

### Functions

- [filterById](SlickTreeHelper.md#filterbyid)
- [filterCustom](SlickTreeHelper.md#filtercustom)
- [setCollapsed](SlickTreeHelper.md#setcollapsed)
- [setCollapsedFlag](SlickTreeHelper.md#setcollapsedflag)
- [setIndents](SlickTreeHelper.md#setindents)
- [toggleClick](SlickTreeHelper.md#toggleclick)

## Functions

### filterById

▸ **filterById**\<`TItem`\>(`item`, `view`, `getParentId`): `boolean`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |
| `view` | [`RemoteView`](../classes/RemoteView.md)\<`TItem`\> |
| `getParentId` | (`x`: `TItem`) => `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:759](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L759)

___

### filterCustom

▸ **filterCustom**\<`TItem`\>(`item`, `getParent`): `boolean`

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

[src/ui/helpers/slickhelpers.ts:743](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L743)

___

### setCollapsed

▸ **setCollapsed**\<`TItem`\>(`items`, `collapsed`): `void`

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

[src/ui/helpers/slickhelpers.ts:770](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L770)

___

### setCollapsedFlag

▸ **setCollapsedFlag**\<`TItem`\>(`item`, `collapsed`): `void`

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

[src/ui/helpers/slickhelpers.ts:778](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L778)

___

### setIndents

▸ **setIndents**\<`TItem`\>(`items`, `getId`, `getParentId`, `setCollapsed?`): `void`

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

[src/ui/helpers/slickhelpers.ts:782](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L782)

___

### toggleClick

▸ **toggleClick**\<`TItem`\>(`e`, `row`, `cell`, `view`, `getId`): `void`

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `Event` |
| `row` | `number` |
| `cell` | `number` |
| `view` | [`RemoteView`](../classes/RemoteView.md)\<`TItem`\> |
| `getId` | (`x`: `TItem`) => `any` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L813)
