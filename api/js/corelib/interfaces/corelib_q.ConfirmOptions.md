[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / ConfirmOptions

# Interface: ConfirmOptions

[corelib/q](../modules/corelib_q.md).ConfirmOptions

## Hierarchy

- [`CommonDialogOptions`](corelib_q.CommonDialogOptions.md)

  ↳ **`ConfirmOptions`**

## Table of contents

### Properties

- [bootstrap](corelib_q.ConfirmOptions.md#bootstrap)
- [buttons](corelib_q.ConfirmOptions.md#buttons)
- [cancelButton](corelib_q.ConfirmOptions.md#cancelbutton)
- [dialogClass](corelib_q.ConfirmOptions.md#dialogclass)
- [htmlEncode](corelib_q.ConfirmOptions.md#htmlencode)
- [modalClass](corelib_q.ConfirmOptions.md#modalclass)
- [noButton](corelib_q.ConfirmOptions.md#nobutton)
- [onCancel](corelib_q.ConfirmOptions.md#oncancel)
- [onClose](corelib_q.ConfirmOptions.md#onclose)
- [onNo](corelib_q.ConfirmOptions.md#onno)
- [onOpen](corelib_q.ConfirmOptions.md#onopen)
- [preWrap](corelib_q.ConfirmOptions.md#prewrap)
- [result](corelib_q.ConfirmOptions.md#result)
- [title](corelib_q.ConfirmOptions.md#title)
- [yesButton](corelib_q.ConfirmOptions.md#yesbutton)
- [yesButtonClass](corelib_q.ConfirmOptions.md#yesbuttonclass)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[bootstrap](corelib_q.CommonDialogOptions.md#bootstrap)

#### Defined in

[src/q/dialogs.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;27)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](corelib_q.DialogButton.md)[]

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[buttons](corelib_q.CommonDialogOptions.md#buttons)

#### Defined in

[src/q/dialogs.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;25)

___

### cancelButton

• `Optional` **cancelButton**: `string` \| `boolean`

#### Defined in

[src/q/dialogs.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;270)

___

### dialogClass

• `Optional` **dialogClass**: `string`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[dialogClass](corelib_q.CommonDialogOptions.md#dialogclass)

#### Defined in

[src/q/dialogs.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;24)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[htmlEncode](corelib_q.CommonDialogOptions.md#htmlencode)

#### Defined in

[src/q/dialogs.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;22)

___

### modalClass

• `Optional` **modalClass**: `string`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[modalClass](corelib_q.CommonDialogOptions.md#modalclass)

#### Defined in

[src/q/dialogs.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;26)

___

### noButton

• `Optional` **noButton**: `string` \| `boolean`

#### Defined in

[src/q/dialogs.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;269)

___

### onCancel

• `Optional` **onCancel**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;271)

___

### onClose

• `Optional` **onClose**: (`result`: `string`) => `void`

#### Type declaration

▸ (`result`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

##### Returns

`void`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onClose](corelib_q.CommonDialogOptions.md#onclose)

#### Defined in

[src/q/dialogs.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;20)

___

### onNo

• `Optional` **onNo**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;272)

___

### onOpen

• `Optional` **onOpen**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onOpen](corelib_q.CommonDialogOptions.md#onopen)

#### Defined in

[src/q/dialogs.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;19)

___

### preWrap

• `Optional` **preWrap**: `boolean`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[preWrap](corelib_q.CommonDialogOptions.md#prewrap)

#### Defined in

[src/q/dialogs.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;23)

___

### result

• `Optional` **result**: `string`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[result](corelib_q.CommonDialogOptions.md#result)

#### Defined in

[src/q/dialogs.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;28)

___

### title

• `Optional` **title**: `string`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[title](corelib_q.CommonDialogOptions.md#title)

#### Defined in

[src/q/dialogs.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;21)

___

### yesButton

• `Optional` **yesButton**: `string` \| `boolean`

#### Defined in

[src/q/dialogs.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;267)

___

### yesButtonClass

• `Optional` **yesButtonClass**: `string`

#### Defined in

[src/q/dialogs.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;268)
