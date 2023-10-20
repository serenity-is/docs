[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / SubDialogHelper

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
| `owner` | [`Widget`](../classes/Widget.md)<`any`\> |
| `dataChange` | (`p1`: `any`, `p2`: [`DataChangeInfo`](../interfaces/DataChangeInfo.md)) => `void` |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L5)

___

### bubbleDataChange

▸ **bubbleDataChange**(`dialog`, `owner`, `useTimeout?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |
| `owner` | [`Widget`](../classes/Widget.md)<`any`\> |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L33)

___

### cascade

▸ **cascade**(`cascadedDialog`, `ofElement`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cascadedDialog` | `any` |
| `ofElement` | `JQuery` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L39)

___

### cascadedDialogOffset

▸ **cascadedDialogOffset**(`element`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L46)

___

### triggerDataChange

▸ **triggerDataChange**(`dialog`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](../classes/Widget.md)<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L23)

___

### triggerDataChanged

▸ **triggerDataChanged**(`element`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`JQuery`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#L28)
