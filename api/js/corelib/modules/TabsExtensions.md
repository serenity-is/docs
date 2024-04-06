[@serenity-is/corelib](../README.md) / TabsExtensions

# Namespace: TabsExtensions

## Table of contents

### Functions

- [activeTabKey](TabsExtensions.md#activetabkey)
- [destroy](TabsExtensions.md#destroy)
- [indexByKey](TabsExtensions.md#indexbykey)
- [initialize](TabsExtensions.md#initialize)
- [selectTab](TabsExtensions.md#selecttab)
- [setDisabled](TabsExtensions.md#setdisabled)
- [toggle](TabsExtensions.md#toggle)

## Functions

### activeTabKey

▸ **activeTabKey**(`tabs`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`string`

#### Defined in

[src/ui/helpers/tabsextensions.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L80)

___

### destroy

▸ **destroy**(`tabs`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/ui/helpers/tabsextensions.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L215)

___

### indexByKey

▸ **indexByKey**(`tabs`): `Record`\<`string`, `number`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`Record`\<`string`, `number`\>

#### Defined in

[src/ui/helpers/tabsextensions.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L111)

___

### initialize

▸ **initialize**(`tabs`, `activeChange`): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `activeChange` | () => `void` |

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Defined in

[src/ui/helpers/tabsextensions.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L154)

___

### selectTab

▸ **selectTab**(`tabs`, `tabKey`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `tabKey` | `string` \| `number` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/tabsextensions.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L124)

___

### setDisabled

▸ **setDisabled**(`tabs`, `tabKey`, `isDisabled`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `tabKey` | `string` |
| `isDisabled` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/tabsextensions.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L9)

___

### toggle

▸ **toggle**(`tabs`, `tabKey`, `visible`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `tabs` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `tabKey` | `string` |
| `visible` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/tabsextensions.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/tabsextensions.ts#L45)
