[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / ConfirmOptions

# Interface: ConfirmOptions

[corelib/q](../modules/corelib_q.md).ConfirmOptions

Additional options for confirm dialog

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

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[bootstrap](corelib_q.CommonDialogOptions.md#bootstrap)

#### Defined in

[src/q/dialogs.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;49)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](corelib_q.DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[buttons](corelib_q.CommonDialogOptions.md#buttons)

#### Defined in

[src/q/dialogs.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;45)

___

### cancelButton

• `Optional` **cancelButton**: `string` \| `boolean`

Title of the CANCEL button, or false to hide the Cancel button. Default is value of local text: "Dialogs.NoButton"

#### Defined in

[src/q/dialogs.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;367)

___

### dialogClass

• `Optional` **dialogClass**: `string`

Dialog css class. Default is based on the message dialog type

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[dialogClass](corelib_q.CommonDialogOptions.md#dialogclass)

#### Defined in

[src/q/dialogs.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;43)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[htmlEncode](corelib_q.CommonDialogOptions.md#htmlencode)

#### Defined in

[src/q/dialogs.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;39)

___

### modalClass

• `Optional` **modalClass**: `string`

Class to use for the modal element for Bootstrap dialogs

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[modalClass](corelib_q.CommonDialogOptions.md#modalclass)

#### Defined in

[src/q/dialogs.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;47)

___

### noButton

• `Optional` **noButton**: `string` \| `boolean`

Title of the NO button, or false to hide the No button. Default is value of local text: "Dialogs.NoButton"

#### Defined in

[src/q/dialogs.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;365)

___

### onCancel

• `Optional` **onCancel**: () => `void`

#### Type declaration

▸ (): `void`

Event handler for cancel button click

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;369)

___

### onClose

• `Optional` **onClose**: (`result`: `string`) => `void`

#### Type declaration

▸ (`result`): `void`

Event handler that is called when dialog is closed

##### Parameters

| Name | Type |
| :------ | :------ |
| `result` | `string` |

##### Returns

`void`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onClose](corelib_q.CommonDialogOptions.md#onclose)

#### Defined in

[src/q/dialogs.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;35)

___

### onNo

• `Optional` **onNo**: () => `void`

#### Type declaration

▸ (): `void`

Event handler for no button click

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;371)

___

### onOpen

• `Optional` **onOpen**: () => `void`

#### Type declaration

▸ (): `void`

Event handler that is called when dialog is opened

##### Returns

`void`

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[onOpen](corelib_q.CommonDialogOptions.md#onopen)

#### Defined in

[src/q/dialogs.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;33)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[preWrap](corelib_q.CommonDialogOptions.md#prewrap)

#### Defined in

[src/q/dialogs.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;41)

___

### result

• `Optional` **result**: `string`

The result code of the button used to close the dialog is returned via this variable in the options object

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[result](corelib_q.CommonDialogOptions.md#result)

#### Defined in

[src/q/dialogs.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;51)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[CommonDialogOptions](corelib_q.CommonDialogOptions.md).[title](corelib_q.CommonDialogOptions.md#title)

#### Defined in

[src/q/dialogs.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;37)

___

### yesButton

• `Optional` **yesButton**: `string` \| `boolean`

Title of the Yes button, or false to hide the Yes button. Default is value of local text: "Dialogs.YesButton"

#### Defined in

[src/q/dialogs.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;361)

___

### yesButtonClass

• `Optional` **yesButtonClass**: `string`

CSS class for the Yes button.

#### Defined in

[src/q/dialogs.ts:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#line&#x3D;363)
