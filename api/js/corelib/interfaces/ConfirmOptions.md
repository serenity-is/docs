[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / ConfirmOptions

# Interface: ConfirmOptions

Additional options for confirm dialog

## Hierarchy

- [`CommonDialogOptions`](CommonDialogOptions.md)

  ↳ **`ConfirmOptions`**

## Table of contents

### Properties

- [bootstrap](ConfirmOptions.md#bootstrap)
- [buttons](ConfirmOptions.md#buttons)
- [cancelButton](ConfirmOptions.md#cancelbutton)
- [dialogClass](ConfirmOptions.md#dialogclass)
- [htmlEncode](ConfirmOptions.md#htmlencode)
- [modalClass](ConfirmOptions.md#modalclass)
- [noButton](ConfirmOptions.md#nobutton)
- [onCancel](ConfirmOptions.md#oncancel)
- [onClose](ConfirmOptions.md#onclose)
- [onNo](ConfirmOptions.md#onno)
- [onOpen](ConfirmOptions.md#onopen)
- [preWrap](ConfirmOptions.md#prewrap)
- [result](ConfirmOptions.md#result)
- [title](ConfirmOptions.md#title)
- [yesButton](ConfirmOptions.md#yesbutton)
- [yesButtonClass](ConfirmOptions.md#yesbuttonclass)

## Properties

### bootstrap

• `Optional` **bootstrap**: `boolean`

True to use Bootstrap dialogs even when jQuery UI  present, default is based on `Q.Config.bootstrapMessages

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[bootstrap](CommonDialogOptions.md#bootstrap)

#### Defined in

[src/q/dialogs.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L50)

___

### buttons

• `Optional` **buttons**: [`DialogButton`](DialogButton.md)[]

List of buttons to show on the dialog

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[buttons](CommonDialogOptions.md#buttons)

#### Defined in

[src/q/dialogs.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L46)

___

### cancelButton

• `Optional` **cancelButton**: `string` \| `boolean`

Title of the CANCEL button, or false to hide the Cancel button. Default is value of local text: "Dialogs.NoButton"

#### Defined in

[src/q/dialogs.ts:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L378)

___

### dialogClass

• `Optional` **dialogClass**: `string`

Dialog css class. Default is based on the message dialog type

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[dialogClass](CommonDialogOptions.md#dialogclass)

#### Defined in

[src/q/dialogs.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L44)

___

### htmlEncode

• `Optional` **htmlEncode**: `boolean`

HTML encode the message, default is true

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[htmlEncode](CommonDialogOptions.md#htmlencode)

#### Defined in

[src/q/dialogs.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L40)

___

### modalClass

• `Optional` **modalClass**: `string`

Class to use for the modal element for Bootstrap dialogs

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[modalClass](CommonDialogOptions.md#modalclass)

#### Defined in

[src/q/dialogs.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L48)

___

### noButton

• `Optional` **noButton**: `string` \| `boolean`

Title of the NO button, or false to hide the No button. Default is value of local text: "Dialogs.NoButton"

#### Defined in

[src/q/dialogs.ts:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L376)

___

### onCancel

• `Optional` **onCancel**: () => `void`

#### Type declaration

▸ (): `void`

Event handler for cancel button click

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L380)

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

[CommonDialogOptions](CommonDialogOptions.md).[onClose](CommonDialogOptions.md#onclose)

#### Defined in

[src/q/dialogs.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L36)

___

### onNo

• `Optional` **onNo**: () => `void`

#### Type declaration

▸ (): `void`

Event handler for no button click

##### Returns

`void`

#### Defined in

[src/q/dialogs.ts:382](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L382)

___

### onOpen

• `Optional` **onOpen**: () => `void`

#### Type declaration

▸ (): `void`

Event handler that is called when dialog is opened

##### Returns

`void`

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[onOpen](CommonDialogOptions.md#onopen)

#### Defined in

[src/q/dialogs.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L34)

___

### preWrap

• `Optional` **preWrap**: `boolean`

Wrap the message in a `<pre>` element, so that line endings are preserved, default is true

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[preWrap](CommonDialogOptions.md#prewrap)

#### Defined in

[src/q/dialogs.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L42)

___

### result

• `Optional` **result**: `string`

The result code of the button used to close the dialog is returned via this variable in the options object

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[result](CommonDialogOptions.md#result)

#### Defined in

[src/q/dialogs.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L52)

___

### title

• `Optional` **title**: `string`

Dialog title

#### Inherited from

[CommonDialogOptions](CommonDialogOptions.md).[title](CommonDialogOptions.md#title)

#### Defined in

[src/q/dialogs.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L38)

___

### yesButton

• `Optional` **yesButton**: `string` \| `boolean`

Title of the Yes button, or false to hide the Yes button. Default is value of local text: "Dialogs.YesButton"

#### Defined in

[src/q/dialogs.ts:372](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L372)

___

### yesButtonClass

• `Optional` **yesButtonClass**: `string`

CSS class for the Yes button.

#### Defined in

[src/q/dialogs.ts:374](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/dialogs.ts#L374)
