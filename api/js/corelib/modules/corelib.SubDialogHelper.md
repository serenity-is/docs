[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / SubDialogHelper

# Namespace: SubDialogHelper

[corelib](corelib.md).SubDialogHelper

## Table of contents

### Functions

- [bindToDataChange](corelib.SubDialogHelper.md#bindtodatachange)
- [bubbleDataChange](corelib.SubDialogHelper.md#bubbledatachange)
- [cascade](corelib.SubDialogHelper.md#cascade)
- [cascadedDialogOffset](corelib.SubDialogHelper.md#cascadeddialogoffset)
- [triggerDataChange](corelib.SubDialogHelper.md#triggerdatachange)
- [triggerDataChanged](corelib.SubDialogHelper.md#triggerdatachanged)

## Functions

### bindToDataChange

▸ **bindToDataChange**(`dialog`, `owner`, `dataChange`, `useTimeout?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |
| `owner` | [`Widget`](../classes/corelib.Widget.md)<`any`\> |
| `dataChange` | (`p1`: `any`, `p2`: [`DataChangeInfo`](../interfaces/corelib.DataChangeInfo.md)) => `void` |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;5)

___

### bubbleDataChange

▸ **bubbleDataChange**(`dialog`, `owner`, `useTimeout?`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | `any` |
| `owner` | [`Widget`](../classes/corelib.Widget.md)<`any`\> |
| `useTimeout?` | `boolean` |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;33)

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

[src/ui/helpers/subdialoghelper.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;39)

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

[src/ui/helpers/subdialoghelper.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;46)

___

### triggerDataChange

▸ **triggerDataChange**(`dialog`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `dialog` | [`Widget`](../classes/corelib.Widget.md)<`any`\> |

#### Returns

`any`

#### Defined in

[src/ui/helpers/subdialoghelper.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;23)

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

[src/ui/helpers/subdialoghelper.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/subdialoghelper.ts#line&#x3D;28)
