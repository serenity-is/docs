[@serenity-is/corelib](../README.md) / SubDialogHelper

# Namespace: SubDialogHelper

## Table of contents

### Functions

- [bindToDataChange](SubDialogHelper.md#bindtodatachange)
- [bubbleDataChange](SubDialogHelper.md#bubbledatachange)
- [cascade](SubDialogHelper.md#cascade)
- [cascadedDialogOffset](SubDialogHelper.md#cascadeddialogoffset)
- [triggerDataChange](SubDialogHelper.md#triggerdatachange)
- [triggerDataChanged](SubDialogHelper.md#triggerdatachanged)

## Functions

### bindToDataChange

▸ **bindToDataChange**(`dialog`, `owner`, `dataChange`, `useTimeout?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |
| `owner` | [`Widget`](../classes/Widget.md)\<`any`\> |
| `dataChange` | (`ev`: [`DataChangeInfo`](../interfaces/DataChangeInfo.md)) => `void` |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L6)

___

### bubbleDataChange

▸ **bubbleDataChange**(`dialog`, `owner`, `useTimeout?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |
| `owner` | [`Widget`](../classes/Widget.md)\<`any`\> |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L37)

___

### cascade

▸ **cascade**(`cascadedDialog`, `ofElement`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cascadedDialog` | `Object` |
| `cascadedDialog.domNode` | `HTMLElement` |
| `ofElement` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L43)

___

### cascadedDialogOffset

▸ **cascadedDialogOffset**(`element`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L53)

___

### triggerDataChange

▸ **triggerDataChange**(`dialog`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](../classes/Widget.md)\<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L28)

___

### triggerDataChanged

▸ **triggerDataChanged**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L33)
